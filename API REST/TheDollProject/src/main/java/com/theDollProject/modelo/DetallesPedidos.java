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
@Table(name = "detallespedidos")
public class DetallesPedidos {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
	
	@ManyToOne
	@JoinColumn(name = "id_pedido", nullable = false)
	private Pedidos pedidos;
	
	@ManyToOne
	@JoinColumn(name = "id_producto", nullable = false)
	private Productos productos;
	
	private int cantidad;

	 /////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////

	public DetallesPedidos(int id, Pedidos pedidos, Productos productos, int cantidad) {
		super();
		this.id = id;
		this.pedidos = pedidos;
		this.productos = productos;
		this.cantidad = cantidad;
	}

	public DetallesPedidos() {
		super();
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Pedidos getPedidos() {
		return pedidos;
	}

	public void setPedidos(Pedidos pedidos) {
		this.pedidos = pedidos;
	}

	public Productos getProductos() {
		return productos;
	}

	public void setProductos(Productos productos) {
		this.productos = productos;
	}

	public int getCantidad() {
		return cantidad;
	}

	public void setCantidad(int cantidad) {
		this.cantidad = cantidad;
	}
	
}
