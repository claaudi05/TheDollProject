package com.theDollProject.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.theDollProject.modelo.Productos;

@Repository
public interface ProductoRepository extends JpaRepository<Productos, Integer>{
	List<Productos> findByNombreContainingIgnoreCase(String texto);
	
	List<Productos> findByMarca(String marca);

	List<Productos> findByNombreContainingIgnoreCaseOrDescripcionContainingIgnoreCase(String nombre, String descripcion);
	
}
