package com.theDollProject.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.modelo.Listadeseos;
import com.theDollProject.service.ListadeseosService;

@RestController
@RequestMapping("/listaDeseos")
public class ListadeseosController {

	@Autowired
	private ListadeseosService listadeseosService;
	
	@PostMapping("/agregar")
    public ResponseEntity<String> agregar(@RequestParam int idUsuario, @RequestParam int idProducto) {
		listadeseosService.agregarProducto(idUsuario, idProducto);
        return ResponseEntity.ok("Producto agregado a la lista de deseos");
    }

    @GetMapping("/usuario/{idUsuario}")
    public ResponseEntity<List<Listadeseos>> obtenerLista(@PathVariable int idUsuario) {
        List<Listadeseos> lista = listadeseosService.obtenerListaDeseos(idUsuario);
        return ResponseEntity.ok(lista);
    }

    @DeleteMapping("/eliminar")
    public ResponseEntity<String> eliminar(@RequestParam int idUsuario, @RequestParam int idProducto) {
    	listadeseosService.eliminarProducto(idUsuario, idProducto);
        return ResponseEntity.ok("Producto eliminado de la lista de deseos");
    }
	
}
