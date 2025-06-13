package com.theDollProject.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.modelo.Descuentos;
import com.theDollProject.repository.DescuentosRepository;
import com.theDollProject.service.DescuentosService;

@RestController
@RequestMapping("/descuentos")
public class DescuentosController {
	
	 @Autowired
	    private DescuentosService descuentosService;

	    // Obtener todos los descuentos
	    @GetMapping
	    public List<Descuentos> obtenerTodos() {
	        return descuentosService.obtenerTodos();
	    }

	    // Agregar un nuevo descuento
	    @PostMapping("/agregar")
	    public Descuentos agregar(@RequestBody Descuentos descuento) {
	        return descuentosService.guardar(descuento);
	    }

	    // Actualizar un descuento existente
	    @PutMapping("/actualizar")
	    public Descuentos actualizar(@RequestBody Descuentos descuento) {
	        Optional<Descuentos> existente = descuentosService.obtenerPorId(descuento.getId());
	        if (existente.isPresent()) {
	            return descuentosService.actualizar(descuento);
	        } else {
	            throw new RuntimeException("Descuento no encontrado con ID: " + descuento.getId());
	        }
	    }

	    // Eliminar un descuento por ID
	    @DeleteMapping("/eliminar")
	    public void eliminar(@RequestParam int id) {
	    	descuentosService.eliminar(id);
	    }

}
