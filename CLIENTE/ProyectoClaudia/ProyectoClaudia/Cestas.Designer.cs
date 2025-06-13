namespace ProyectoClaudia
{
    partial class Cestas
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBuscador = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelCesta = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonBuscador = new System.Windows.Forms.Button();
            this.buttonLupaBuscador = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.textTotalCompra = new System.Windows.Forms.TextBox();
            this.textDescuento = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "CESTA DE LA COMPRA";
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
            this.label9.TabIndex = 18;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto:";
            // 
            // textBuscador
            // 
            this.textBuscador.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscador.Location = new System.Drawing.Point(316, 45);
            this.textBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscador.Name = "textBuscador";
            this.textBuscador.Size = new System.Drawing.Size(478, 33);
            this.textBuscador.TabIndex = 20;
            this.textBuscador.Text = "Buscador";
            // 
            // flowLayoutPanelCesta
            // 
            this.flowLayoutPanelCesta.Location = new System.Drawing.Point(22, 86);
            this.flowLayoutPanelCesta.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelCesta.Name = "flowLayoutPanelCesta";
            this.flowLayoutPanelCesta.Size = new System.Drawing.Size(1064, 418);
            this.flowLayoutPanelCesta.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 555);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descuento aplicado:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(17, 514);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(195, 27);
            this.labelTotal.TabIndex = 33;
            this.labelTotal.Text = "Total de la compra:";
            // 
            // buttonComprar
            // 
            this.buttonComprar.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonComprar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonComprar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprar.Location = new System.Drawing.Point(848, 556);
            this.buttonComprar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(238, 33);
            this.buttonComprar.TabIndex = 34;
            this.buttonComprar.Text = "Realizar pedido";
            this.buttonComprar.UseVisualStyleBackColor = false;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonVolver.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonVolver.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(1008, 42);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(78, 33);
            this.buttonVolver.TabIndex = 30;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonBuscador
            // 
            this.buttonBuscador.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonBuscador.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscador.Location = new System.Drawing.Point(848, 45);
            this.buttonBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscador.Name = "buttonBuscador";
            this.buttonBuscador.Size = new System.Drawing.Size(116, 35);
            this.buttonBuscador.TabIndex = 29;
            this.buttonBuscador.Text = "BUSCAR";
            this.buttonBuscador.UseVisualStyleBackColor = true;
            this.buttonBuscador.Click += new System.EventHandler(this.buttonBuscador_Click);
            // 
            // buttonLupaBuscador
            // 
            this.buttonLupaBuscador.BackColor = System.Drawing.Color.Thistle;
            this.buttonLupaBuscador.BackgroundImage = global::ProyectoClaudia.Properties.Resources.lupa1;
            this.buttonLupaBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLupaBuscador.Location = new System.Drawing.Point(798, 45);
            this.buttonLupaBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLupaBuscador.Name = "buttonLupaBuscador";
            this.buttonLupaBuscador.Size = new System.Drawing.Size(45, 35);
            this.buttonLupaBuscador.TabIndex = 28;
            this.buttonLupaBuscador.UseVisualStyleBackColor = false;
            this.buttonLupaBuscador.Click += new System.EventHandler(this.buttonBuscador_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(22, 42);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 35;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // textTotalCompra
            // 
            this.textTotalCompra.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textTotalCompra.Location = new System.Drawing.Point(217, 508);
            this.textTotalCompra.Margin = new System.Windows.Forms.Padding(2);
            this.textTotalCompra.Multiline = true;
            this.textTotalCompra.Name = "textTotalCompra";
            this.textTotalCompra.Size = new System.Drawing.Size(490, 37);
            this.textTotalCompra.TabIndex = 39;
            // 
            // textDescuento
            // 
            this.textDescuento.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textDescuento.Location = new System.Drawing.Point(216, 552);
            this.textDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.textDescuento.Multiline = true;
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.Size = new System.Drawing.Size(490, 37);
            this.textDescuento.TabIndex = 40;
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textTotal.Location = new System.Drawing.Point(848, 511);
            this.textTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textTotal.Multiline = true;
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(238, 37);
            this.textTotal.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(775, 518);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total:";
            // 
            // Cestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textDescuento);
            this.Controls.Add(this.textTotalCompra);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelCesta);
            this.Controls.Add(this.buttonBuscador);
            this.Controls.Add(this.buttonLupaBuscador);
            this.Controls.Add(this.textBuscador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cestas";
            this.Text = "Cesta";
            this.Load += new System.EventHandler(this.Cesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBuscador;
        private System.Windows.Forms.Button buttonLupaBuscador;
        private System.Windows.Forms.Button buttonBuscador;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.TextBox textTotalCompra;
        private System.Windows.Forms.TextBox textDescuento;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label4;
    }
}