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

namespace Pryecto_IDS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public bool soyProfe;
        private void Register2_Click(object sender, EventArgs e)
        {
            string creaID = regID.Text + ".txt";
            string path = @"C:\Users\Kamehametroll\Desktop\" + @creaID;
            string creaNombre = Nombrereg.Text;
            string creaApellido = Apellidoreg.Text;
            string nCompleto =creaNombre+" "+creaApellido;
            if (File.Exists(path)|| String.IsNullOrEmpty(regID.Text) || String.IsNullOrEmpty(creaNombre)|| String.IsNullOrEmpty(creaApellido))
            {
                Registrado.Visible = false;
                if (File.Exists(path))
                {
                    yaexisteID.Visible = true;
                    noescritoID.Visible = false;
                }
                if (String.IsNullOrEmpty(regID.Text))
                {
                    noescritoID.Visible = true;
                    yaexisteID.Visible = false;
                }
                if (String.IsNullOrEmpty(creaNombre))
                {
                    noNombre.Visible = true;
                }
                else{
                    noNombre.Visible = false;
                }
                if (String.IsNullOrEmpty(creaApellido))
                {
                    noApellido.Visible = true;
                }else{
                    noApellido.Visible = false;
                }
            }
            else
            {
                Registrado.Visible = true;
                noescritoID.Visible = false;
                yaexisteID.Visible = false;
                noNombre.Visible = false;
                noApellido.Visible = false;

                using (FileStream fs = File.Create(path))
                {
                    Byte[] info;
                    if (soyProfe == true)
                    {
                        info = new UTF8Encoding(true).GetBytes(nCompleto + "☻" + "profe" + "☻\n");
                    }
                    else
                    {
                        info = new UTF8Encoding(true).GetBytes(nCompleto + "☻" + "" + "☻\n");
                    }
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                    Application.Exit();
                }
            }
        }

        public void Profestate_CheckedChanged(object sender, EventArgs e)
        {
            soyProfe = true;
        }
    }
}


