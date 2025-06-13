package com.theDollProject.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.modelo.Productos;
import com.theDollProject.service.ProductoService;

@RestController
@RequestMapping("/productos")
public class ProductoController {
	
	@Autowired
    private ProductoService productoService;


    @GetMapping("/obtenerProductos")
    public List<Productos> obtenerTodosProductos(){
    	return productoService.obtenerTodosProductos();
    }
	
    @PostMapping("/guardarProductos")
    public void guardarProducto(@RequestBody Productos producto) {
		 productoService.guardarProducto(producto);
	}
 
    @PostMapping("/eliminarProductos")
    public void eliminarProducto(@RequestBody int id) {
		 productoService.eliminarProducto(id);
	}
    
    @PutMapping("/modificarProducto")
    public void modificarProducto(@RequestBody Productos producto) {
        productoService.modificarProducto(producto);
    }
    
    @GetMapping("/buscarProductos")
    public List<Productos> buscarProductos(@RequestParam String texto){
    	return productoService.buscarProductos(texto);
    }

    @GetMapping("/buscarMarca")
    public List<Productos> obtenerPorMarca(@RequestParam String marca) {
        return productoService.obtenerPorMarca(marca);
    }
    
    @GetMapping("/buscar")
    public List<Productos> buscar(@RequestParam String texto) {
        return productoService.buscarPorNombreODescripcion(texto);
    }

    @GetMapping("/obtenerProductosId")
    public Optional<Productos> obtenerProductoId(int id){
    	return productoService.obtenerProductoId(id);
    }
    
}
