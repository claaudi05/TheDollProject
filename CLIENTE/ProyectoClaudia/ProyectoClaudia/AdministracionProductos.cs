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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoClaudia
{
    public partial class AdministracionProductos : Form
    {
        public AdministracionProductos()
        {
            InitializeComponent();
        }

        private List<Productos> productosCargados;

        private void AdministracionProductos_Load(object sender, EventArgs e)
        {
            listBoxProductos.HorizontalScrollbar = true;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("http://localhost:8082/productos/obtenerProductos").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        //MOSTRAR LOS PRODUCTOS EN EL LISTBOX
                        var json = response.Content.ReadAsStringAsync().Result;
                        productosCargados = JsonConvert.DeserializeObject<List<Productos>>(json);

                        listBoxProductos.Items.Clear();
                        foreach (var prod in productosCargados)
                        {
                            listBoxProductos.Items.Add(
                                $"Nombre: {prod.nombre}, Descripción: {prod.descripcion}, Precio: {prod.precio}€, Stock: {prod.stock}, Marca: {prod.marca}, Oferta: {(prod.oferta ? "Sí" : "No")}, Precio Oferta: {prod.precio_oferta}€");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error al cargar productos: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }


        }


        private string rutaImagen = "";
        private void buttonSeleccionarImagenProducto_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = dialog.FileName;
                pictureBoxProducto.Image = Image.FromFile(rutaImagen);
                //PARA HACER QUE LA IMAGEN SE VEA COMPLETA
                pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;


            }
        }
        private void buttonGuardarProductos_Click(object sender, EventArgs e)
        {
            // Validación básica de campos obligatorios
            if (string.IsNullOrWhiteSpace(textNombreProducto.Text) || string.IsNullOrWhiteSpace(textDescripcionProducto.Text) || string.IsNullOrWhiteSpace(textPrecioProducto.Text) || string.IsNullOrWhiteSpace(textStockProducto.Text) || pictureBoxProducto.Image == null || comboBoxMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Rellena los campos obligatorios");
                return;
            }

            // Validar que stock y precio son números válidos
            if (!decimal.TryParse(textPrecioProducto.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("El campo precio debe ser un número válido.");
                return;
            }

            if (!int.TryParse(textStockProducto.Text.Trim(), out int stock))
            {
                MessageBox.Show("El campo stock debe ser un número entero válido.");
                return;
            }

            // Si el checkbox está marcado, el precio de oferta es obligatorio
            if (checkBoxOfertaProducto.Checked)
            {
                if (string.IsNullOrWhiteSpace(textPrecioOfertaProducto.Text))
                {
                    MessageBox.Show("Debes ingresar un precio de oferta si marcas la opción de oferta.");
                    return;
                }

                if (!decimal.TryParse(textPrecioOfertaProducto.Text.Trim(), out decimal precioOferta))
                {
                    MessageBox.Show("El campo Precio Oferta debe ser un número válido.");
                    return;
                }
            }
            else
            {
                // Si el campo precio oferta está rellenado (aunque el checkbox esté desmarcado)
                if (!string.IsNullOrWhiteSpace(textPrecioOfertaProducto.Text))
                {
                    if (!decimal.TryParse(textPrecioOfertaProducto.Text.Trim(), out decimal _))
                    {
                        MessageBox.Show("El campo Precio Oferta debe ser un número válido.");
                        return;
                    }

                    // Si hay un número válido, pero no está marcado el checkbox, lo marcamos automáticamente
                    checkBoxOfertaProducto.Checked = true;
                }
            }

            bool esModificacion = listBoxProductos.SelectedIndex >= 0 && listBoxProductos.SelectedIndex < productosCargados.Count;

            string imagenBase64;
            if (!string.IsNullOrEmpty(rutaImagen))
            {
                imagenBase64 = Convert.ToBase64String(File.ReadAllBytes(rutaImagen));
            }
            else if (esModificacion)
            {
                imagenBase64 = productosCargados[listBoxProductos.SelectedIndex].imagen;
            }
            else
            {
                MessageBox.Show("Selecciona una imagen para el nuevo producto.");
                return;
            }

            var producto = new
            {
                id = esModificacion ? productosCargados[listBoxProductos.SelectedIndex].id : 0,
                nombre = textNombreProducto.Text.Trim(),
                descripcion = textDescripcionProducto.Text.Trim(),
                precio = decimal.Parse(textPrecioProducto.Text.Trim()),
                stock = int.Parse(textStockProducto.Text.Trim()),
                marca = comboBoxMarca.SelectedItem.ToString(),
                oferta = checkBoxOfertaProducto.Checked ? 1 : 0,
                precio_oferta = checkBoxOfertaProducto.Checked ? decimal.Parse(textPrecioOfertaProducto.Text) : 0,
                imagen = imagenBase64
            };

            string json = JsonConvert.SerializeObject(producto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;
                if (esModificacion)
                {
                    response = client.PutAsync("http://localhost:8082/productos/modificarProducto", content).Result;
                }
                else
                {
                    response = client.PostAsync("http://localhost:8082/productos/guardarProductos", content).Result;
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(esModificacion ? "Producto modificado correctamente." : "Producto guardado correctamente.");
                    CargarProductos();
                    listBoxProductos.ClearSelected(); // deseleccionar para futuras inserciones
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
        }



        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxProductos.SelectedIndex;
            if (index >= 0 && index < productosCargados.Count)
            {
                var prod = productosCargados[index];

                textNombreProducto.Text = prod.nombre;
                textDescripcionProducto.Text = prod.descripcion;
                textPrecioProducto.Text = prod.precio.ToString();
                textStockProducto.Text = prod.stock.ToString();
                comboBoxMarca.SelectedItem = prod.marca;
                checkBoxOfertaProducto.Checked = prod.oferta;
                textPrecioOfertaProducto.Text = prod.precio_oferta.ToString();

                // Mostrar imagen si tienes PictureBox
                if (!string.IsNullOrEmpty(prod.imagen))
                {
                    byte[] imageBytes = Convert.FromBase64String(prod.imagen);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxProducto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxProducto.Image = null;
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            int index = listBoxProductos.SelectedIndex;
            if (index >= 0 && index < productosCargados.Count)
            {
                var productoAEliminar = productosCargados[index];

                DialogResult confirm = MessageBox.Show(
                    $"¿Estás seguro de que quieres eliminar el producto '{productoAEliminar.nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (HttpClient client = new HttpClient())
                    {; 
                        var json = JsonConvert.SerializeObject(productoAEliminar);
                        var content = new StringContent(JsonConvert.SerializeObject(productoAEliminar.id), Encoding.UTF8, "application/json");

                        var response = client.PostAsync("http://localhost:8082/productos/eliminarProductos", content).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                            CargarProductos();

                            //LIMPIAR LOS COMPONENTES
                            textNombreProducto.Clear();
                            textDescripcionProducto.Clear();
                            textPrecioProducto.Clear();
                            textStockProducto.Clear();
                            comboBoxMarca.SelectedIndex = -1;
                            checkBoxOfertaProducto.Checked = false;
                            textPrecioOfertaProducto.Clear();
                            pictureBoxProducto.Image = null;
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar: {response.StatusCode}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }

        }

        private void CargarProductos()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("http://localhost:8082/productos/obtenerProductos").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;
                        productosCargados = JsonConvert.DeserializeObject<List<Productos>>(json);

                        listBoxProductos.Items.Clear();
                        foreach (var p in productosCargados)
                        {
                            listBoxProductos.Items.Add(
                                $"Nombre: {p.nombre}, Descripción: {p.descripcion}, Precio: {p.precio}€, Stock: {p.stock}, Marca: {p.marca}, Oferta: {(p.oferta ? "Sí" : "No")}, Precio Oferta: {p.precio_oferta}€"
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar productos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void buttonCancelarProductos_Click(object sender, EventArgs e)
        {

            textNombreProducto.Clear();
            textDescripcionProducto.Clear();
            textPrecioProducto.Clear();
            textStockProducto.Clear();
            comboBoxMarca.SelectedIndex = -1;
            checkBoxOfertaProducto.Checked = false;
            textPrecioOfertaProducto.Clear();
            pictureBoxProducto.Image = null;
            listBoxProductos.ClearSelected();
        }

        private void buttonDescuentosProductos_Click(object sender, EventArgs e)
        {
            Descuento ventanaDescuento = new Descuento();
            ventanaDescuento.Show();
            this.Hide();
        }

        private void buttonBuscadorProductos_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBuscadorProductos.Text.Trim();

            //SI NO HAY TEXTO QUE CARGUE TODOS
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProductos(); 
                return;
            }
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/productos/buscarProductos?texto={Uri.EscapeDataString(textoBusqueda)}";
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
            listBoxProductos.Items.Clear();

            foreach (var p in productos)
            {
                listBoxProductos.Items.Add(
                                $"Nombre: {p.nombre}, Descripción: {p.descripcion}, Precio: {p.precio}€, Stock: {p.stock}, Marca: {p.marca}, Oferta: {(p.oferta ? "Sí" : "No")}, Precio Oferta: {p.precio_oferta}€"
                );
            }
        }

        private void buttonCerrarSesionProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void buttonCatalogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Catalogo().Show();  
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null && Sesion.UsuarioActual.admin_usuarios)
            {
                this.Hide();
                new AdministradorUsuarios().Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a la gestión de usuarios.");
            }
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pedidos().Show();   
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBuscadorProductos.Clear();
        }

    }
}
