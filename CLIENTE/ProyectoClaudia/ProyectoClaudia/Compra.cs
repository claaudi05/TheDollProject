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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            int idUsuario = Sesion.UsuarioActual.id;
            string tarjetaTexto = textTarjeta.Text.Trim();
            string codigoTexto = textBoxCVV.Text.Trim();

            // Validaciones básicas
            if (tarjetaTexto.Length != 16 || !tarjetaTexto.All(char.IsDigit))
            {
                MessageBox.Show("La tarjeta debe contener exactamente 16 dígitos numéricos.");
                return;
            }

            if (codigoTexto.Length != 3 || !codigoTexto.All(char.IsDigit))
            {
                MessageBox.Show("El código de seguridad debe contener exactamente 3 dígitos numéricos.");
                return;
            }

            if (comboBoxMes.SelectedItem == null || comboBoxAño.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una fecha de caducidad válida.");
                return;
            }

            int mes = int.Parse(comboBoxMes.SelectedItem.ToString());
            int año = int.Parse(comboBoxAño.SelectedItem.ToString());

            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;

            if (año < añoActual || (año == añoActual && mes < mesActual))
            {
                MessageBox.Show("La tarjeta está caducada.");
                return;
            }

            String tarjeta = tarjetaTexto;
            int codigoSeguridad = int.Parse(codigoTexto);

            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/pedido/realizar?idUsuario={idUsuario}";

                HttpResponseMessage response = client.PostAsync(url, null).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Compra realizada con éxito.");
                    this.Hide();
                    new Catalogo().Show();
                }
                else
                {
                    string error = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    MessageBox.Show("Error al realizar la compra: " + error);
                }
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cestas().Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }
    }
}
