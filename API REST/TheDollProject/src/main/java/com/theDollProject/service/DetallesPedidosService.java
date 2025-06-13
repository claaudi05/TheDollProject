package com.theDollProject.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.DetallesPedidos;
import com.theDollProject.repository.DetallesPedidosRepository;

@Service
public class DetallesPedidosService {
	
	@Autowired
    private DetallesPedidosRepository detallePedidoRepository;

    public List<DetallesPedidos> obtenerDetallesPorPedido(int pedidoId) {
        return detallePedidoRepository.findByPedidosId(pedidoId);
    }

}
