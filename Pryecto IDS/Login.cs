using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Pryecto_IDS.Properties;


namespace Pryecto_IDS
{
    public partial class Login : Form
    {
        Form1 mainForm = null;
        public Login(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }
        public string text;
        private void Habilitar()
        {
            this.mainForm.LoginHabilitado = false;
            this.mainForm.RegistroHabilitado = false;
            this.mainForm.NombreVisible = true;
            this.mainForm.Rojo1 = true;
            this.mainForm.Rojo2 = true;
        }
        public static string path;
        public void Login2_Click(object sender, EventArgs e)
        {
            string searchID = ID.Text + ".txt";
            path = @"C:\Users\Kamehametroll\Desktop\" + @searchID;
            this.mainForm.IDestudiantes = path;
            if (File.Exists(path))
            {
                StreamReader usuario = null;
                usuario = new StreamReader(path);
                text = usuario.ReadLine();
                string[] nombre = text.Split('☻');
                this.mainForm.LabelText = nombre[0];
                if (nombre[1] == "profe")
                {
                    this.mainForm.PublicacionHabilitada = true;
                }
                else
                {
                    this.mainForm.SeleccionHabilitado = true;
                    this.mainForm.CalificacionHabilitado = true;
                }
                noexisteID.Visible = false;
                Habilitar();
                this.Hide();
            }
            else
            {
                noexisteID.Visible = true;
            }
        }
    }
}
