package com.theDollProject.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.modelo.DetallesPedidos;
import com.theDollProject.service.DetallesPedidosService;

@RestController
@RequestMapping("/detallesPedidos")
public class DetallesPedidosController {
	
	@Autowired
    private DetallesPedidosService detallePedidoService;

    @GetMapping("/pedido/{pedidoId}")
    public ResponseEntity<List<DetallesPedidos>> obtenerDetallesPorPedido(@PathVariable int pedidoId) {
        List<DetallesPedidos> detalles = detallePedidoService.obtenerDetallesPorPedido(pedidoId);
        return ResponseEntity.ok(detalles);
    }

}
