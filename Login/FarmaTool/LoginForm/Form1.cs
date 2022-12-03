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

        /// <summary>
        /// Parametros para el movimiento del login
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

       
        /// <summary>
        /// Metodo para utilizar la clase ClassConnection
        /// </summary>
        public void conectionClass()
        {
            Class ccnn = new Class();
            string user = txtuser.Text, password = txtpassword.Text;
            ccnn.loginlogic(user,password);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcionamiento de boton ACCESS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            conectionClass();
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Efectos de desvanecimiento en el TextBox para el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Efectos de desvanecimiento en el TextBox para la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// Metodo para cerrar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Metodo para minimizar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Metodos para poder mover el form del login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
