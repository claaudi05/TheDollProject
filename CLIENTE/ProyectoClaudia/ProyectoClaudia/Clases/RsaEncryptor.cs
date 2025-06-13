using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClaudia.Clases
{
    public class RsaEncryptor
    {
        // Claves públicas y privadas para cifrado y descifrado
        public RSAParameters PublicKey { get; private set; }
        public RSAParameters PrivateKey { get; private set; }
        
        // Rutas de los archivos donde se almacenan las claves
        private RSACryptoServiceProvider rsa;
        private const string PrivateKeyPath = "privateKey.bin";
        private const string PublicKeyPath = "publicKey.bin";

        public RsaEncryptor()
        {
            rsa = new RSACryptoServiceProvider(2048);

            if (File.Exists(PrivateKeyPath) && File.Exists(PublicKeyPath))
            {
                // Cargar claves desde archivos
                PrivateKey = LoadKey(PrivateKeyPath);
                PublicKey = LoadKey(PublicKeyPath);
            }
            else
            {
                // Generar claves solo una vez
                PublicKey = rsa.ExportParameters(false);
                PrivateKey = rsa.ExportParameters(true);

                // Guardar las claves
                SaveKey(PublicKeyPath, PublicKey);
                SaveKey(PrivateKeyPath, PrivateKey);
            }

            rsa.ImportParameters(PrivateKey);
        }

        // Método para cifrar un texto utilizando la clave pública
        public string Encrypt(string plainText)
        {
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = rsa.Encrypt(data, false);
            return Convert.ToBase64String(encryptedData);
        }

        // Método para descifrar un texto cifrado utilizando la clave privada
        public string Decrypt(string base64Encrypted)
        {
            byte[] encryptedData = Convert.FromBase64String(base64Encrypted);
            byte[] decryptedData = rsa.Decrypt(encryptedData, false);
            return Encoding.UTF8.GetString(decryptedData);
        }

        // Método para guardar las claves en archivos binarios
        private void SaveKey(string path, RSAParameters key)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(key.Modulus);
                writer.Write(key.Exponent);

                // Si la clave es privada, también guarda los demás parámetros
                if (key.D != null)
                {
                    writer.Write(key.D);
                    writer.Write(key.P);
                    writer.Write(key.Q);
                    writer.Write(key.DP);
                    writer.Write(key.DQ);
                    writer.Write(key.InverseQ);
                }
            }
        }

        private RSAParameters LoadKey(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                RSAParameters key = new RSAParameters
                {
                    Modulus = reader.ReadBytes(256),
                    Exponent = reader.ReadBytes(3)
                };

                // Si el archivo es lo suficientemente grande, significa que contiene la clave privada
                if (reader.BaseStream.Length > 259) // Clave privada
                {
                    key.D = reader.ReadBytes(256);
                    key.P = reader.ReadBytes(128);
                    key.Q = reader.ReadBytes(128);
                    key.DP = reader.ReadBytes(128);
                    key.DQ = reader.ReadBytes(128);
                    key.InverseQ = reader.ReadBytes(128);
                }

                return key;
            }
        }
    }
}
