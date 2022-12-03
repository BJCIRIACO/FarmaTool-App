using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTool
{
    public partial class Splash : Form
    {
        public Splash()
        {
            
            InitializeComponent();
            ///Metodo para cerrar el form
            Tiempo.Enabled = true;
             Tiempo.Interval = 2000;
        }
        /// <summary>
        /// //Metodo tiempo para cerrar el splash cuando se cumple la condicional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
