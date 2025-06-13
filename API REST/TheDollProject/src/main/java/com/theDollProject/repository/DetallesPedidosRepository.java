package com.theDollProject.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.theDollProject.modelo.DetallesPedidos;

@Repository
public interface DetallesPedidosRepository extends JpaRepository<DetallesPedidos, Integer> {
	List<DetallesPedidos> findByPedidosId(int pedidoId);
}
