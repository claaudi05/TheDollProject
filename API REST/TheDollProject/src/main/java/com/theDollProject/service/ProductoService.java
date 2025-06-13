package com.theDollProject.service;

import java.util.List;
import java.util.NoSuchElementException;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.Productos;
import com.theDollProject.repository.ProductoRepository;

@Service
public class ProductoService {
	
	@Autowired
	private ProductoRepository productoRepository;

	public List<Productos> obtenerTodosProductos(){
		
		return productoRepository.findAll();
	}
	
	public void guardarProducto(Productos producto) {
		 productoRepository.save(producto);
	}
	
	public void modificarProducto(Productos producto) {
		Optional<Productos> productoExistente = productoRepository.findById(producto.getId());

	    if (productoExistente.isPresent()) {
	        Productos existente = productoExistente.get();

	        byte[] nuevaImagen = producto.getImagen();
	        if (nuevaImagen == null || nuevaImagen.length == 0) {
	            producto.setImagen(existente.getImagen());
	        }

	        productoRepository.save(producto);
	    } else {
	        throw new NoSuchElementException("Producto no encontrado con id: " + producto.getId());
	    }
	}

	
	public void eliminarProducto(int id) {
	    productoRepository.deleteById(id);
	}
	
	public List<Productos> buscarProductos(String texto){
		return productoRepository.findByNombreContainingIgnoreCase(texto);
	}
	
	public List<Productos> obtenerPorMarca(String marca) {
	    return productoRepository.findByMarca(marca);
	}

	public List<Productos> buscarPorNombreODescripcion(String texto) {
	    return productoRepository.findByNombreContainingIgnoreCaseOrDescripcionContainingIgnoreCase(texto, texto);
	}

	public Optional <Productos> obtenerProductoId(int id) {
		return productoRepository.findById(id);
	}

}
