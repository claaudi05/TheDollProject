package com.theDollProject.modelo;

import java.time.LocalDate;
import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnore;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "pedidos")
public class Pedidos {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
	
	@ManyToOne
	@JoinColumn(name = "id_usuario", nullable = false)
	private Usuarios usuarios;
	
	private LocalDate fecha_pedido;
	private boolean entregado = false;
	private double total;
	
	@ManyToOne
	@JoinColumn(name = "id_descuento", nullable = true)
	private Descuentos descuentos;
	
	private LocalDate fecha_estimada;
	
	@OneToMany(mappedBy = "pedidos", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<DetallesPedidos> detallesPedidos;
	 /////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////

	public Pedidos(int id, Usuarios usuarios, LocalDate fecha_pedido, boolean entregado, double total,
			Descuentos descuentos, LocalDate fecha_estimada) {
		super();
		this.id = id;
		this.usuarios = usuarios;
		this.fecha_pedido = fecha_pedido;
		this.entregado = entregado;
		this.total = total;
		this.descuentos = descuentos;
		this.fecha_estimada = fecha_estimada;
	}

	public Pedidos() {
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

	public LocalDate getFecha_pedido() {
		return fecha_pedido;
	}

	public void setFecha_pedido(LocalDate fecha_pedido) {
		this.fecha_pedido = fecha_pedido;
	}

	public boolean isEntregado() {
		return entregado;
	}

	public void setEntregado(boolean entregado) {
		this.entregado = entregado;
	}

	public double getTotal() {
		return total;
	}

	public void setTotal(double total) {
		this.total = total;
	}

	public Descuentos getDescuentos() {
		return descuentos;
	}

	public void setDescuentos(Descuentos descuentos) {
		this.descuentos = descuentos;
	}

	public LocalDate getFecha_estimada() {
		return fecha_estimada;
	}

	public void setFecha_estimada(LocalDate fecha_estimada) {
		this.fecha_estimada = fecha_estimada;
	}

	public List<DetallesPedidos> getDetallesPedidos() {
		return detallesPedidos;
	}

	public void setDetallesPedidos(List<DetallesPedidos> detallesPedidos) {
		this.detallesPedidos = detallesPedidos;
	}

}


