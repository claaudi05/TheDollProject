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
    public partial class AdministradorUsuarios : Form
    {
        public AdministradorUsuarios()
        {
            InitializeComponent();
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

        private List<Usuarios> usuariosCargados;
        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            
            int index = listBoxUsuarios.SelectedIndex;
            bool esModificacion = index >= 0 && index < usuariosCargados.Count;

            if (string.IsNullOrWhiteSpace(textEmail.Text) || string.IsNullOrWhiteSpace(textNombre.Text))
            {
                if (!esModificacion) {
                    if (string.IsNullOrWhiteSpace(textContraseña.Text))
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                        return;
                    }
                }
                MessageBox.Show("Los campos correo y nombre son obligatorios");
                return;
            }

            var usuarioSeleccionado = esModificacion ? usuariosCargados[index] : null;

            if (!ValidarContraseña(textContraseña.Text.Trim()))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas y un carácter especial.");
                return;
            }

            // Cifrar la contraseña solo si se proporciona
            var rsa = new RsaEncryptor();
            string contraseñaCifrada = string.IsNullOrWhiteSpace(textContraseña.Text.Trim()) ? null : rsa.Encrypt(textContraseña.Text.Trim());

            var usuario = new
            {
                id = esModificacion ? usuarioSeleccionado.id : 0,
                email = textEmail.Text.Trim(),
                nombre = textNombre.Text.Trim(),
                contraseña = contraseñaCifrada,
                admin_productos = checkBoxProductos.Checked,
                admin_usuarios = checkBoxUsuarios.Checked
            };

            string json = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;

                if (esModificacion)
                {
                    response = client.PutAsync("http://localhost:8082/usuarios/modificarUsuario", content).Result;
                }
                else
                {
                    response = client.PostAsync("http://localhost:8082/usuarios/crearUsuario", content).Result;
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(esModificacion ? "Usuario modificado correctamente." : "Usuario creado correctamente.");
                    CargarUsuarios(); 
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + response.StatusCode);
                }
            }

        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textEmail.Clear();
            textContraseña.Clear();
            checkBoxUsuarios.Checked = false;
            checkBoxProductos.Checked = false;
            listBoxUsuarios.ClearSelected();

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void CargarUsuarios()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("http://localhost:8082/usuarios/obtenerUsuarios").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;
                        usuariosCargados = JsonConvert.DeserializeObject<List<Usuarios>>(json);

                        listBoxUsuarios.Items.Clear();
                        foreach (var u in usuariosCargados)
                        {
                            listBoxUsuarios.Items.Add(
                                $"Nombre: {u.nombre}, Email: {u.email}, admin_usuarios: {(u.admin_usuarios ? "Sí" : "No")}, admin_productos: {(u.admin_productos ? "Sí" : "No")}"
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

        private void AdministradorUsuarios_Load(object sender, EventArgs e)
        {
            listBoxUsuarios.HorizontalScrollbar = true;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("http://localhost:8082/usuarios/obtenerUsuarios").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        //MOSTRAR LOS PRODUCTOS EN EL LISTBOX
                        var json = response.Content.ReadAsStringAsync().Result;
                        usuariosCargados = JsonConvert.DeserializeObject<List<Usuarios>>(json);

                        listBoxUsuarios.Items.Clear();
                        foreach (var u in usuariosCargados)
                        {
                            listBoxUsuarios.Items.Add(
                                $"Nombre: {u.nombre}, Email: {u.email}, admin_usuarios: {(u.admin_usuarios ? "Sí" : "No")}, admin_productos: {(u.admin_productos ? "Sí" : "No")}"
                            );
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error al cargar usuarios: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }


        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxUsuarios.SelectedIndex;
            if (index >= 0 && index < usuariosCargados.Count)
            {
                var user = usuariosCargados[index];

                textNombre.Text = user.nombre;
                textEmail.Text = user.email;
                checkBoxProductos.Checked = user.admin_productos;
                checkBoxUsuarios.Checked = user.admin_usuarios;

            }
        }

        private void buttonBuscarNombre_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBuscadorNombre.Text.Trim();

            //SI NO HAY TEXTO QUE CARGUE TODOS
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarUsuarios();
                return;
            }
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/usuarios/buscarUsuariosNombre?texto={Uri.EscapeDataString(textoBusqueda)}";
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    usuariosCargados = JsonConvert.DeserializeObject<List<Usuarios>>(json);
                    cargarUsuariosBuscados(usuariosCargados);
                }
                else
                {
                    MessageBox.Show("Error al buscar usuarios: " + response.StatusCode);
                }
            }
        }
        private void buttonBuscarCorreo_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBuscadorCorreo.Text.Trim();

            //SI NO HAY TEXTO QUE CARGUE TODOS
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarUsuarios();
                return;
            }
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/usuarios/buscarUsuariosEmail?texto={Uri.EscapeDataString(textoBusqueda)}";
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    usuariosCargados = JsonConvert.DeserializeObject<List<Usuarios>>(json);
                    cargarUsuariosBuscados(usuariosCargados);
                }
                else
                {
                    MessageBox.Show("Error al buscar usuarios: " + response.StatusCode);
                }
            }
        }

        private void cargarUsuariosBuscados(List<Usuarios> productos)
        {
            listBoxUsuarios.Items.Clear();

            foreach (var u in usuariosCargados)
            {
                listBoxUsuarios.Items.Add(
                    $"Nombre: {u.nombre}, Email: {u.email}, admin_usuarios: {(u.admin_usuarios ? "Sí" : "No")}, admin_productos: {(u.admin_productos ? "Sí" : "No")}"
                );
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int index = listBoxUsuarios.SelectedIndex;
            if (index >= 0 && index < usuariosCargados.Count)
            {
                var usuarioAEliminar = usuariosCargados[index];

                DialogResult confirm = MessageBox.Show(
                    $"¿Estás seguro de que quieres eliminar el usuario '{usuarioAEliminar.nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        ;
                        var json = JsonConvert.SerializeObject(usuarioAEliminar);
                        var content = new StringContent(JsonConvert.SerializeObject(usuarioAEliminar.id), Encoding.UTF8, "application/json");

                        var response = client.PostAsync("http://localhost:8082/usuarios/eliminarUsuarios", content).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.");
                            CargarUsuarios();

                            //LIMPIAR LOS COMPONENTES
                            textNombre.Clear();
                            textEmail.Clear();
                            textContraseña.Clear();
                            checkBoxUsuarios.Checked = false;
                            checkBoxProductos.Checked = false;
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
                MessageBox.Show("Selecciona un usuarios para eliminar.");
            }
        }

        private void buttonCatalogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Catalogo().Show();
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null && Sesion.UsuarioActual.admin_productos)
            {
                this.Hide();
                new AdministracionProductos().Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a la gestión de productos.");
            }
        }

        private void textBoxNombre_Click(object sender, EventArgs e)
        {
            textBuscadorNombre.Clear();
        }

        private void textBoxCorreo_Click(object sender, EventArgs e)
        {
            textBuscadorCorreo.Clear();
        }

    }

}
