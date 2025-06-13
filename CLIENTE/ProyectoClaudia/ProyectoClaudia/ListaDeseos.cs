using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public partial class ListaDeseos : Form
    {
        public ListaDeseos()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Catalogo().Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private async void CargarListaDeseos()
        {
            long idUsuario = Sesion.UsuarioActual.id;

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:8082/listaDeseos/usuario/{idUsuario}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var lista = JsonConvert.DeserializeObject<List<ListaDeseo>>(json);

                    MostrarListaEnPanel(lista);
                }
                else
                {
                    MessageBox.Show("Error al cargar la lista de deseos.");
                }
            }
        }

        private void MostrarListaEnPanel(List<ListaDeseo> lista)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in lista)
            {
                var producto = item.productos;
                Console.WriteLine(item.productos);

                Panel panel = new Panel
                {
                    Width = 200,
                    Height = 260,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(2)
                };

                Label lblNombre = new Label
                {
                    Text = producto.nombre,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Comic Sans MS", 9, FontStyle.Bold),
                    Height = 30
                };

                PictureBox picture = new PictureBox
                {
                    Height = 120,
                    Width = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = convertirImagen(producto.imagen),
                    Location = new Point(40, 20),
                    Top = lblNombre.Bottom + 5
                };

                // Precio original
                Label lblPrecio = new Label
                {
                    Width = 60,
                    Height = 15,
                    Left = 10,
                    Font = new Font("Comic Sans MS", 8)
                };

                // Precio con oferta si aplica
                Label lblPrecioOferta = new Label
                {
                    Width = 60,
                    Height = 15,
                    Left = 10,
                    ForeColor = Color.Black
                };

                if (producto.oferta)
                {
                    lblPrecio.Text = $"{producto.precio}€";
                    lblPrecio.Font = new Font("Comic Sans MS", 8, FontStyle.Strikeout);
                    lblPrecio.AutoSize = true;
                    lblPrecio.Top = picture.Bottom + 10;
                    lblPrecio.Left = (panel.Width - lblPrecio.PreferredWidth) / 2;

                    lblPrecioOferta.Text = $"{producto.precio_oferta}€";
                    lblPrecioOferta.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
                    lblPrecioOferta.AutoSize = true;
                    lblPrecioOferta.Top = lblPrecio.Bottom + 2;
                    lblPrecioOferta.Left = (panel.Width - lblPrecioOferta.PreferredWidth) / 2;

                    panel.Controls.Add(lblPrecio);
                    panel.Controls.Add(lblPrecioOferta);
                }
                else
                {
                    lblPrecio.Text = $"{producto.precio}€";
                    lblPrecio.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
                    lblPrecio.AutoSize = true;
                    lblPrecio.Top = picture.Bottom + 10;
                    lblPrecio.Left = (panel.Width - lblPrecio.PreferredWidth) / 2;

                    panel.Controls.Add(lblPrecio);
                }

                Button btnEliminar = new Button
                {
                    Text = "",
                    Width = 70,
                    Height = 35,
                    Location = new Point(10, panel.Height - 50)
                   
                };

                btnEliminar.BackgroundImage = Properties.Resources.papelera;
                btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;

                Button btnCesta = new Button
                {
                    Text = "",
                    Width = 70,
                    Height = 35,
                    Location = new Point(100, panel.Height - 50)
                };

                btnCesta.BackgroundImage = Properties.Resources.carrito; 
                btnCesta.BackgroundImageLayout = ImageLayout.Zoom;

                btnEliminar.Click += async (s, e) =>
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"http://localhost:8082/listaDeseos/eliminar?idUsuario={Sesion.UsuarioActual.id}&idProducto={producto.id}";
                        var res = await client.DeleteAsync(url);
                        if (res.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Producto eliminado de la lista de deseos.");
                            CargarListaDeseos(); // Recarga
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto.");
                        }
                    }
                };
                btnCesta.Click += async (s, e) =>
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"http://localhost:8082/cesta/agregar?idUsuario={Sesion.UsuarioActual.id}&idProducto={producto.id}";

                        try
                        {
                            var response = await client.PostAsync(url, null);
                            string respuesta = await response.Content.ReadAsStringAsync();

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Producto añadido a la cesta correctamente.");
                            }
                            else
                            {
                                MessageBox.Show($"No se pudo añadir el producto: {respuesta}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al conectar con el servidor: " + ex.Message);
                        }
                    }
                };


                panel.Controls.Add(lblNombre);
                panel.Controls.Add(picture);
                panel.Controls.Add(lblPrecio);
                panel.Controls.Add(btnEliminar);
                panel.Controls.Add(btnCesta);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private Image convertirImagen(string imagenBase64)
        {
            if (string.IsNullOrEmpty(imagenBase64))
                return null;

            byte[] imagenBytes = Convert.FromBase64String(imagenBase64);

            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void ListaDeseos_Load(object sender, EventArgs e)
        {
            CargarListaDeseos();
        }
    }
}
