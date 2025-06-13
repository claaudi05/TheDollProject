package com.theDollProject.cifrar;

import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.security.KeyFactory;
import java.security.PrivateKey;
import java.security.spec.PKCS8EncodedKeySpec;
import java.util.Base64;

import javax.crypto.Cipher;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

public class HybridCryptoUtil {

	 public static PrivateKey cargarClavePrivada(String rutaArchivo) throws Exception {
	        String keyPEM = new String(Files.readAllBytes(Paths.get(rutaArchivo)), StandardCharsets.UTF_8);
	        keyPEM = keyPEM
	                .replace("-----BEGIN PRIVATE KEY-----", "")
	                .replace("-----END PRIVATE KEY-----", "")
	                .replaceAll("\\s+", "");

	        byte[] keyBytes = Base64.getDecoder().decode(keyPEM);
	        PKCS8EncodedKeySpec keySpec = new PKCS8EncodedKeySpec(keyBytes);
	        KeyFactory kf = KeyFactory.getInstance("RSA");
	        return kf.generatePrivate(keySpec);
	    }

	    public static byte[] descifrarRSA(byte[] encryptedKey, PrivateKey privateKey) throws Exception {
	        Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
	        cipher.init(Cipher.DECRYPT_MODE, privateKey);
	        return cipher.doFinal(encryptedKey);
	    }

	    public static String descifrarAES(byte[] encryptedData, byte[] key, byte[] iv) throws Exception {
	        SecretKeySpec secretKey = new SecretKeySpec(key, "AES");
	        IvParameterSpec ivSpec = new IvParameterSpec(iv);
	        Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
	        cipher.init(Cipher.DECRYPT_MODE, secretKey, ivSpec);
	        byte[] decrypted = cipher.doFinal(encryptedData);
	        return new String(decrypted, StandardCharsets.UTF_8);
	    }
	
}
