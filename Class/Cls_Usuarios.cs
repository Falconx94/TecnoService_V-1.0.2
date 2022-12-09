using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Tecnoservice.Class;
namespace Tecnoservice.Class
{
    internal class Cls_Usuarios
    {
        SqlDataReader dr;
        bool band;

        public int us_id { get; set; }
        public string us_nombre {  get; set;} 
        public string us_pass {  get; set;}
        public string us_priapellido {  get; set;}
        public string us_segapellido { get; set;}
        public string us_telefono { get; set;}
        public string us_nivel { get; set;}

        public bool Guardar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Usuario";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@Us_Id", us_id);
            cmd.Parameters.AddWithValue("@Us_Nombre", us_nombre);
            cmd.Parameters.AddWithValue("@Us_pass", us_pass);
            cmd.Parameters.AddWithValue("@Us_Ap_Paterno", us_priapellido);
            cmd.Parameters.AddWithValue("@Us_Ap_Materno", us_segapellido);
            cmd.Parameters.AddWithValue("@Us_Telefono", us_telefono);
            cmd.Parameters.AddWithValue("@Us_Nivel", us_nivel);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band =false;
                MessageBox.Show("Error no se guardaron los datos correctamente =>"+ex);

            }
            con.Close();
            return band;

        }
        public bool Actualizar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "SP_Usuario";
            cmd.Parameters.AddWithValue("@OP",3);
            cmd.Parameters.AddWithValue("@us_Id", us_id);
            cmd.Parameters.AddWithValue("@us_Nombre", us_nombre);
            cmd.Parameters.AddWithValue("@us_Pass", us_pass);
            cmd.Parameters.AddWithValue("@us_AP_Paterno", us_priapellido);
            cmd.Parameters.AddWithValue("@us_AP_Materno", us_segapellido);
            cmd.Parameters.AddWithValue("@us_Telefono", us_telefono);
            cmd.Parameters.AddWithValue("@us_Nivel", us_nivel);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band=true;
            }
            catch(Exception ex)
            {
                band=false;
                MessageBox.Show("Error no se actualizaron los datos correctamente");
            }
            con.Close();
            return band;

        }
        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "SP_Usuario";
            cmd.Parameters.AddWithValue("@OP", 5);
            cmd.Parameters.AddWithValue("@us_Id", us_id);
            cmd.Parameters.AddWithValue("@us_Nombre", us_nombre);
            cmd.Parameters.AddWithValue("@us_Pass", us_pass);
            cmd.Parameters.AddWithValue("us_AP_Paterno", us_priapellido);
            cmd.Parameters.AddWithValue("us_Ap_Materno", us_segapellido);
            cmd.Parameters.AddWithValue("us_Telefono", us_telefono);
            cmd.Parameters.AddWithValue("us_Nivel", us_nivel);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error no se borraron los datos correctamente =>"+ex);
            }
            con.Close ();
            return band;
        }
    }
}
