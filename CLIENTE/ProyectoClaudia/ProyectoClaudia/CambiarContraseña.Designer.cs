namespace ProyectoClaudia
{
    partial class CambiarContraseña
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
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textRepetirContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNuevaContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "CREAR NUEVA CUENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MediumPurple;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(0, 420);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(800, 30);
            this.label9.TabIndex = 21;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(608, 44);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 38;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonVolver.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonVolver.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(10, 44);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(78, 33);
            this.buttonVolver.TabIndex = 37;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textRepetirContraseña
            // 
            this.textRepetirContraseña.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textRepetirContraseña.Location = new System.Drawing.Point(140, 233);
            this.textRepetirContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.textRepetirContraseña.Multiline = true;
            this.textRepetirContraseña.Name = "textRepetirContraseña";
            this.textRepetirContraseña.PasswordChar = '*';
            this.textRepetirContraseña.Size = new System.Drawing.Size(455, 37);
            this.textRepetirContraseña.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "RepetirContraseña";
            // 
            // textNuevaContraseña
            // 
            this.textNuevaContraseña.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.textNuevaContraseña.Location = new System.Drawing.Point(140, 120);
            this.textNuevaContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.textNuevaContraseña.Multiline = true;
            this.textNuevaContraseña.Name = "textNuevaContraseña";
            this.textNuevaContraseña.PasswordChar = '*';
            this.textNuevaContraseña.Size = new System.Drawing.Size(455, 37);
            this.textNuevaContraseña.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nueva contraseña";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonGuardar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(268, 328);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(181, 33);
            this.buttonGuardar.TabIndex = 43;
            this.buttonGuardar.Text = "Aceptar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textRepetirContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNuevaContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarContraseña";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textRepetirContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNuevaContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardar;
    }
}