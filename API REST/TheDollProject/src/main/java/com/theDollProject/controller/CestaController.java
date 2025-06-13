package com.theDollProject.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.theDollProject.modelo.Cesta;
import com.theDollProject.modelo.Productos;
import com.theDollProject.modelo.Usuarios;
import com.theDollProject.repository.CestaRepository;
import com.theDollProject.repository.ProductoRepository;
import com.theDollProject.repository.UsuariosRepository;
import com.theDollProject.service.CestaService;

@RestController
@RequestMapping("/cesta")
public class CestaController {
    @Autowired
    private CestaService cestaService;

    @GetMapping("/obtenerCesta")
    public ResponseEntity<List<Cesta>> obtenerCesta(@RequestParam int idUsuario) {
        List<Cesta> cesta = cestaService.obtenerCestaPorUsuario(idUsuario);
        return ResponseEntity.ok(cesta);
    }
    
    @PostMapping("/agregar")
    public ResponseEntity<String> agregarProductoACesta(@RequestParam int idUsuario, @RequestParam int idProducto) {
        boolean exito = cestaService.agregarOActualizarProducto(idUsuario, idProducto);

        if (exito) {
            return ResponseEntity.ok("Producto agregado o actualizado en la cesta");
        } else {
            return ResponseEntity.badRequest().body("No hay suficiente stock del producto");
        }
    }
    
    @PostMapping("/aumentar")
    public ResponseEntity<String> aumentarCantidad(
            @RequestParam int idUsuario, @RequestParam int idProducto) {
        return cestaService.aumentarCantidad(idUsuario, idProducto);
    }

    @PostMapping("/disminuir")
    public ResponseEntity<String> disminuirCantidad(
            @RequestParam int idUsuario, @RequestParam int idProducto) {
        return cestaService.disminuirCantidad(idUsuario, idProducto);
    }

    @DeleteMapping("/eliminar")
    public ResponseEntity<String> eliminarProducto(
            @RequestParam int idUsuario, @RequestParam int idProducto) {
        return cestaService.eliminarDeCesta(idUsuario, idProducto);
    }

    @GetMapping("/buscarProducto")
    public List<Cesta> buscar(@RequestParam int idUsuario, @RequestParam String texto) {
        return cestaService.buscarProductos(idUsuario, texto);
    }


}
