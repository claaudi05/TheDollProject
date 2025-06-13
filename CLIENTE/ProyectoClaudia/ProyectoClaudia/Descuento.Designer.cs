namespace ProyectoClaudia
{
    partial class Descuento
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
            this.listBoxDescuentos = new System.Windows.Forms.ListBox();
            this.textPorcentaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
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
            this.label1.Text = "DESCUENTOS";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Porcentaje de descuento:";
            // 
            // listBoxDescuentos
            // 
            this.listBoxDescuentos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBoxDescuentos.FormattingEnabled = true;
            this.listBoxDescuentos.ItemHeight = 19;
            this.listBoxDescuentos.Location = new System.Drawing.Point(737, 44);
            this.listBoxDescuentos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDescuentos.Name = "listBoxDescuentos";
            this.listBoxDescuentos.Size = new System.Drawing.Size(386, 536);
            this.listBoxDescuentos.TabIndex = 30;
            this.listBoxDescuentos.SelectedIndexChanged += new System.EventHandler(this.listBoxDescuentos_SelectedIndexChanged);
            // 
            // textPorcentaje
            // 
            this.textPorcentaje.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textPorcentaje.Location = new System.Drawing.Point(261, 127);
            this.textPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.textPorcentaje.Multiline = true;
            this.textPorcentaje.Name = "textPorcentaje";
            this.textPorcentaje.Size = new System.Drawing.Size(467, 37);
            this.textPorcentaje.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "Importe superior a:";
            // 
            // textImporte
            // 
            this.textImporte.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textImporte.Location = new System.Drawing.Point(261, 205);
            this.textImporte.Margin = new System.Windows.Forms.Padding(2);
            this.textImporte.Multiline = true;
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(467, 37);
            this.textImporte.TabIndex = 41;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonVolver.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonVolver.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(14, 55);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(78, 33);
            this.buttonVolver.TabIndex = 47;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(284, 403);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 46;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCancelar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(526, 311);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(181, 33);
            this.buttonCancelar.TabIndex = 45;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonEliminar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(284, 311);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(181, 33);
            this.buttonEliminar.TabIndex = 44;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonGuardar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(27, 311);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(181, 33);
            this.buttonGuardar.TabIndex = 43;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPorcentaje);
            this.Controls.Add(this.listBoxDescuentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Descuento";
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.Descuento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDescuentos;
        private System.Windows.Forms.TextBox textPorcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonVolver;
    }
}