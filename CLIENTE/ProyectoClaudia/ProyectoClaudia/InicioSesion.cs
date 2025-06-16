using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {

            string identificador = textIdentificadorInicio.Text;
            string contraseña = textContraseñaInicio.Text;

            if (string.IsNullOrEmpty(identificador) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            RsaEncryptor rsa = new RsaEncryptor();

            var login = new
            {
                identificador = identificador
            };

            string json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var response = client.PostAsync("http://localhost:8082/usuarios/inicioSesion", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    var usuario = JsonConvert.DeserializeObject<Usuarios>(responseBody);

                    string contraseñaCifrada = usuario.contraseña;

                    //Desciframos con nuestra clave privada
                    string contraseñaDescifrada = rsa.Decrypt(contraseñaCifrada);

                    if (contraseña == contraseñaDescifrada)
                    {
                        Sesion.UsuarioActual = usuario;

                        if (usuario.admin_usuarios)
                        {
                            this.Hide();
                            new AdministradorUsuarios().Show();
                        }
                        else if (usuario.admin_productos)
                        {
                            this.Hide();
                            new AdministracionProductos().Show();
                        }
                        else
                        {
                            this.Hide();
                            new Catalogo().Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }

                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }

        private void buttonInvitadoSesion_Click(object sender, EventArgs e)
        {
            Sesion.UsuarioActual = null;
            this.Hide();
            new Catalogo().Show();
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registrarse().Show();
        }

    }
}
