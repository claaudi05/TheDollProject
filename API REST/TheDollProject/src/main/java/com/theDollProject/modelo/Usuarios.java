package com.theDollProject.modelo;

import java.util.ArrayList;
import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnore;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Lob;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "usuarios")
public class Usuarios {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
	private String nombre;
	private String email;
	private String contraseña;
	private boolean admin_usuarios;
	private boolean admin_productos;
	
	//anotacion para un binario grande, como un longBlob en la base de datos
	@Lob
	private byte[] imagen;
	
	 // Clave AES cifrada con RSA (en Base64)
    @Column(name = "clave_aes", length = 512)
    private String claveAES;
	
	@OneToMany(mappedBy = "usuarios", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<Cesta> cesta;
	
	@OneToMany(mappedBy = "usuarios", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<Listadeseos> listadeseos;
	
	@OneToMany(mappedBy = "usuarios", cascade = CascadeType.ALL, orphanRemoval = true)
	@JsonIgnore
	private List<Pedidos> pedidos;


	/////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////
	
	public Usuarios() {
		super();
	}

	
	public Usuarios(int id, String nombre, String email, String contraseña, boolean admin_usuarios,
			boolean admin_productos, byte[] imagen, String claveAES) {
		super();
		this.id = id;
		this.nombre = nombre;
		this.email = email;
		this.contraseña = contraseña;
		this.admin_usuarios = admin_usuarios;
		this.admin_productos = admin_productos;
		this.imagen = imagen;
		this.claveAES = claveAES;
	}


	public Usuarios(int id, String nombre, String email, String contraseña, boolean admin_usuarios,
			boolean admin_productos, byte[] imagen, String claveAES, List<Cesta> cesta, List<Listadeseos> listadeseos) {
		super();
		this.id = id;
		this.nombre = nombre;
		this.email = email;
		this.contraseña = contraseña;
		this.admin_usuarios = admin_usuarios;
		this.admin_productos = admin_productos;
		this.imagen = imagen;
		this.claveAES = claveAES;
		this.cesta = cesta;
		this.listadeseos = listadeseos;
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

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getContraseña() {
		return contraseña;
	}

	public void setContraseña(String contraseña) {
		this.contraseña = contraseña;
	}

	public boolean isAdmin_usuarios() {
		return admin_usuarios;
	}

	public void setAdmin_usuarios(boolean admin_usuarios) {
		this.admin_usuarios = admin_usuarios;
	}

	public boolean isAdmin_productos() {
		return admin_productos;
	}

	public void setAdmin_productos(boolean admin_productos) {
		this.admin_productos = admin_productos;
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


	public String getClaveAES() {
		return claveAES;
	}


	public void setClaveAES(String claveAES) {
		this.claveAES = claveAES;
	}


	public List<Listadeseos> getListadeseos() {
		return listadeseos;
	}


	public void setListadeseos(List<Listadeseos> listadeseos) {
		this.listadeseos = listadeseos;
	}


	public List<Pedidos> getPedidos() {
		return pedidos;
	}


	public void setPedidos(List<Pedidos> pedidos) {
		this.pedidos = pedidos;
	}
		
}
