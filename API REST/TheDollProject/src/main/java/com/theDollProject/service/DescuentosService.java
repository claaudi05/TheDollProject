package com.theDollProject.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.Descuentos;
import com.theDollProject.repository.DescuentosRepository;

@Service
public class DescuentosService {

    @Autowired
    private DescuentosRepository descuentosRepository;

    public List<Descuentos> obtenerTodos() {
        return descuentosRepository.findAll();
    }

    public Descuentos guardar(Descuentos descuento) {
        return descuentosRepository.save(descuento);
    }

    public Optional<Descuentos> obtenerPorId(int id) {
        return descuentosRepository.findById(id);
    }

    public Descuentos actualizar(Descuentos descuento) {
        return descuentosRepository.save(descuento);
    }

    public void eliminar(int id) {
        descuentosRepository.deleteById(id);
    }
}
