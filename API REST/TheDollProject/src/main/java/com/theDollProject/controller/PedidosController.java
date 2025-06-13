package com.theDollProject.controller;

import java.time.LocalDate;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.modelo.Pedidos;
import com.theDollProject.service.PedidosService;

@RestController
@RequestMapping("/pedido")
public class PedidosController {
	
	@Autowired
	private PedidosService pedidoService;

	@PostMapping("/realizar")
	public ResponseEntity<String> realizarCompra(@RequestParam int idUsuario) {
		try {

			pedidoService.realizarCompra(idUsuario);
			return ResponseEntity.ok("Pedido realizado con éxito.");
		} catch (Exception e) {
			return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Error: " + e.getMessage());
		}
	}
	
	 @GetMapping("/usuario/{usuarioId}")
	    public ResponseEntity<List<Pedidos>> obtenerPedidosPorUsuario(@PathVariable int usuarioId) {
	        List<Pedidos> pedidos = pedidoService.obtenerPedidosPorUsuario(usuarioId);
	        return ResponseEntity.ok(pedidos);
	    }
	 
	 @GetMapping("/pendientes")
	 public List<Pedidos> getPedidosPendientes() {
	     return pedidoService.obtenerPedidosNoEntregados();
	 }

	 @PutMapping("/marcarEntregado/{idPedido}")
	 public ResponseEntity<?> marcarEntregado(@PathVariable int idPedido) {
	     pedidoService.marcarComoEntregado(idPedido);
	     return ResponseEntity.ok().build();
	 }

}
