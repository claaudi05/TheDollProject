package com.theDollProject.service;

import java.security.PublicKey;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.theDollProject.modelo.Usuarios;
import com.theDollProject.repository.UsuariosRepository;

@Service
public class UsuariosService {
	
	@Autowired
	private UsuariosRepository usuariosRepository;
		
	public Optional<Usuarios> iniciarSesion(String identificador, String contraseña) {
	    Optional<Usuarios> usuario = usuariosRepository.findByNombre(identificador);

	    if (!usuario.isPresent()) {
	        usuario = usuariosRepository.findByEmail(identificador);
	    }

	    //Devuelve el usuario si existe, sin comprobar la contraseña
	    return usuario;
	}

	public void guardarUsuario(Usuarios usuario) throws Exception {
		validarUsuarioNuevo(usuario);
		 
		    usuario.setAdmin_productos(false);
		    usuario.setAdmin_usuarios(false);

		    usuariosRepository.save(usuario);
		
	}
	
	public void crearUsuario(Usuarios usuario) throws Exception {
		validarUsuarioNuevo(usuario);
		 if (usuariosRepository.existsByNombre(usuario.getNombre())) {
	            throw new Exception("El nombre de usuario ya existe");
		 }else if(usuariosRepository.existsByEmail(usuario.getEmail())) {
			 throw new Exception("Ya existe una cuenta con este correo");
		 }
		 
		 usuariosRepository.save(usuario);
		
	}
	
	private void validarUsuarioNuevo(Usuarios usuario) throws Exception {
        if (usuariosRepository.existsByNombre(usuario.getNombre())) {
            throw new Exception("El nombre de usuario ya existe");
        }
        if (usuariosRepository.existsByEmail(usuario.getEmail())) {
            throw new Exception("Ya existe una cuenta con este correo");
        }
    }
	
	public List<Usuarios> obtenerTodosUsuarios(){
		
		return usuariosRepository.findAll();
	}
	
	public List<Usuarios> buscarUsuariosNombre(String texto){
		return usuariosRepository.findByNombreContainingIgnoreCase(texto);
	}
	
	public List<Usuarios> buscarUsuariosEmail(String texto){
		return usuariosRepository.findByEmailContainingIgnoreCase(texto);
	}
	
	public void eliminarUsuario(int id) {
	    usuariosRepository.deleteById(id);
	}
	
	 public void modificarUsuario(Usuarios usuario) throws Exception {
	        Optional<Usuarios> usuarioExistente = usuariosRepository.findById(usuario.getId());
	        if (usuarioExistente.isPresent()) {
	            Usuarios existente = usuarioExistente.get();

	            if (usuario.getContraseña() == null || usuario.getContraseña().isBlank()) {
	                usuario.setContraseña(existente.getContraseña());
	            }

	            usuario.setClaveAES(null); // Asegura que no haya cifrado
	            usuariosRepository.save(usuario);
	        } else {
	            throw new Exception("Usuario no encontrado con id: " + usuario.getId());
	        }
	    }
	
	public byte[] getImagenById(int id) {
        return usuariosRepository.findById(id)
            .map(Usuarios::getImagen)
            .orElse(null);
    }

    public void actualizarImagen(int id, byte[] nuevaImagen) {
        usuariosRepository.findById(id).ifPresent(usuario -> {
            usuario.setImagen(nuevaImagen);
            usuariosRepository.save(usuario);
        });
    }
    
    public void actualizarContraseña(int id, String nuevaContrasena) {
        usuariosRepository.findById(id).ifPresent(usuario -> {
            usuario.setContraseña(nuevaContrasena);
            usuariosRepository.save(usuario);
        });
    }

	
}
