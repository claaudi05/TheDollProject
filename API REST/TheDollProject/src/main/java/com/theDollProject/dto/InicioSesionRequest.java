package com.theDollProject.dto;

public class InicioSesionRequest {
	
	private String identificador;
	private String contraseña;
	
	public InicioSesionRequest(String identificador, String contraseña) {
		super();
		this.identificador = identificador;
		this.contraseña = contraseña;
	}

	public InicioSesionRequest() {
		super();
	}

	public String getIdentificador() {
		return identificador;
	}

	public void setIdentificador(String identificador) {
		this.identificador = identificador;
	}

	public String getContraseña() {
		return contraseña;
	}

	public void setContraseña(String contraseña) {
		this.contraseña = contraseña;
	}

}
