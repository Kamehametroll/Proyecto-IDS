namespace Pryecto_IDS
{
    partial class Seleccion
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
            this.botonBuscar = new System.Windows.Forms.Button();
            this.listaMaterias = new System.Windows.Forms.CheckedListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.randomCat = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Aplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(40, 39);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 26);
            this.botonBuscar.TabIndex = 0;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // listaMaterias
            // 
            this.listaMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaMaterias.CheckOnClick = true;
            this.listaMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMaterias.FormattingEnabled = true;
            this.listaMaterias.Location = new System.Drawing.Point(40, 71);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(560, 319);
            this.listaMaterias.TabIndex = 1;
            this.listaMaterias.SelectedIndexChanged += new System.EventHandler(this.listaMaterias_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(121, 39);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(164, 26);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // randomCat
            // 
            this.randomCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.randomCat.AutoSize = true;
            this.randomCat.Font = new System.Drawing.Font("Comic Sans MS", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomCat.Location = new System.Drawing.Point(746, 438);
            this.randomCat.Name = "randomCat";
            this.randomCat.Size = new System.Drawing.Size(41, 10);
            this.randomCat.TabIndex = 3;
            this.randomCat.TabStop = true;
            this.randomCat.Text = "RandomCat";
            this.randomCat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.randomCat_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escriba las materias que desea seleccionar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Aplicar
            // 
            this.Aplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Aplicar.Location = new System.Drawing.Point(40, 396);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Aplicar.TabIndex = 5;
            this.Aplicar.Text = "Aplicar";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomCat);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listaMaterias);
            this.Controls.Add(this.botonBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.LinkLabel randomCat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckedListBox listaMaterias;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Aplicar;
    }
}

