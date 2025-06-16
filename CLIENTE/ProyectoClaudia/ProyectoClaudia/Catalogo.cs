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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoClaudia
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();

        }

        private List<Productos> productosCargados;

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            CargarImagenes();
            CargarTodosLosProductos();

        }

        private void CargarImagenes()
        {
            string[] marcas = new string[]
{
                "Monster high",
                "Rainbow high",
                "Barbie",
                "Disney",
                "Funko",
                "Nancy",
                "Nenuco",
                "Sanrio"
            };

            Image[] imagenes = new Image[]
            {
                Properties.Resources.monsterHigh,
                Properties.Resources.rainbow_high,
                Properties.Resources.barbie,
                Properties.Resources.disney,
                Properties.Resources.funko,
                Properties.Resources.nancy,
                Properties.Resources.nenuco,
                Properties.Resources.sanrio
            };

            flowLayoutPanelMarca.Controls.Clear();

            for(int i = 0; i < imagenes.Length; i++)
            {
                int j = i;

                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Width = 75;
                btn.Height = 75;
                btn.BackgroundImage = imagenes[i];
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;

                btn.Margin = new Padding(30);

                btn.Click += (s, e) =>
                {
                    CargarProductosPorMarca(marcas[j]);
                };

                flowLayoutPanelMarca.Controls.Add(btn);

            }
        }

        private void CargarTodosLosProductos()
        {
            string url = "http://localhost:8082/productos/obtenerProductos"; 
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    productosCargados = JsonConvert.DeserializeObject<List<Productos>>(json);
                    cargarProductosBuscados(productosCargados);
                }
                else
                {
                    MessageBox.Show("Error al cargar productos: " + response.StatusCode);
                }
            }
        }

        private void CargarProductosPorMarca(string marca)
        {
            string url = $"http://localhost:8082/productos/buscarMarca?marca={Uri.EscapeDataString(marca)}";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    productosCargados = JsonConvert.DeserializeObject<List<Productos>>(json);
                    cargarProductosBuscados(productosCargados);
                }
                else
                {
                    MessageBox.Show("Error al buscar productos: " + response.StatusCode);
                }
            }
        }

        private void cargarProductosBuscados(List<Productos> productos)
        {
            flowLayoutPanelProductos.Controls.Clear();

            flowLayoutPanelProductos.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelProductos.WrapContents = true;
            flowLayoutPanelProductos.AutoScroll = true;

            foreach (var producto in productos)
            {
                Panel panelProducto = new Panel
                {
                    Width = 200,
                    Height = 260,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(2)
                };

                // Nombre del producto
                Label lblNombre = new Label
                {
                    Text = producto.nombre,
                    Font = new Font("Comic Sans MS", 9, FontStyle.Bold),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30
                };

                // Imagen
                PictureBox picture = new PictureBox
                {
                    Height = 120,
                    Width = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = convertirImagen(producto.imagen),
                    Location = new Point(40, 35)
                };

                // Descripción
                Label lblDescripcion = new Label
                {
                    Text = producto.descripcion,
                    Font = new Font("Comic Sans MS", 7),
                    AutoSize = false,
                    Width = 180,
                    Top = picture.Bottom + 10,
                    Left = 10
                };
                // Marca
                Label lblMarca = new Label
                {
                    Text = producto.marca,
                    Font = new Font("Comic Sans MS", 7),
                    AutoSize = false,
                    Width = 180,
                    Top = lblDescripcion.Bottom + 5,
                    Left = 10
                };

                // Precio
                Label lblPrecio = new Label
                {
                    Width = 50,
                    Height = 15,
                    Left = 10,
                    Top = panelProducto.Height - 40,
                    Font = new Font("Comic Sans MS", 7)
                };

                // Precio con oferta si aplica
                Label lblPrecioOferta = new Label
                {
                    Width = 50,
                    Height = 15,
                    Left = 10,
                    Top = panelProducto.Height - 20,
                    Font = new Font("Comic Sans MS", 7, FontStyle.Bold),
                    ForeColor = Color.Black
                };

                if (producto.oferta)
                {
                    lblPrecio.Text = $"{producto.precio}€";
                    lblPrecio.Font = new Font("Comic Sans MS", 7, FontStyle.Strikeout);

                    lblPrecioOferta.Text = $"{producto.precio_oferta}€";
                    panelProducto.Controls.Add(lblPrecio);
                    panelProducto.Controls.Add(lblPrecioOferta);
                }
                else
                {
                    lblPrecio.Text = $"{producto.precio}€";
                    lblPrecio.Top = panelProducto.Height - 30;
                    lblPrecio.Font = new Font("Comic Sans MS", 7, FontStyle.Bold);
                    panelProducto.Controls.Add(lblPrecio);
                }

                // Botón carrito
                System.Windows.Forms.Button btnCesta = new System.Windows.Forms.Button
                {
                    Size = new Size(24, 24),
                    BackgroundImage = Properties.Resources.carrito1,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(3)
                };
                btnCesta.Location = new Point(panelProducto.Width - 60, lblPrecio.Top - 2);

                // Botón deseo
                System.Windows.Forms.Button btnDeseo = new System.Windows.Forms.Button
                {
                    Size = new Size(24, 24),
                    BackgroundImage = Properties.Resources.listaDeseos,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat
                };
                btnDeseo.Location = new Point(panelProducto.Width - 30, lblPrecio.Top - 2);

                btnCesta.Click += async (s, e) =>
                {
                    if (Sesion.EsInvitado)
                    {
                        MessageBox.Show("Debes iniciar sesión para añadir productos a la cesta.");
                        return;
                    }

                    string url = $"http://localhost:8082/cesta/agregar?idUsuario={Sesion.UsuarioActual.id}&idProducto={producto.id}";

                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.PostAsync(url, null);

                        if (response.IsSuccessStatusCode)
                        {
                            string mensaje = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Producto añadido a la cesta.");
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Error al añadir a la cesta: " + error);
                        }
                    }
                };

                btnDeseo.Click += async (s, e) =>
                {
                    if (Sesion.EsInvitado)
                    {
                        MessageBox.Show("Debes iniciar sesión para usar la lista de deseos.");
                        return;
                    }

                    long idUsuario = Sesion.UsuarioActual.id;
                    long idProducto = producto.id;

                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"http://localhost:8082/listaDeseos/agregar?idUsuario={idUsuario}&idProducto={idProducto}";
                        HttpResponseMessage response = await client.PostAsync(url, null);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Producto agregado a la lista de deseos.");
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Error al agregar a la lista de deseos: " + error);
                        }
                    }
                };

                // Añadir controles al panel
                panelProducto.Controls.Add(lblNombre);
                panelProducto.Controls.Add(picture);
                panelProducto.Controls.Add(lblDescripcion);
                panelProducto.Controls.Add(lblMarca);
                panelProducto.Controls.Add(lblPrecio);
                panelProducto.Controls.Add(btnCesta);
                panelProducto.Controls.Add(btnDeseo);

                // Añadir al flow panel
                flowLayoutPanelProductos.Controls.Add(panelProducto);
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

        private void buttonBuscador_Click(object sender, EventArgs e)
        {
            string texto = textBuscador.Text.Trim();
            if (!string.IsNullOrEmpty(texto))
            {
                BuscarProductos(texto);
            }
            else
            {
                CargarTodosLosProductos();
            }

        }

        private void BuscarProductos(string texto)
        {
            string url = $"http://localhost:8082/productos/buscar?texto={Uri.EscapeDataString(texto)}";

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    productosCargados = JsonConvert.DeserializeObject<List<Productos>>(json);
                    cargarProductosBuscados(productosCargados);
                }
                else
                {
                    MessageBox.Show("Error al buscar productos: " + response.StatusCode);
                }
            }
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            if (Sesion.EsInvitado)
            {
                this.Hide();
                new InicioSesion().Show();
            }
            else
            {
                this.Hide();
                new Perfil().Show();
            }
        }

        private void buttonCesta_Click(object sender, EventArgs e)
        {
            if (Sesion.EsInvitado)
            {
                this.Hide();
                new InicioSesion().Show();
            }
            else
            {
                this.Hide();
                new Cestas().Show();
            }
        }

        private void buttonDeseo_Click(object sender, EventArgs e)
        {

            if (Sesion.EsInvitado)
            {
                this.Hide();
                new InicioSesion().Show();
            }
            else
            {
                this.Hide();
                new ListaDeseos().Show();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBuscador.Clear();
        }

    }
}
