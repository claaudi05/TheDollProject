namespace ProyectoClaudia
{
    partial class Perfil
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.linkLabelContraseña = new System.Windows.Forms.LinkLabel();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonCambiarFoto = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.label1.Text = "MI PERFIL";
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
            this.label3.Location = new System.Drawing.Point(242, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 27);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nombre de usuario:";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textNombre.Location = new System.Drawing.Point(436, 150);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(651, 37);
            this.textNombre.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "Correo electrónico:";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textEmail.Location = new System.Drawing.Point(436, 215);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(651, 37);
            this.textEmail.TabIndex = 53;
            // 
            // linkLabelContraseña
            // 
            this.linkLabelContraseña.AutoSize = true;
            this.linkLabelContraseña.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.linkLabelContraseña.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelContraseña.Location = new System.Drawing.Point(244, 297);
            this.linkLabelContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelContraseña.Name = "linkLabelContraseña";
            this.linkLabelContraseña.Size = new System.Drawing.Size(194, 27);
            this.linkLabelContraseña.TabIndex = 54;
            this.linkLabelContraseña.TabStop = true;
            this.linkLabelContraseña.Text = "Cambiar contraseña";
            this.linkLabelContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContraseña_LinkClicked);
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonPedidos.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedidos.Location = new System.Drawing.Point(30, 498);
            this.buttonPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(181, 33);
            this.buttonPedidos.TabIndex = 56;
            this.buttonPedidos.Text = "Mis pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            this.buttonPedidos.Click += new System.EventHandler(this.buttonPedidos_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(933, 45);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 49;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonVolver.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonVolver.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(20, 45);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(78, 33);
            this.buttonVolver.TabIndex = 48;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonCambiarFoto
            // 
            this.buttonCambiarFoto.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCambiarFoto.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarFoto.Location = new System.Drawing.Point(30, 389);
            this.buttonCambiarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCambiarFoto.Name = "buttonCambiarFoto";
            this.buttonCambiarFoto.Size = new System.Drawing.Size(257, 33);
            this.buttonCambiarFoto.TabIndex = 58;
            this.buttonCambiarFoto.Text = "Cambiar foto de perfil";
            this.buttonCambiarFoto.UseVisualStyleBackColor = true;
            this.buttonCambiarFoto.Click += new System.EventHandler(this.buttonCambiarFoto_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(42, 141);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(169, 183);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 59;
            this.pictureBox.TabStop = false;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonCambiarFoto);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.linkLabelContraseña);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.LinkLabel linkLabelContraseña;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.Button buttonCambiarFoto;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}