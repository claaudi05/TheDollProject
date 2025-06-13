using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonVolverRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private bool ValidarContraseña(string contraseña)
        {
            if (string.IsNullOrWhiteSpace(contraseña)) return false;

            bool tieneLongitud = contraseña.Length >= 8;
            bool tieneMayuscula = contraseña.Any(char.IsUpper);
            bool tieneMinuscula = contraseña.Any(char.IsLower);
            bool tieneEspecial = contraseña.Any(ch => !char.IsLetterOrDigit(ch));

            return tieneLongitud && tieneMayuscula && tieneMinuscula && tieneEspecial;
        }


        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textNombre.Text.Trim();
            string correo = textEmail.Text.Trim();
            string contraseña = textContraseña.Text.Trim();
            string repetirContraseña = textRepetirContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(repetirContraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            if (!ValidarContraseña(contraseña))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas y un carácter especial.");
                return;
            }

            if (contraseña != repetirContraseña)
            {
                MessageBox.Show("Las contraseñas deben de coincidir");
                return;
            }

            //Cifrar contraseña
            var rsa = new RsaEncryptor();
            string contraseñaCifrada = rsa.Encrypt(contraseña);

            var usuario = new
            {
                nombre = nombreUsuario,
                email = correo,
                contraseña = contraseñaCifrada,
                admin_usuarios = false,
                admin_productos = false,
                baneado = false
            };

            string json = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var response = client.PostAsync("http://localhost:8082/usuarios/guardarUsuario", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario guardado correctamente.");
                }
                else
                {
                    MessageBox.Show("Nombre o correo electronico en uso");
                }
            }
        }

    }
}
