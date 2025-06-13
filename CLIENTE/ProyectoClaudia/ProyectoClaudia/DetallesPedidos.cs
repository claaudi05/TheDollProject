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
using ProyectoClaudia.Clases;

namespace ProyectoClaudia
{
    public partial class DetallesPedidos : Form
    {
        private int pedidoId;

        public DetallesPedidos()
        {
            InitializeComponent();
        }
        public DetallesPedidos(int pedidoId)
        {
            InitializeComponent();
            this.pedidoId = pedidoId;
        }
        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void buttoVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pedidos().Show();
        }


        private void DetallesPedidos_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/detallesPedidos/pedido/{pedidoId}";
                HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    List<DetallesPedido> detalles = JsonConvert.DeserializeObject<List<DetallesPedido>>(json);
                    flowLayoutPanel1.Controls.Clear();
                    foreach (var detalle in detalles)
                    {
                        Panel panel = CrearPanelProducto(detalle);
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar los detalles del pedido.");
                }
            }
        }

        private Panel CrearPanelProducto(DetallesPedido detalle)
        {
            Productos producto = detalle.productos;

            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(120, 100),
                Location = new Point(10, 15),
                Image = convertirImagen(producto.imagen)
            };

            Label titulo = new Label
            {
                Text = producto.nombre,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(140, 10),
                AutoSize = true
            };

            Label descripcion = new Label
            {
                Text = producto.descripcion,
                Location = new Point(140, 30),
                Size = new Size(300, 40)
            };

            Label cantidad = new Label
            {
                Text = $"Cantidad: {detalle.cantidad}",
                Location = new Point(140, 70),
                AutoSize = true
            };

            Label precio;
            if (producto.oferta)
            {
                precio = new Label
                {
                    Text = $"{producto.precio}€",
                    Font = new Font("Arial", 9, FontStyle.Strikeout),
                    Location = new Point(140, 90),
                    ForeColor = Color.Gray,
                    AutoSize = true
                };

                Label precioOferta = new Label
                {
                    Text = $"{producto.precio_oferta}€",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(200, 90),
                    ForeColor = Color.Green,
                    AutoSize = true
                };

                Panel panel = new Panel
                {
                    Size = new Size(470, 130),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                panel.Controls.Add(titulo);
                panel.Controls.Add(descripcion);
                panel.Controls.Add(cantidad);
                panel.Controls.Add(precio);
                panel.Controls.Add(precioOferta);
                panel.Controls.Add(pictureBox);
                return panel;
            }
            else
            {
                precio = new Label
                {
                    Text = $"{producto.precio}€",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(140, 90),
                    AutoSize = true
                };

                Panel panel = new Panel
                {
                    Size = new Size(470, 130),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                panel.Controls.Add(titulo);
                panel.Controls.Add(descripcion);
                panel.Controls.Add(cantidad);
                panel.Controls.Add(precio);
                panel.Controls.Add(pictureBox);
                return panel;
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

    }
}
