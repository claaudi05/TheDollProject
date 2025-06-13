package com.theDollProject.repository;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.theDollProject.modelo.Usuarios;

@Repository
public interface UsuariosRepository extends JpaRepository<Usuarios, Integer>{
	
	Optional<Usuarios> findByNombre(String nombre);
	
	Optional<Usuarios> findByEmail(String email);

	boolean existsByNombre(String nombre);
	boolean existsByEmail(String email);
	
	List<Usuarios> findByNombreContainingIgnoreCase(String texto);
	List<Usuarios> findByEmailContainingIgnoreCase(String texto);
}
