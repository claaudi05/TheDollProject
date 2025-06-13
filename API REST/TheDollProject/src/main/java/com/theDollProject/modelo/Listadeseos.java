package com.theDollProject.modelo;

import com.fasterxml.jackson.annotation.JsonIgnore;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "listadeseos")
public class Listadeseos {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
    @ManyToOne
    @JoinColumn(name = "id_usuario",referencedColumnName = "id", nullable = false)
    private Usuarios usuarios;
	
    @ManyToOne
    @JoinColumn(name = "id_producto",referencedColumnName = "id", nullable = false)
    private Productos productos;

    /////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////
	 
	public Listadeseos(int id, Usuarios usuarios, Productos productos) {
		super();
		this.id = id;
		this.usuarios = usuarios;
		this.productos = productos;
	}

	public Listadeseos() {
		super();
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Usuarios getUsuarios() {
		return usuarios;
	}

	public void setUsuarios(Usuarios usuarios) {
		this.usuarios = usuarios;
	}

	public Productos getProductos() {
		return productos;
	}

	public void setProductos(Productos productos) {
		this.productos = productos;
	}
    
}
