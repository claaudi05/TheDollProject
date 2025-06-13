using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Catalogo().Show();
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pedidos().Show();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                textNombre.Text = Sesion.UsuarioActual.nombre;
                textEmail.Text = Sesion.UsuarioActual.email;

                // Hacer que no se puedan editar
                textNombre.ReadOnly = true;
                textEmail.ReadOnly = true;

                CargarImagenUsuario();
            }

        }
        private Image convertirImagen(string imagen)
        {
            byte[] imageBytes = Convert.FromBase64String(imagen);
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void buttonCambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(rutaImagen);

                byte[] imagenBytes = File.ReadAllBytes(rutaImagen);

                using (HttpClient client = new HttpClient())
                {
                    var content = new ByteArrayContent(imagenBytes);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    var response = client.PutAsync($"http://localhost:8082/usuarios/imagen/{Sesion.UsuarioActual.id}", content).Result;

                    if (response.IsSuccessStatusCode)
                        MessageBox.Show("Imagen actualizada con éxito");
                    else
                        MessageBox.Show("Error al actualizar imagen");
                }
            }
        }

        private void CargarImagenUsuario()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync($"http://localhost:8082/usuarios/imagen/{Sesion.UsuarioActual.id}").Result;

                if (response.IsSuccessStatusCode)
                {
                    string base64String = response.Content.ReadAsStringAsync().Result;
                    byte[] imagenBytes = Convert.FromBase64String(base64String);

                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la imagen.");
                }
            }
        }

        private void linkLabelContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CambiarContraseña().Show();
        }
    }
}
