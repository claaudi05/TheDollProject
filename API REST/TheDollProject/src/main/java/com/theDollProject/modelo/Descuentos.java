package com.theDollProject.modelo;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnore;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "descuentos")
public class Descuentos {

	@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

	private double precio;
	private double porcentaje;
	
	@OneToMany(mappedBy = "descuentos", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<Pedidos> pedidos;

	
/////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////

	public Descuentos(int id, double precio, double porcentaje) {
		super();
		this.id = id;
		this.precio = precio;
		this.porcentaje = porcentaje;
	}

	public Descuentos() {
		super();
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public double getPrecio() {
		return precio;
	}

	public void setPrecio(double precio) {
		this.precio = precio;
	}

	public double getPorcentaje() {
		return porcentaje;
	}

	public void setPorcentaje(double porcentaje) {
		this.porcentaje = porcentaje;
	}

	public List<Pedidos> getPedidos() {
		return pedidos;
	}

	public void setPedidos(List<Pedidos> pedidos) {
		this.pedidos = pedidos;
	}
	
	
	
}
