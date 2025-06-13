package com.theDollProject.repository;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.theDollProject.modelo.Cesta;
import com.theDollProject.modelo.Productos;
import com.theDollProject.modelo.Usuarios;

@Repository
public interface CestaRepository extends JpaRepository<Cesta, Integer> {
	Cesta findByUsuariosAndProductos(Usuarios usuario, Productos producto);

    List<Cesta> findByUsuariosId(int idUsuario);
    
    Optional<Cesta> findByUsuariosIdAndProductosId(int idUsuario, int idProducto);
    
    List<Cesta> findByUsuariosIdAndProductosNombreContainingIgnoreCaseOrUsuariosIdAndProductosDescripcionContainingIgnoreCase(
    	    int idUsuario1, String nombre, int idUsuario2, String descripcion
    	);

}
