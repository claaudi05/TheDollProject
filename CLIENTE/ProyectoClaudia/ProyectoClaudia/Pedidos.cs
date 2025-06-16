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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            // Mostrar solo si es admin_productos
            if (Sesion.UsuarioActual.admin_productos == true)
            {
                buttonVolverProductos.Visible = true;
            }
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesion().Show();
        }

        private void buttoVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Perfil().Show();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            string url;
            if (Sesion.UsuarioActual.admin_productos == true)
            {
                url = $"http://localhost:8082/pedido/pendientes";
            }
            else
            {
                int usuarioId = Sesion.UsuarioActual.id;
                url = $"http://localhost:8082/pedido/usuario/{usuarioId}";
            }

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    List<Pedido> pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json);

                    flowLayoutPanel1.Controls.Clear();

                    foreach (var pedido in pedidos)
                    {
                        Panel panel = CrearPanelPedido(pedido);
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar los pedidos.");
                }
            }
        }
        private Panel CrearPanelPedido(Pedido pedido)
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = 400,
                Height = 180,
                Margin = new Padding(10)
            };

            Label lblFechaPedido = new Label
            {
                Text = $"Fecha Pedido: {pedido.fecha_pedido.ToShortDateString()}",
                Location = new Point(10, 30),
                AutoSize = true
            };

            Label lblFechaEstimada = new Label
            {
                Text = $"Fecha Estimada: {pedido.fecha_estimada.ToShortDateString()}",
                Location = new Point(10, 50),
                AutoSize = true
            };

            Label lblTotal = new Label
            {
                Text = $"Total: {pedido.total:C2}",
                Location = new Point(10, 70),
                AutoSize = true
            };

            Button btnVerDetalles = new Button
            {
                Text = "Ver Detalles",
                Location = new Point(10, 100),
                Tag = pedido.id
            };
            btnVerDetalles.Click += (s, e) =>
            {
                this.Hide();
                int pedidoId = (int)((Button)s).Tag;
                new DetallesPedidos(pedidoId).Show();
            };

            panel.Controls.Add(lblFechaPedido);
            panel.Controls.Add(lblFechaEstimada);
            panel.Controls.Add(lblTotal);
            panel.Controls.Add(btnVerDetalles);

            //Mostrar botón "Entregado" si es admin productos
            if (Sesion.UsuarioActual.admin_productos == true)
            {
                Button btnEntregar = new Button
                {
                    Text = "Marcar como entregado",
                    Location = new Point(120, 100),
                    Width = 180,
                    Tag = pedido.id
                };
                btnEntregar.Click += BtnEntregar_Click;
                panel.Controls.Add(btnEntregar);
            }

            return panel;
        }
        private void BtnEntregar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idPedido = (int)btn.Tag;

            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:8082/pedido/marcarEntregado/{idPedido}";
                HttpResponseMessage response = client.PutAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Pedido marcado como entregado.");
                    Pedidos_Load(null, null); // recargar
                }
                else
                {
                    MessageBox.Show("Error al marcar como entregado.");
                }
            }
        }

        private void buttonVolverProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdministracionProductos().Show();
        }
    }
}
