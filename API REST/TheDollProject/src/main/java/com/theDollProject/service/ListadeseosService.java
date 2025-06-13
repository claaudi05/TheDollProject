package com.theDollProject.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.Listadeseos;
import com.theDollProject.modelo.Productos;
import com.theDollProject.modelo.Usuarios;
import com.theDollProject.repository.ListadeseosRepository;
import com.theDollProject.repository.ProductoRepository;
import com.theDollProject.repository.UsuariosRepository;

@Service
public class ListadeseosService {

	@Autowired
	private ListadeseosRepository listadeseosRepository;
	@Autowired
	private UsuariosRepository usuariosRepository;
	@Autowired
	private ProductoRepository productosRepository;
	
	public void agregarProducto(int idUsuario, int idProducto) {
        Usuarios usuario = usuariosRepository.findById(idUsuario).orElseThrow();
        Productos producto = productosRepository.findById(idProducto).orElseThrow();

        // Evitar duplicados
        if (listadeseosRepository.findByUsuariosAndProductos(usuario, producto).isEmpty()) {
            Listadeseos lista = new Listadeseos();
            lista.setUsuarios(usuario);
            lista.setProductos(producto);
            listadeseosRepository.save(lista);
        }
    }

    public List<Listadeseos> obtenerListaDeseos(int idUsuario) {
        return listadeseosRepository.findByUsuariosId(idUsuario);
    }

    public void eliminarProducto(int idUsuario, int idProducto) {
        Usuarios usuario = usuariosRepository.findById(idUsuario).orElseThrow();
        Productos producto = productosRepository.findById(idProducto).orElseThrow();

        listadeseosRepository.findByUsuariosAndProductos(usuario, producto).ifPresent(listadeseosRepository::delete);
    }
	
}
