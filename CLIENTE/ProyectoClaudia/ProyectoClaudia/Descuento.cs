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
    public partial class Descuento : Form
    {
        private List<Descuentos> descuentos = new List<Descuentos>();

        public Descuento()
        {
            InitializeComponent();
        }

        private void Descuento_Load(object sender, EventArgs e)
        {
            CargarDescuentos();
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
                    RefrescarLista();
                }
                else
                {
                    MessageBox.Show("Error al cargar los descuentos.");
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textPorcentaje.Text, out double porcentaje) &&
                double.TryParse(textImporte.Text, out double importe))
            {
                Descuentos descuento;

                using (HttpClient client = new HttpClient())
                {
                    if (listBoxDescuentos.SelectedIndex >= 0)
                    {
                        // Modificar
                        descuento = descuentos[listBoxDescuentos.SelectedIndex];
                        descuento.porcentaje = porcentaje;
                        descuento.precio = importe;

                        string json = JsonConvert.SerializeObject(descuento);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("http://localhost:8082/descuentos/actualizar", content).Result;

                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Error al actualizar.");
                            return;
                        }
                    }
                    else
                    {
                        // Nuevo
                        descuento = new Descuentos
                        {
                            porcentaje = porcentaje,
                            precio = importe
                        };

                        string json = JsonConvert.SerializeObject(descuento);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("http://localhost:8082/descuentos/agregar", content).Result;

                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Error al agregar.");
                            return;
                        }
                    }

                    CargarDescuentos();
                    LimpiarCampos();
                    MessageBox.Show("Guardado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Introduce valores válidos.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxDescuentos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un descuento para eliminar.");
                return;
            }

            int id = descuentos[listBoxDescuentos.SelectedIndex].id;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync($"http://localhost:8082/descuentos/eliminar?id={id}").Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Descuento eliminado.");
                    CargarDescuentos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar.");
                }
            }
        }

        private void listBoxDescuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDescuentos.SelectedIndex;
            if (index >= 0 && index < descuentos.Count)
            {
                var descuento = descuentos[index];

                textPorcentaje.Text = descuento.porcentaje+"";
                textImporte.Text = descuento.precio + "";
            }
        }
        private void RefrescarLista()
        {
            listBoxDescuentos.DataSource = null;
            listBoxDescuentos.DataSource = descuentos;
            listBoxDescuentos.DisplayMember = "porcentaje";
        }

        private void LimpiarCampos()
        {
            textPorcentaje.Clear();
            textImporte.Clear();
            listBoxDescuentos.ClearSelected();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdministracionProductos().Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }

}
