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
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Perfil().Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nueva = textNuevaContraseña.Text.Trim();
            string repetir = textRepetirContraseña.Text.Trim();

            if (!ValidarContraseña(nueva))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas y un carácter especial.");
                return;
            }

            if (nueva != repetir)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Cifrar la nueva contraseña antes de enviarla
            var rsa = new RsaEncryptor();
            string contraseñaCifrada = rsa.Encrypt(nueva);

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(contraseñaCifrada, Encoding.UTF8, "text/plain");

                var response = client.PutAsync($"http://localhost:8082/usuarios/cambiarContraseña/{Sesion.UsuarioActual.id}", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contraseña cambiada correctamente.");
                    this.Hide();
                    new Perfil().Show();
                }
                else
                {
                    MessageBox.Show("Error al cambiar la contraseña.");
                }
            }
        }
    }
}
