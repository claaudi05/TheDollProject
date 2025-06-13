namespace ProyectoClaudia
{
    partial class DetallesPedidos
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
            this.buttoVolver = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.label1.TabIndex = 20;
            this.label1.Text = "MIS PEDIDOS";
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
            this.label9.TabIndex = 21;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(923, 42);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(181, 33);
            this.buttonCerrarSesion.TabIndex = 51;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttoVolver
            // 
            this.buttoVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.buttoVolver.BackgroundImage = global::ProyectoClaudia.Properties.Resources.fondoBotones;
            this.buttoVolver.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoVolver.Location = new System.Drawing.Point(24, 42);
            this.buttoVolver.Margin = new System.Windows.Forms.Padding(2);
            this.buttoVolver.Name = "buttoVolver";
            this.buttoVolver.Size = new System.Drawing.Size(78, 33);
            this.buttoVolver.TabIndex = 52;
            this.buttoVolver.Text = "Volver";
            this.buttoVolver.UseVisualStyleBackColor = false;
            this.buttoVolver.Click += new System.EventHandler(this.buttoVolver_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 91);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1080, 494);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // DetallesPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttoVolver);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetallesPedidos";
            this.Text = "DetallesPedidos";
            this.Load += new System.EventHandler(this.DetallesPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttoVolver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}