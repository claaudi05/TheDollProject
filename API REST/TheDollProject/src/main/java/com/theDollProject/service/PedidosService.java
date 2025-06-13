package com.theDollProject.service;

import java.time.LocalDate;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.Cesta;
import com.theDollProject.modelo.Descuentos;
import com.theDollProject.modelo.DetallesPedidos;
import com.theDollProject.modelo.Pedidos;
import com.theDollProject.modelo.Productos;
import com.theDollProject.modelo.Usuarios;
import com.theDollProject.repository.CestaRepository;
import com.theDollProject.repository.DescuentosRepository;
import com.theDollProject.repository.DetallesPedidosRepository;
import com.theDollProject.repository.PedidosRepository;
import com.theDollProject.repository.ProductoRepository;
import com.theDollProject.repository.UsuariosRepository;

@Service
public class PedidosService {
	
	@Autowired
	private PedidosRepository pedidoRepository;
	
	@Autowired
	private DetallesPedidosRepository detallesPedidoRepository;
	
	@Autowired
	private CestaRepository cestaRepository;
	
	@Autowired
	private UsuariosRepository usuarioRepository;
	
	@Autowired
	private DescuentosRepository descuentosRepository;
	
	@Autowired
	private ProductoRepository productosRepository;
	
	public void realizarCompra(int idUsuario) {
        Usuarios usuario = usuarioRepository.findById(idUsuario)
            .orElseThrow(() -> new RuntimeException("Usuario no encontrado"));

        List<Cesta> cesta = cestaRepository.findByUsuariosId(idUsuario);

        if (cesta.isEmpty()) {
            throw new RuntimeException("La cesta está vacía.");
        }

        double total = 0.0;

        // Verificar stock disponible
        for (Cesta item : cesta) {
            Productos producto = item.getProductos();
            int cantidadSolicitada = item.getCantidad();

            if (producto.getStock() < cantidadSolicitada) {
                throw new RuntimeException("No hay suficiente stock para el producto: " + producto.getNombre());
            }
        }

        // Calcular total
        for (Cesta item : cesta) {
            Productos p = item.getProductos();
            int cantidad = item.getCantidad();
            double precioUnitario = p.isOferta() ? p.getPrecio_oferta() : p.getPrecio();
            total += precioUnitario * cantidad;
        }

        // Buscar descuento
        List<Descuentos> descuentosValidos = descuentosRepository.findByPrecioLessThanEqual(total);
        Descuentos mejorDescuento = descuentosValidos.stream()
            .max((d1, d2) -> Double.compare(d1.getPorcentaje(), d2.getPorcentaje()))
            .orElse(null);

        double totalConDescuento = mejorDescuento != null
            ? total * (1 - mejorDescuento.getPorcentaje() / 100.0)
            : total;

        // Crear pedido (sin tarjeta)
        Pedidos pedido = new Pedidos();
        pedido.setUsuarios(usuario);
        pedido.setFecha_pedido(LocalDate.now());
        pedido.setFecha_estimada(LocalDate.now().plusDays(14));
        pedido.setTotal(totalConDescuento);
        pedido.setDescuentos(mejorDescuento);
        pedido.setEntregado(false);

        pedidoRepository.save(pedido);

        // Crear detalles y actualizar stock
        for (Cesta item : cesta) {
            Productos producto = item.getProductos();
            int cantidad = item.getCantidad();

            DetallesPedidos detalle = new DetallesPedidos();
            detalle.setPedidos(pedido);
            detalle.setProductos(producto);
            detalle.setCantidad(cantidad);
            detallesPedidoRepository.save(detalle);

            producto.setStock(producto.getStock() - cantidad);
        }

        // Guardar productos con stock actualizado
        cesta.stream()
            .map(Cesta::getProductos)
            .distinct()
            .forEach(productosRepository::save);

        // Vaciar la cesta
        cestaRepository.deleteAll(cesta);
    }

	public List<Pedidos> obtenerPedidosPorUsuario(int usuarioId) {
        return pedidoRepository.findByUsuariosId(usuarioId);
    }
	
	public List<Pedidos> obtenerPedidosNoEntregados() {
	    return pedidoRepository.findByEntregadoFalse();
	}

	public void marcarComoEntregado(int idPedido) {
	    Pedidos pedido = pedidoRepository.findById(idPedido)
	        .orElseThrow(() -> new RuntimeException("Pedido no encontrado"));
	    pedido.setEntregado(true);
	    pedidoRepository.save(pedido);
	}

	
}
