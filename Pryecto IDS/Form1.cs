using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pryecto_IDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IsMdiContainer = true;
            InitializeComponent();
            Login.Visible = true;
            Registro.Visible = true;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LoginStart(object start)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form HS = start as Form;
            HS.TopLevel = false;
            HS.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(HS);
            this.Contenedor.Tag = HS;
            HS.Show();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            LoginStart(new Login(this));
        }
        private void RegisStart(object register)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form RS = register as Form;
            RS.TopLevel = false;
            RS.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(RS);
            this.Contenedor.Tag = RS;
            RS.Show();
        }
        private void Registro_Click(object sender, EventArgs e)
        {
            RegisStart(new Register());
        }
        private void SelecStart(object register)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form SS = register as Form;
            SS.TopLevel = false;
            SS.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(SS);
            this.Contenedor.Tag = SS;
            SS.Show();
        }
        private void Seleccion_Click(object sender, EventArgs e)
        {
            //SelecStart(new Seleccion(this));
            Seleccion F = new Seleccion(this);
            F.ruta = IDreal;
            SelecStart(F);
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        //Aqui hacemos un get set para cambiar el nombre del usuario, dependiendo del login. 
        public string LabelText
        {
            get
            {
                return this.tuNombre.Text;
            }
            set
            {
                this.tuNombre.Text = value;
            }
        }

        public bool NombreVisible
        {
            get { return tuNombre.Visible; }
            set { tuNombre.Visible = value; }
        }

        public bool LoginHabilitado
        {
            get { return Login.Visible; }
            set { Login.Visible = value; }
        }
        public bool RegistroHabilitado
        {
            get { return Registro.Visible; }
            set { Registro.Visible = value; }
        }
        public bool SeleccionHabilitado
        {
            get { return Seleccion.Visible; }
            set { Seleccion.Visible = value; }
        }
        public bool CalificacionHabilitado
        {
            get { return Calificaciones.Visible; }
            set { Calificaciones.Visible = value; }
        }
        public bool PublicacionHabilitada
        {
            get { return Publicacion.Visible; }
            set { Publicacion.Visible = value; }
        }
        public bool Rojo1
        {
            get { return panel1.Visible; }
            set { panel1.Visible = value; }
        }
        public bool Rojo2
        {
            get { return panel2.Visible; }
            set { panel2.Visible = value; }
        }

        public string IDreal;
        public string IDestudiantes
        {
            get { return IDreal; }
            set { IDreal = value; }
        }

        
    }
}
