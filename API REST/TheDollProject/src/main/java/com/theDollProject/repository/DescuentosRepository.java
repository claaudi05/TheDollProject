package com.theDollProject.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.theDollProject.modelo.Descuentos;

@Repository
public interface DescuentosRepository  extends JpaRepository<Descuentos, Integer>{
	 List<Descuentos> findByPrecioLessThanEqual(double total);
}
