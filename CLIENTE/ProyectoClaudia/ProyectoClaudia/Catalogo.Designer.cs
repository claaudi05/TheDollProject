namespace ProyectoClaudia
{
    partial class Catalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBuscador = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMarca = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBuscador = new System.Windows.Forms.Button();
            this.buttonLupaBuscador = new System.Windows.Forms.Button();
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonDeseo = new System.Windows.Forms.Button();
            this.buttonCesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1131, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATÁLOGO DE MUÑECAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MediumPurple;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(0, 600);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1131, 30);
            this.label9.TabIndex = 17;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBuscador
            // 
            this.textBuscador.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscador.Location = new System.Drawing.Point(320, 49);
            this.textBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscador.Name = "textBuscador";
            this.textBuscador.Size = new System.Drawing.Size(446, 33);
            this.textBuscador.TabIndex = 28;
            this.textBuscador.Text = "Buscador";
            this.textBuscador.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // flowLayoutPanelMarca
            // 
            this.flowLayoutPanelMarca.Location = new System.Drawing.Point(6, 94);
            this.flowLayoutPanelMarca.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelMarca.Name = "flowLayoutPanelMarca";
            this.flowLayoutPanelMarca.Size = new System.Drawing.Size(1116, 125);
            this.flowLayoutPanelMarca.TabIndex = 31;
            // 
            // flowLayoutPanelProductos
            // 
            this.flowLayoutPanelProductos.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelProductos.Location = new System.Drawing.Point(6, 223);
            this.flowLayoutPanelProductos.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelProductos.Name = "flowLayoutPanelProductos";
            this.flowLayoutPanelProductos.Size = new System.Drawing.Size(1116, 362);
            this.flowLayoutPanelProductos.TabIndex = 32;
            // 
            // buttonBuscador
            // 
            this.buttonBuscador.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonBuscador.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscador.Location = new System.Drawing.Point(819, 47);
            this.buttonBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscador.Name = "buttonBuscador";
            this.buttonBuscador.Size = new System.Drawing.Size(116, 35);
            this.buttonBuscador.TabIndex = 30;
            this.buttonBuscador.Text = "BUSCAR";
            this.buttonBuscador.UseVisualStyleBackColor = true;
            this.buttonBuscador.Click += new System.EventHandler(this.buttonBuscador_Click);
            // 
            // buttonLupaBuscador
            // 
            this.buttonLupaBuscador.BackColor = System.Drawing.Color.Thistle;
            this.buttonLupaBuscador.BackgroundImage = global::ProyectoClaudia.Properties.Resources.lupa1;
            this.buttonLupaBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLupaBuscador.Location = new System.Drawing.Point(770, 46);
            this.buttonLupaBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLupaBuscador.Name = "buttonLupaBuscador";
            this.buttonLupaBuscador.Size = new System.Drawing.Size(45, 35);
            this.buttonLupaBuscador.TabIndex = 29;
            this.buttonLupaBuscador.UseVisualStyleBackColor = false;
            this.buttonLupaBuscador.Click += new System.EventHandler(this.buttonBuscador_Click);
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.BackColor = System.Drawing.Color.Thistle;
            this.buttonPerfil.BackgroundImage = global::ProyectoClaudia.Properties.Resources.perfil;
            this.buttonPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPerfil.Location = new System.Drawing.Point(214, 40);
            this.buttonPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(94, 41);
            this.buttonPerfil.TabIndex = 27;
            this.buttonPerfil.UseVisualStyleBackColor = false;
            this.buttonPerfil.Click += new System.EventHandler(this.buttonPerfil_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(941, 40);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 26;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonDeseo
            // 
            this.buttonDeseo.BackColor = System.Drawing.Color.Thistle;
            this.buttonDeseo.BackgroundImage = global::ProyectoClaudia.Properties.Resources.listaDeseos;
            this.buttonDeseo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeseo.Location = new System.Drawing.Point(116, 40);
            this.buttonDeseo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeseo.Name = "buttonDeseo";
            this.buttonDeseo.Size = new System.Drawing.Size(94, 41);
            this.buttonDeseo.TabIndex = 19;
            this.buttonDeseo.UseVisualStyleBackColor = false;
            this.buttonDeseo.Click += new System.EventHandler(this.buttonDeseo_Click);
            // 
            // buttonCesta
            // 
            this.buttonCesta.BackColor = System.Drawing.Color.Thistle;
            this.buttonCesta.BackgroundImage = global::ProyectoClaudia.Properties.Resources.carrito1;
            this.buttonCesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCesta.Location = new System.Drawing.Point(18, 41);
            this.buttonCesta.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCesta.Name = "buttonCesta";
            this.buttonCesta.Size = new System.Drawing.Size(94, 41);
            this.buttonCesta.TabIndex = 18;
            this.buttonCesta.UseVisualStyleBackColor = false;
            this.buttonCesta.Click += new System.EventHandler(this.buttonCesta_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.flowLayoutPanelProductos);
            this.Controls.Add(this.flowLayoutPanelMarca);
            this.Controls.Add(this.buttonBuscador);
            this.Controls.Add(this.buttonLupaBuscador);
            this.Controls.Add(this.textBuscador);
            this.Controls.Add(this.buttonPerfil);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonDeseo);
            this.Controls.Add(this.buttonCesta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catalogo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCesta;
        private System.Windows.Forms.Button buttonDeseo;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.TextBox textBuscador;
        private System.Windows.Forms.Button buttonLupaBuscador;
        private System.Windows.Forms.Button buttonBuscador;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMarca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductos;
    }
}