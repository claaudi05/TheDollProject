package com.theDollProject.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.theDollProject.modelo.Pedidos;

@Repository
public interface PedidosRepository extends JpaRepository<Pedidos, Integer>{
	   List<Pedidos> findByUsuariosId(int usuarioId);
	   List<Pedidos> findByEntregadoFalse();

}
