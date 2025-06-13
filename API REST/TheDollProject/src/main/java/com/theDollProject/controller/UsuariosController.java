package com.theDollProject.controller;
import java.io.StringWriter;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.PublicKey;
import java.security.interfaces.RSAPublicKey;
import java.util.Base64;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.dto.InicioSesionRequest;
import com.theDollProject.modelo.Usuarios;
import com.theDollProject.service.UsuariosService;

@RestController
@RequestMapping("/usuarios")
public class UsuariosController {
	
	@Autowired
	private UsuariosService usuariosService;
	
	@PostMapping("/inicioSesion")
	public ResponseEntity<Usuarios> iniciarSesion(@RequestBody InicioSesionRequest request){
		Optional<Usuarios> usuarios = usuariosService.iniciarSesion(request.getIdentificador(), request.getContraseña());
		return usuarios.map(ResponseEntity::ok).orElseGet(() -> ResponseEntity.status(HttpStatus.UNAUTHORIZED).build());

	}
	
	@PostMapping("/guardarUsuario")
    public void guardarUsuario(@RequestBody Usuarios usuario) throws Exception {
		 usuariosService.guardarUsuario(usuario);
	}
	
	@PostMapping("/crearUsuario")
	public void crearUsuario(@RequestBody Usuarios usuario) throws Exception {
		usuariosService.crearUsuario(usuario);
	}
	
	@GetMapping("/obtenerUsuarios")
    public List<Usuarios> obtenerTodosUsuarios(){
    	return usuariosService.obtenerTodosUsuarios();
    }
	
	@GetMapping("/buscarUsuariosNombre")
    public List<Usuarios> buscarUsuariosNombre(@RequestParam String texto){
    	return usuariosService.buscarUsuariosNombre(texto);
    }

	@GetMapping("/buscarUsuariosEmail")
    public List<Usuarios> buscarUsuariosEmail(@RequestParam String texto){
    	return usuariosService.buscarUsuariosEmail(texto);
    }
	
	@PostMapping("/eliminarUsuarios")
    public void eliminarUsuarios(@RequestBody int id) {
		 usuariosService.eliminarUsuario(id);
	}
	
	@PutMapping("/modificarUsuario")
	public void modificarUsuario(@RequestBody Usuarios usuario) throws Exception {
	    usuariosService.modificarUsuario(usuario);
	}

	@GetMapping("/imagen/{id}")
	public ResponseEntity<String> obtenerImagen(@PathVariable int id) {
	    byte[] imagen = usuariosService.getImagenById(id);
	    if (imagen == null || imagen.length == 0) {
	        return ResponseEntity.notFound().build();
	    }
	    String imagenBase64 = Base64.getEncoder().encodeToString(imagen);
	    return ResponseEntity.ok(imagenBase64);
	}

	@PutMapping("/imagen/{id}")
	public ResponseEntity<String> actualizarImagen(@PathVariable int id, @RequestBody byte[] imagen) {
	    usuariosService.actualizarImagen(id, imagen);
	    return ResponseEntity.ok("Imagen actualizada");
	}
	
	@PutMapping("/cambiarContraseña/{id}")
	public ResponseEntity<String> cambiarContraseña(@PathVariable int id, @RequestBody String nuevaContrasena) {
	    try {
	        usuariosService.actualizarContraseña(id, nuevaContrasena);
	        return ResponseEntity.ok("Contraseña actualizada");
	    } catch (Exception e) {
	        return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("Error al actualizar la contraseña");
	    }
	}

	@GetMapping("/clavePublica")
	public String obtenerClavePublica() throws Exception {
	    KeyPairGenerator keyGen = KeyPairGenerator.getInstance("RSA");
	    keyGen.initialize(2048);
	    KeyPair pair = keyGen.generateKeyPair();
	    PublicKey publicKey = pair.getPublic();

	    // Guarda la clave privada para su uso posterior
	    // Asegúrate de almacenar la clave privada de manera segura

	    // Convierte la clave pública a formato XML
	    StringWriter sw = new StringWriter();
	    sw.write("<RSAKeyValue>");
	    sw.write("<Modulus>" + Base64.getEncoder().encodeToString(((RSAPublicKey) publicKey).getModulus().toByteArray()) + "</Modulus>");
	    sw.write("<Exponent>" + Base64.getEncoder().encodeToString(((RSAPublicKey) publicKey).getPublicExponent().toByteArray()) + "</Exponent>");
	    sw.write("</RSAKeyValue>");
	    return sw.toString();
	}


}
