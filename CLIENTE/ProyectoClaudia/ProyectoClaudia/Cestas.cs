using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProyectoClaudia.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoClaudia
{
    public partial class Cestas : Form
    {
        private List<Productos> productosEnCesta = new List<Productos>();
        private List<Descuentos> descuentos = new List<Descuentos>();

        public Cestas()
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


        private void MostrarProductosEnCesta(List<Cesta> cesta)
        {
            double totalCesta = CalcularTotalCestaCompleta();

            flowLayoutPanelCesta.Controls.Clear();

            foreach (var item in cesta)
            {
                var id = item.productos.id;

                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:8082/productos/obtenerProductosId?id={id}";

                    HttpResponseMessage response = client.GetAsync(url).Result;
                    Productos producto = new Productos();

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        producto = JsonConvert.DeserializeObject<Productos>(json);
                    }
                    else
                    {
                        continue;
                    }

                    Panel panelProducto = new Panel
                    {
                        Width = 200,
                        Height = 280,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(2)
                    };

                    Label lblNombre = new Label
                    {
                        Text = producto.nombre,
                        Font = new Font("Comic Sans MS", 10, FontStyle.Bold),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 30
                    };

                    PictureBox picture = new PictureBox
                    {
                        Height = 120,
                        Width = 120,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = convertirImagen(producto.imagen),
                        Location = new Point(40, 35)
                    };

                    Label lblCantidad = new Label
                    {
                        Text = $"Cantidad: {item.cantidad}",
                        Font = new Font("Comic Sans MS", 8),
                        AutoSize = false,
                        Width = 180,
                        Top = picture.Bottom + 5,
                        Left = 10
                    };

                    Label lblPrecio = new Label
                    {
                        AutoSize = false,
                        Width = 180,
                        Left = 10
                    };

                    Label lblPrecioOferta = new Label
                    {
                        AutoSize = false,
                        Width = 180,
                        Left = 10,
                        ForeColor = Color.DarkGreen
                    };

                    if (producto.oferta)
                    {
                        lblPrecio.Text = $"{producto.precio}€";
                        lblPrecio.Font = new Font("Comic Sans MS", 8, FontStyle.Strikeout);
                        lblPrecio.Top = lblCantidad.Bottom + 5;

                        lblPrecioOferta.Text = $"{producto.precio_oferta}€";
                        lblPrecioOferta.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
                        lblPrecioOferta.Top = lblPrecio.Bottom + 2;

                        panelProducto.Controls.Add(lblPrecio);
                        panelProducto.Controls.Add(lblPrecioOferta);
                    }
                    else
                    {
                        lblPrecio.Text = $"{producto.precio}€";
                        lblPrecio.Font = new Font("Comic Sans MS", 8);
                        lblPrecio.Top = lblCantidad.Bottom + 5;

                        panelProducto.Controls.Add(lblPrecio);
                    }

                    System.Windows.Forms.Button btnMas = new System.Windows.Forms.Button
                    {
                        Text = "+",
                        Width = 30,
                        Height = 25,
                        Top = lblPrecio.Bottom + 25,
                        Left = 10
                    };
                    btnMas.Click += async (s, e) =>
                    {
                        string url2 = $"http://localhost:8082/cesta/aumentar?idUsuario={Sesion.UsuarioActual.id}&idProducto={producto.id}";

                        using (HttpClient client2 = new HttpClient())
                        {
                            var response2 = await client2.PostAsync(url2, null);
                            if (response2.IsSuccessStatusCode)
                            {
                                List<Cesta> cestaActualizada = obtenerCesta(Sesion.UsuarioActual.id);
                                MostrarProductosEnCesta(cestaActualizada);
                                CalcularTotales();
                            }
                            else
                            {
                                string error = await response2.Content.ReadAsStringAsync();
                                MessageBox.Show("Error al aumentar cantidad: " + error);
                            }
                        }
                    };

                    System.Windows.Forms.Button btnMenos = new System.Windows.Forms.Button
                    {
                        Text = "-",
                        Width = 30,
                        Height = 25,
                        Top = lblPrecio.Bottom + 25,
                        Left = 50
                    };
                    btnMenos.Click += async (s, e) =>
                    {
                        string url2 = $"http://localhost:8082/cesta/disminuir?idUsuario={Sesion.UsuarioActual.id}&idProducto={producto.id}";

                        using (HttpClient client2 = new HttpClient())
                        {
                            var response2 = await client2.PostAsync(url2, null);
                            if (response2.IsSuccessStatusCode)
                            {
                                List<Cesta> cestaActualizada = obtenerCesta(Sesion.UsuarioActual.id);
                                MostrarProductosEnCesta(cestaActualizada);
                                CalcularTotales();
                            }
                            else
                            {
                                string error = await response2.Content.ReadAsStringAsync();
                                MessageBox.Show("Error al disminuir cantidad: " + error);
                            }
                        }
                    };

                    System.Windows.Forms.Button btnEliminar = new System.Windows.Forms.Button
                    {
                        Text = "borrar",
                        Width = 50,
                        Height = 25,
                        Top = lblPrecio.Bottom + 25,
                        Left = 90
                    };
                    btnEliminar.Click += async (s, e) =>
                    {
                        string url2 = $"http://localhost:8082/cesta/eliminar?idUsuario={Sesion.UsuarioActual.id}&idProducto={producto.id}";

                        using (HttpClient client2 = new HttpClient())
                        {
                            var response2 = await client2.DeleteAsync(url2);
                            if (response2.IsSuccessStatusCode)
                            {
                                BuscarEnCesta(); // Refresca la vista actual
                            }
                            else
                            {
                                string error = await response2.Content.ReadAsStringAsync();
                                MessageBox.Show("Error al eliminar producto de la cesta: " + error);
                            }
                        }
                    };

                    panelProducto.Controls.Add(lblNombre);
                    panelProducto.Controls.Add(picture);
                    panelProducto.Controls.Add(lblCantidad);
                    panelProducto.Controls.Add(lblPrecio);
                    panelProducto.Controls.Add(btnMas);
                    panelProducto.Controls.Add(btnMenos);
                    panelProducto.Controls.Add(btnEliminar);

                    flowLayoutPanelCesta.Controls.Add(panelProducto);

                }
            }

        }
        private double CalcularTotalCestaCompleta()
        {
            double total = 0;
            var cestaCompleta = obtenerCesta(Sesion.UsuarioActual.id);

            foreach (var item in cestaCompleta)
            {
                Productos producto = null;

                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:8082/productos/obtenerProductosId?id={item.productos.id}";
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        producto = JsonConvert.DeserializeObject<Productos>(json);
                    }
                }

                if (producto != null)
                {
                    double precioUnitario = producto.oferta ? producto.precio_oferta : producto.precio;
                    total += precioUnitario * item.cantidad;
                }
            }

            return total;
        }

        public void AgregarProducto()
        {

            List<Cesta> cesta = obtenerCesta(Sesion.UsuarioActual.id);

            MostrarProductosEnCesta(cesta);

        }

        public List<Cesta> obtenerCesta(int idUsuario)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/cesta/obtenerCesta?idUsuario={idUsuario}";

                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Cesta>>(json);
                }
                else
                {
                    MessageBox.Show("Error al obtener la cesta.");
                    return new List<Cesta>();
                }
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

        private void CargarDescuentos()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:8082/descuentos").Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    descuentos = JsonConvert.DeserializeObject<List<Descuentos>>(json);
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar los descuentos.");
                }
            }
        }

        private void CalcularTotales()
        {
            double total = 0;
            var cesta = obtenerCesta(Sesion.UsuarioActual.id);

            foreach (var item in cesta)
            {
                Productos producto = null;

                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:8082/productos/obtenerProductosId?id={item.productos.id}";
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        producto = JsonConvert.DeserializeObject<Productos>(json);
                    }
                }

                if (producto != null)
                {
                    double precioUnitario = producto.oferta ? producto.precio_oferta : producto.precio;
                    total += precioUnitario * item.cantidad;
                }
            }

            textTotalCompra.Text = $"{total:F2} €";  
            AplicarDescuentoSiCorresponde(total);
        }

        private void AplicarDescuentoSiCorresponde(double total)
        {
            if (descuentos == null || descuentos.Count == 0)
            {
                textDescuento.Text = "0.00";
                textTotal.Text = total.ToString("0.00");
                return;
            }

            var mejorDescuento = descuentos
                .Where(d => total >= d.precio)
                .OrderByDescending(d => d.porcentaje)
                .FirstOrDefault();

            if (mejorDescuento != null)
            {
                double descuentoAplicado = total * (mejorDescuento.porcentaje / 100.0);
                double totalFinal = total - descuentoAplicado;

                textDescuento.Text = descuentoAplicado.ToString("0.00")+"€";
                textTotal.Text = totalFinal.ToString("0.00") + "€";
            }
            else
            {
                textDescuento.Text = "0.00" + "€";
                textTotal.Text = total.ToString("0.00") + "€";
            }
        }

        private void Cesta_Load(object sender, EventArgs e)
        {
            AgregarProducto();
            CargarDescuentos();
            CalcularTotales();

            textTotalCompra.ReadOnly = true;
            textDescuento.ReadOnly = true;
            textTotal.ReadOnly = true;
        }

        private void buttonBuscador_Click(object sender, EventArgs e)
        {
            BuscarEnCesta();
        }

        private void BuscarEnCesta()
        {
            string texto = textBuscador.Text.Trim();
            int idUsuario = Sesion.UsuarioActual.id;

            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/cesta/buscarProducto?idUsuario={idUsuario}&texto={texto}";

                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    List<Cesta> cestaFiltrada = JsonConvert.DeserializeObject<List<Cesta>>(json);

                    MostrarProductosEnCesta(cestaFiltrada);
                }
                else
                {
                    MessageBox.Show("Error al buscar en la cesta.");
                }
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
                this.Hide();
            new Compra().Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBuscador.Clear();
        }

    }
}
