using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClassConnexion;

namespace FarmaTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Parametros para el movimiento del login
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Metodo para conectar desde la clase ClassConnexion
        public void conectionClass()
        {
            Class ccnn = new Class();
            string user = txtuser.Text, password = txtpassword.Text;
            ccnn.loginlogic(user,password);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton de acceso
        private void button1_Click(object sender, EventArgs e)
        {
            conectionClass();
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {

        }

        //Efectos de desvanecimiento en el TextBox para el usuario
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "example@bjmail.com")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "example@bjmail.com";
                txtuser.ForeColor = Color.DimGray;
            }
        }
        //Efectos de desvanecimiento en el TextBox para la contraseña
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Enter your password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;//Para caracteres ocultos (Password)
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Enter your password";
                txtpassword.ForeColor = Color.DimGray;
                txtpassword.UseSystemPasswordChar = false; //Para caracteres ocultos (Password)
            }
        }
        //Metodo para cerrar el form
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Metodo para minimizar el form
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Metodos para poder mover el form del login
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
