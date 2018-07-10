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
    public partial class Seleccion : Form
    {
        private Form1 mainForm = null;
        private Login Loggeado = null;
        public Seleccion(Form callingForm)
        {
            mainForm = callingForm as Form1;
            Loggeado = callingForm as Login;
            InitializeComponent();
            for (int i = 0; i < nLineas; i++)
            {
                listaMaterias.Items.Add(contenidoTexto[i]);
            }
        }
        public string ruta;
        string[] contenidoTexto = File.ReadAllLines("C:\\Users\\Kamehametroll\\Desktop\\materias.txt");// Para leer el texto
        public int nLineas = File.ReadAllLines("C:\\Users\\Kamehametroll\\Desktop\\materias.txt").Length; // Para contar el numero de lineas
        public string texto;

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            listaMaterias.Items.Clear();
            texto = (textBox.Text).ToUpper();
            for (int i = 0; i < nLineas; i++)
            {
                if (revisar(texto, contenidoTexto[i])) listaMaterias.Items.Add(contenidoTexto[i]);
            }
            textBox.Text = "";

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        bool revisar(String A, String B)
        {
            int sizeA = A.Length;
            int sizeB = B.Length;
            int total = sizeB - sizeA;
            if (total == 0) total = 1;
            for (int j = 0; j < total; j++)
            {
                if (A == B.Substring(j, sizeA))
                {
                    return true;
                }
            }
            return false;
        }

        private void listaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randomCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://random.cat/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            string[] temp = new string[nLineas];
            /*for (int i = 0; i < nLineas; i++)
            {
                if (listaMaterias.GetItemChecked(i) == true)
                {
                    temp[i+1] = listaMaterias.C();
                }
            }
            File.AppendAllLines(ruta, temp);*/
            int contador = 0;
            for(int j=0; j<13; j++)
            {
                if (listaMaterias.GetItemChecked(j) == true)
                {
                    contador++;
                }
            }

            string[] palabras = new string[contador+1];
            int i = 0;
            foreach (string s in listaMaterias.CheckedItems)
            {
                palabras[i+1] = s;
                i++;
            }
            File.AppendAllLines(ruta, palabras);
        }

        public string IDestudiantes
        {
            get { return ruta; }
            set { ruta = value; }
        }
    }
}
