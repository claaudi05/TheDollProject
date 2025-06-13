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
@Table(name = "cesta")
public class Cesta {
	
		@Id
		@GeneratedValue(strategy = GenerationType.IDENTITY)
	    private int id;
	
		@ManyToOne
		@JoinColumn(name = "id_usuario", nullable = false)
		private Usuarios usuarios;
	
		@ManyToOne
		@JoinColumn(name = "id_producto", nullable = false)
		private Productos productos;
	
		private int cantidad;

		 /////////////////// GETTERS, SETTERS Y CONSTRUCTOR////////////////////////////
	 
		

		public Cesta() {
			super();
		}

		

		public Cesta(int id, Usuarios usuarios, Productos productos, int cantidad) {
			super();
			this.id = id;
			this.usuarios = usuarios;
			this.productos = productos;
			this.cantidad = cantidad;
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



		public int getCantidad() {
			return cantidad;
		}

		public void setCantidad(int cantidad) {
			this.cantidad = cantidad;
		}
		
		
		
}
