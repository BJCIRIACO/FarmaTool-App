using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace ClassConnexion
{
    public class Class
    {   /// <summary>
    /// Logica del login 
    /// </summary>
    /// <param name="user"></param>
    /// <param name="password"></param>
        public void loginlogic(string user, string password)
        {
            try
            {
                //String para la conexion desde el xml
                string conexion = ConfigurationManager.ConnectionStrings["nexo"].ConnectionString;

                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    cnn.Open();
                    // string consulta creada para validacion de usuario
                    string consulta = "Select LoginName, Password FROM usuarios WHERE LoginName='" + user + "' AND Password='" + password + "'";

                    using (SqlCommand cnst = new SqlCommand(consulta, cnn))
                    {
                        SqlDataReader datRead = cnst.ExecuteReader();

                        //Condicional para monstrar por pantalla validacion si los datos de se encuentran en la base de datos
                        if (datRead.Read())
                        {
                            MessageBox.Show("Ha entrado exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("Datos invalidos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
