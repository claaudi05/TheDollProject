package com.theDollProject.modelo;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnore;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Lob;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "productos")
public class Productos {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
	private String nombre;
	private String descripcion;
	private double precio;
	private int stock;
	private String marca;
	private boolean oferta;
	private double precio_oferta;
	
	//anotacion para un binario grande, como un longBlob en la base de datos
	@Lob
	private byte[] imagen;

	@OneToMany(mappedBy = "productos", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<Cesta> cesta = new ArrayList<>();

	@OneToMany(mappedBy = "productos", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<Listadeseos> listadeseos;
	
	@OneToMany(mappedBy = "productos", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<DetallesPedidos> detallesPedidos;

	/////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////
	
	public Productos() {
		super();
	}

	
	
	public Productos(int id, String nombre, String descripcion, double precio, int stock, String marca, Boolean oferta,
			double precio_oferta, byte[] imagen) {
		super();
		this.id = id;
		this.nombre = nombre;
		this.descripcion = descripcion;
		this.precio = precio;
		this.stock = stock;
		this.marca = marca;
		this.oferta = oferta;
		this.precio_oferta = precio_oferta;
		this.imagen = imagen;
	}



	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getDescripcion() {
		return descripcion;
	}

	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}

	public Double getPrecio() {
		return precio;
	}

	public void setPrecio(Double precio) {
		this.precio = precio;
	}

	public int getStock() {
		return stock;
	}

	public void setStock(int stock) {
		this.stock = stock;
	}

	public String getMarca() {
		return marca;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public boolean isOferta() {
		return oferta;
	}

	public void setOferta(boolean oferta) {
		this.oferta = oferta;
	}

	public double getPrecio_oferta() {
		return precio_oferta;
	}

	public void setPrecio_oferta(double precio_oferta) {
		this.precio_oferta = precio_oferta;
	}

	public byte[] getImagen() {
		return imagen;
	}

	public void setImagen(byte[] imagen) {
		this.imagen = imagen;
	}

	public List<Cesta> getCesta() {
	    return cesta;
	}

	public void setCesta(List<Cesta> cesta) {
	    this.cesta = cesta;
	}

	public List<Listadeseos> getListadeseos() {
		return listadeseos;
	}



	public void setListadeseos(List<Listadeseos> listadeseos) {
		this.listadeseos = listadeseos;
	}



	public List<DetallesPedidos> getDetallesPedidos() {
		return detallesPedidos;
	}



	public void setDetallesPedidos(List<DetallesPedidos> detallesPedidos) {
		this.detallesPedidos = detallesPedidos;
	}



	public void setPrecio(double precio) {
		this.precio = precio;
	}



	@Override
	public String toString() {
		return "Productos [id=" + id + ", nombre=" + nombre + ", descripcion=" + descripcion + ", precio=" + precio
				+ ", stock=" + stock + ", marca=" + marca + ", oferta=" + oferta + ", precio_oferta=" + precio_oferta
				+ ", imagen=" + Arrays.toString(imagen) + "]";
	}

	
	
}
