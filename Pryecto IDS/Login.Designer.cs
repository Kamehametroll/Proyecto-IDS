namespace Pryecto_IDS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logologin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.LoginID = new System.Windows.Forms.Label();
            this.login2 = new System.Windows.Forms.Button();
            this.noexisteID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logologin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logologin
            // 
            this.logologin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logologin.Image = ((System.Drawing.Image)(resources.GetObject("logologin.Image")));
            this.logologin.Location = new System.Drawing.Point(613, 12);
            this.logologin.Name = "logologin";
            this.logologin.Size = new System.Drawing.Size(175, 81);
            this.logologin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logologin.TabIndex = 1;
            this.logologin.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio de sesion del sistema";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(305, 202);
            this.ID.MaxLength = 7;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(182, 41);
            this.ID.TabIndex = 3;
            // 
            // LoginID
            // 
            this.LoginID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginID.AutoSize = true;
            this.LoginID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginID.Location = new System.Drawing.Point(95, 202);
            this.LoginID.Name = "LoginID";
            this.LoginID.Size = new System.Drawing.Size(183, 34);
            this.LoginID.TabIndex = 4;
            this.LoginID.Text = "Ingresa tu ID";
            // 
            // login2
            // 
            this.login2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.login2.Location = new System.Drawing.Point(387, 249);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(100, 23);
            this.login2.TabIndex = 11;
            this.login2.Text = "Iniciar Sesion";
            this.login2.UseVisualStyleBackColor = true;
            this.login2.Click += new System.EventHandler(this.Login2_Click);
            // 
            // noexisteID
            // 
            this.noexisteID.AutoSize = true;
            this.noexisteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noexisteID.ForeColor = System.Drawing.Color.Maroon;
            this.noexisteID.Location = new System.Drawing.Point(493, 202);
            this.noexisteID.Name = "noexisteID";
            this.noexisteID.Size = new System.Drawing.Size(209, 24);
            this.noexisteID.TabIndex = 12;
            this.noexisteID.Text = "Tu ID no esta registrado";
            this.noexisteID.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.noexisteID);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.LoginID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logologin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logologin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logologin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label LoginID;
        private System.Windows.Forms.Button login2;
        private System.Windows.Forms.Label noexisteID;
    }
}