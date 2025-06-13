namespace ProyectoClaudia
{
    partial class AdministradorUsuarios
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
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBuscadorNombre = new System.Windows.Forms.TextBox();
            this.textBuscadorCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUsuarios = new System.Windows.Forms.CheckBox();
            this.checkBoxProductos = new System.Windows.Forms.CheckBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.buttonBuscarCorreo = new System.Windows.Forms.Button();
            this.buttonLupaCorreo = new System.Windows.Forms.Button();
            this.buttonBuscarNombre = new System.Windows.Forms.Button();
            this.buttonLupaNombre = new System.Windows.Forms.Button();
            this.buttonProducto = new System.Windows.Forms.Button();
            this.buttonCatalogo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRACIÓN DE LOS USUARIOS";
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
            this.label9.TabIndex = 16;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.ItemHeight = 19;
            this.listBoxUsuarios.Location = new System.Drawing.Point(734, 54);
            this.listBoxUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(386, 536);
            this.listBoxUsuarios.TabIndex = 21;
            this.listBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuarios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Búsqueda por nombre:";
            // 
            // textBuscadorNombre
            // 
            this.textBuscadorNombre.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscadorNombre.Location = new System.Drawing.Point(231, 45);
            this.textBuscadorNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscadorNombre.Name = "textBuscadorNombre";
            this.textBuscadorNombre.Size = new System.Drawing.Size(320, 33);
            this.textBuscadorNombre.TabIndex = 26;
            this.textBuscadorNombre.Text = "Buscador";
            // 
            // textBuscadorCorreo
            // 
            this.textBuscadorCorreo.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscadorCorreo.Location = new System.Drawing.Point(231, 94);
            this.textBuscadorCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscadorCorreo.Name = "textBuscadorCorreo";
            this.textBuscadorCorreo.Size = new System.Drawing.Size(320, 33);
            this.textBuscadorCorreo.TabIndex = 30;
            this.textBuscadorCorreo.Text = "Buscador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Búsqueda por correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Correo electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 27);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nombre de usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUsuarios);
            this.groupBox1.Controls.Add(this.checkBoxProductos);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 352);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(414, 76);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADMINISTRADOR";
            // 
            // checkBoxUsuarios
            // 
            this.checkBoxUsuarios.AutoSize = true;
            this.checkBoxUsuarios.Location = new System.Drawing.Point(237, 40);
            this.checkBoxUsuarios.Name = "checkBoxUsuarios";
            this.checkBoxUsuarios.Size = new System.Drawing.Size(108, 31);
            this.checkBoxUsuarios.TabIndex = 1;
            this.checkBoxUsuarios.Text = "Usuarios";
            this.checkBoxUsuarios.UseVisualStyleBackColor = true;
            // 
            // checkBoxProductos
            // 
            this.checkBoxProductos.AutoSize = true;
            this.checkBoxProductos.Location = new System.Drawing.Point(15, 40);
            this.checkBoxProductos.Name = "checkBoxProductos";
            this.checkBoxProductos.Size = new System.Drawing.Size(119, 31);
            this.checkBoxProductos.TabIndex = 0;
            this.checkBoxProductos.Text = "Productos";
            this.checkBoxProductos.UseVisualStyleBackColor = true;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textEmail.Location = new System.Drawing.Point(225, 172);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(490, 37);
            this.textEmail.TabIndex = 38;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textNombre.Location = new System.Drawing.Point(225, 229);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(490, 37);
            this.textNombre.TabIndex = 39;
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textContraseña.Location = new System.Drawing.Point(225, 286);
            this.textContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.textContraseña.Multiline = true;
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(490, 37);
            this.textContraseña.TabIndex = 40;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(263, 544);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 45;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCancelar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(501, 490);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(181, 33);
            this.buttonCancelar.TabIndex = 44;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonEliminar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(263, 490);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(181, 33);
            this.buttonEliminar.TabIndex = 43;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonGuardarUsuario.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(26, 490);
            this.buttonGuardarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(181, 33);
            this.buttonGuardarUsuario.TabIndex = 42;
            this.buttonGuardarUsuario.Text = "Guardar";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = true;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGuardarUsuario_Click);
            // 
            // buttonBuscarCorreo
            // 
            this.buttonBuscarCorreo.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonBuscarCorreo.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCorreo.Location = new System.Drawing.Point(604, 92);
            this.buttonBuscarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarCorreo.Name = "buttonBuscarCorreo";
            this.buttonBuscarCorreo.Size = new System.Drawing.Size(116, 35);
            this.buttonBuscarCorreo.TabIndex = 31;
            this.buttonBuscarCorreo.Text = "BUSCAR";
            this.buttonBuscarCorreo.UseVisualStyleBackColor = true;
            this.buttonBuscarCorreo.Click += new System.EventHandler(this.buttonBuscarCorreo_Click);
            // 
            // buttonLupaCorreo
            // 
            this.buttonLupaCorreo.BackColor = System.Drawing.Color.Thistle;
            this.buttonLupaCorreo.BackgroundImage = global::ProyectoClaudia.Properties.Resources.lupa1;
            this.buttonLupaCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLupaCorreo.Location = new System.Drawing.Point(555, 92);
            this.buttonLupaCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLupaCorreo.Name = "buttonLupaCorreo";
            this.buttonLupaCorreo.Size = new System.Drawing.Size(45, 35);
            this.buttonLupaCorreo.TabIndex = 29;
            this.buttonLupaCorreo.UseVisualStyleBackColor = false;
            this.buttonLupaCorreo.Click += new System.EventHandler(this.buttonBuscarCorreo_Click);
            // 
            // buttonBuscarNombre
            // 
            this.buttonBuscarNombre.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonBuscarNombre.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarNombre.Location = new System.Drawing.Point(604, 43);
            this.buttonBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarNombre.Name = "buttonBuscarNombre";
            this.buttonBuscarNombre.Size = new System.Drawing.Size(116, 35);
            this.buttonBuscarNombre.TabIndex = 27;
            this.buttonBuscarNombre.Text = "BUSCAR";
            this.buttonBuscarNombre.UseVisualStyleBackColor = true;
            this.buttonBuscarNombre.Click += new System.EventHandler(this.buttonBuscarNombre_Click);
            // 
            // buttonLupaNombre
            // 
            this.buttonLupaNombre.BackColor = System.Drawing.Color.Thistle;
            this.buttonLupaNombre.BackgroundImage = global::ProyectoClaudia.Properties.Resources.lupa1;
            this.buttonLupaNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLupaNombre.Location = new System.Drawing.Point(555, 43);
            this.buttonLupaNombre.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLupaNombre.Name = "buttonLupaNombre";
            this.buttonLupaNombre.Size = new System.Drawing.Size(45, 35);
            this.buttonLupaNombre.TabIndex = 24;
            this.buttonLupaNombre.UseVisualStyleBackColor = false;
            this.buttonLupaNombre.Click += new System.EventHandler(this.buttonBuscarNombre_Click);
            // 
            // buttonProducto
            // 
            this.buttonProducto.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonProducto.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducto.Location = new System.Drawing.Point(26, 544);
            this.buttonProducto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProducto.Name = "buttonProducto";
            this.buttonProducto.Size = new System.Drawing.Size(181, 33);
            this.buttonProducto.TabIndex = 46;
            this.buttonProducto.Text = "Producto";
            this.buttonProducto.UseVisualStyleBackColor = true;
            this.buttonProducto.Click += new System.EventHandler(this.buttonProducto_Click);
            // 
            // buttonCatalogo
            // 
            this.buttonCatalogo.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCatalogo.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatalogo.Location = new System.Drawing.Point(501, 544);
            this.buttonCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCatalogo.Name = "buttonCatalogo";
            this.buttonCatalogo.Size = new System.Drawing.Size(181, 33);
            this.buttonCatalogo.TabIndex = 47;
            this.buttonCatalogo.Text = "Catalogo";
            this.buttonCatalogo.UseVisualStyleBackColor = true;
            this.buttonCatalogo.Click += new System.EventHandler(this.buttonCatalogo_Click);
            // 
            // AdministradorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.buttonCatalogo);
            this.Controls.Add(this.buttonProducto);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardarUsuario);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBuscarCorreo);
            this.Controls.Add(this.textBuscadorCorreo);
            this.Controls.Add(this.buttonLupaCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuscarNombre);
            this.Controls.Add(this.textBuscadorNombre);
            this.Controls.Add(this.buttonLupaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxUsuarios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministradorUsuarios";
            this.Text = "AdministradorUsuarios";
            this.Load += new System.EventHandler(this.AdministradorUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLupaNombre;
        private System.Windows.Forms.TextBox textBuscadorNombre;
        private System.Windows.Forms.Button buttonBuscarNombre;
        private System.Windows.Forms.Button buttonBuscarCorreo;
        private System.Windows.Forms.TextBox textBuscadorCorreo;
        private System.Windows.Forms.Button buttonLupaCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button buttonGuardarUsuario;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonProducto;
        private System.Windows.Forms.Button buttonCatalogo;
        private System.Windows.Forms.CheckBox checkBoxUsuarios;
        private System.Windows.Forms.CheckBox checkBoxProductos;
    }
}