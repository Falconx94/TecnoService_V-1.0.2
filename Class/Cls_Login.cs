using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tecnoservice.Class
{
    class Cls_Login
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        bool band;

        public string Log_Usuario { get; set; }
        public string Log_Contraseña { get; set; }

        public bool Read()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LOGIN";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@log_user", Log_Usuario);
            cmd.Parameters.AddWithValue("@log_pass", Log_Contraseña);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al leer los datos =>" + ex);
            }
            con.Close();
            return band;
        }
    }
}
