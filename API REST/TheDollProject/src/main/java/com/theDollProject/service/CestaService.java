package com.theDollProject.service;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.Cesta;
import com.theDollProject.modelo.Productos;
import com.theDollProject.modelo.Usuarios;
import com.theDollProject.repository.CestaRepository;
import com.theDollProject.repository.ProductoRepository;
import com.theDollProject.repository.UsuariosRepository;

@Service
public class CestaService {

    @Autowired
    private CestaRepository cestaRepository;
    
    @Autowired
    private UsuariosRepository usuarioRepository;
    
    @Autowired
    private ProductoRepository productoRepository;

    public List<Cesta> obtenerCestaPorUsuario(int idUsuario) {
        return cestaRepository.findByUsuariosId(idUsuario);
    }
    
    public boolean agregarOActualizarProducto(int idUsuario, int idProducto) {
        Optional<Productos> productoOpt = productoRepository.findById(idProducto);
        Optional<Usuarios> usuarioOpt = usuarioRepository.findById(idUsuario);

        if (productoOpt.isEmpty() || usuarioOpt.isEmpty()) return false;

        Productos producto = productoOpt.get();
        Usuarios usuario = usuarioOpt.get();

        Cesta existente = cestaRepository.findByUsuariosAndProductos(usuario, producto);

        if (existente != null) {
            if (existente.getCantidad() + 1 > producto.getStock()) {
                return false;
            }
            existente.setCantidad(existente.getCantidad() + 1);
            cestaRepository.save(existente);
        } else {
            if (producto.getStock() < 1) return false;

            Cesta nueva = new Cesta();
            nueva.setUsuarios(usuario);
            nueva.setProductos(producto);
            nueva.setCantidad(1);
            cestaRepository.save(nueva);
        }

        return true;
    }

    public ResponseEntity<String> aumentarCantidad(int idUsuario, int idProducto) {
        Optional<Cesta> cestaOpt = cestaRepository.findByUsuariosIdAndProductosId(idUsuario, idProducto);
        if (cestaOpt.isPresent()) {
            Cesta cesta = cestaOpt.get();
            int cantidadActual = cesta.getCantidad();
            int stockDisponible = cesta.getProductos().getStock();

            if (cantidadActual + 1 <= stockDisponible) {
                cesta.setCantidad(cantidadActual + 1);
                cestaRepository.save(cesta);
                return ResponseEntity.ok("Cantidad aumentada.");
            } else {
                return ResponseEntity.badRequest().body("No hay suficiente stock.");
            }
        } else {
            return ResponseEntity.badRequest().body("Producto no encontrado en la cesta.");
        }
    }

    public ResponseEntity<String> disminuirCantidad(int idUsuario, int idProducto) {
        Optional<Cesta> cestaOpt = cestaRepository.findByUsuariosIdAndProductosId(idUsuario, idProducto);
        if (cestaOpt.isPresent()) {
            Cesta cesta = cestaOpt.get();
            int cantidadActual = cesta.getCantidad();

            if (cantidadActual > 1) {
                cesta.setCantidad(cantidadActual - 1);
                cestaRepository.save(cesta);
                return ResponseEntity.ok("Cantidad disminuida.");
            } else {
                cestaRepository.delete(cesta);
                return ResponseEntity.ok("Producto eliminado de la cesta.");
            }
        } else {
            return ResponseEntity.badRequest().body("Producto no encontrado en la cesta.");
        }
    }
    
    public ResponseEntity<String> eliminarDeCesta(int idUsuario, int idProducto) {
        Optional<Cesta> cestaOpt = cestaRepository.findByUsuariosIdAndProductosId(idUsuario, idProducto);
        if (cestaOpt.isPresent()) {
            cestaRepository.delete(cestaOpt.get());
            return ResponseEntity.ok("Producto eliminado de la cesta.");
        } else {
            return ResponseEntity.badRequest().body("Producto no encontrado en la cesta.");
        }
    }

    public List<Cesta> buscarProductos(int idUsuario, String texto) {
        return cestaRepository.findByUsuariosIdAndProductosNombreContainingIgnoreCaseOrUsuariosIdAndProductosDescripcionContainingIgnoreCase(
            idUsuario, texto, idUsuario, texto
        );
    }

}

