namespace Pryecto_IDS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.LogoIntec = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Colmena = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.tuNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Publicacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Seleccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calificaciones = new System.Windows.Forms.Button();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIntec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colmena)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.BarraTitulo.Controls.Add(this.LogoIntec);
            this.BarraTitulo.Controls.Add(this.Restaurar);
            this.BarraTitulo.Controls.Add(this.Minimizar);
            this.BarraTitulo.Controls.Add(this.Maximizar);
            this.BarraTitulo.Controls.Add(this.Cerrar);
            this.BarraTitulo.Controls.Add(this.Colmena);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(986, 37);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // LogoIntec
            // 
            this.LogoIntec.BackColor = System.Drawing.Color.White;
            this.LogoIntec.Image = ((System.Drawing.Image)(resources.GetObject("LogoIntec.Image")));
            this.LogoIntec.Location = new System.Drawing.Point(37, 0);
            this.LogoIntec.Name = "LogoIntec";
            this.LogoIntec.Size = new System.Drawing.Size(86, 31);
            this.LogoIntec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoIntec.TabIndex = 0;
            this.LogoIntec.TabStop = false;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(906, 0);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(37, 37);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 3;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(863, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(37, 37);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(906, 0);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(37, 37);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 1;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(949, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(37, 37);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Colmena
            // 
            this.Colmena.Image = ((System.Drawing.Image)(resources.GetObject("Colmena.Image")));
            this.Colmena.Location = new System.Drawing.Point(-45, -69);
            this.Colmena.Name = "Colmena";
            this.Colmena.Size = new System.Drawing.Size(343, 262);
            this.Colmena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Colmena.TabIndex = 0;
            this.Colmena.TabStop = false;
            // 
            // MenuVertical
            // 
            this.MenuVertical.Controls.Add(this.tuNombre);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.Registro);
            this.MenuVertical.Controls.Add(this.Login);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.Publicacion);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.Seleccion);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.Calificaciones);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 37);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(231, 501);
            this.MenuVertical.TabIndex = 1;
            // 
            // tuNombre
            // 
            this.tuNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tuNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNombre.Location = new System.Drawing.Point(0, 200);
            this.tuNombre.Name = "tuNombre";
            this.tuNombre.Size = new System.Drawing.Size(231, 29);
            this.tuNombre.TabIndex = 0;
            this.tuNombre.Text = "label2";
            this.tuNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tuNombre.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-45, -106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bienvenido";
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(118, 206);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(100, 23);
            this.Registro.TabIndex = 11;
            this.Registro.Text = "Registrarse";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 206);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 23);
            this.Login.TabIndex = 10;
            this.Login.Text = "Iniciar Sesion";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-1, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // Publicacion
            // 
            this.Publicacion.BackColor = System.Drawing.SystemColors.Control;
            this.Publicacion.FlatAppearance.BorderSize = 0;
            this.Publicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Publicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Publicacion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion.Location = new System.Drawing.Point(3, 246);
            this.Publicacion.Name = "Publicacion";
            this.Publicacion.Size = new System.Drawing.Size(226, 54);
            this.Publicacion.TabIndex = 5;
            this.Publicacion.Text = "Publicacion";
            this.Publicacion.UseVisualStyleBackColor = false;
            this.Publicacion.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 54);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // Seleccion
            // 
            this.Seleccion.BackColor = System.Drawing.SystemColors.Control;
            this.Seleccion.FlatAppearance.BorderSize = 0;
            this.Seleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seleccion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccion.Location = new System.Drawing.Point(5, 306);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(226, 54);
            this.Seleccion.TabIndex = 3;
            this.Seleccion.Text = "Seleccion";
            this.Seleccion.UseVisualStyleBackColor = false;
            this.Seleccion.Visible = false;
            this.Seleccion.Click += new System.EventHandler(this.Seleccion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 54);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // Calificaciones
            // 
            this.Calificaciones.BackColor = System.Drawing.SystemColors.Control;
            this.Calificaciones.FlatAppearance.BorderSize = 0;
            this.Calificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Calificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calificaciones.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calificaciones.Location = new System.Drawing.Point(5, 246);
            this.Calificaciones.Name = "Calificaciones";
            this.Calificaciones.Size = new System.Drawing.Size(226, 54);
            this.Calificaciones.TabIndex = 1;
            this.Calificaciones.Text = "Calificaciones";
            this.Calificaciones.UseVisualStyleBackColor = false;
            this.Calificaciones.Visible = false;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Brown;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(231, 37);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(755, 501);
            this.Contenedor.TabIndex = 2;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 538);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoIntec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colmena)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox LogoIntec;
        private System.Windows.Forms.PictureBox Colmena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Calificaciones;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button Publicacion;
        public System.Windows.Forms.Button Seleccion;
        public System.Windows.Forms.Label tuNombre;
        public System.Windows.Forms.Panel Contenedor;
        public System.Windows.Forms.Button Registro;
        public System.Windows.Forms.Button Login;
        public System.Windows.Forms.Label label1;
    }
}

