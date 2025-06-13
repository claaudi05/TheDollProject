package com.theDollProject.repository;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;

import com.theDollProject.modelo.Productos;
import com.theDollProject.modelo.Usuarios;
import com.theDollProject.modelo.Listadeseos;

public interface ListadeseosRepository extends JpaRepository<Listadeseos, Integer> {

	  List<Listadeseos> findByUsuariosId(int idUsuario);
	  Optional<Listadeseos> findByUsuariosAndProductos(Usuarios usuarios, Productos productos);
	
}
