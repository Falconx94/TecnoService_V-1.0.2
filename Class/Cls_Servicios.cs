using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tecnoservice.Class
{
    internal class Cls_Servicios
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        bool band;

        public int Srv_ID { get; set; }
        public int SrvClt_Id { get; set; }
        public int Srv_type { get; set; }
        public double Srv_Precio { get; set; }
        public string Srv_Descripción { get; set; }
        public DateTime Srv_Fecha { get; set; }
        public char Srv_Estado { get; set; }

        
        public bool Guardar()
        {
            cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Servicios";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@srv_Id", Srv_ID);
            cmd.Parameters.AddWithValue("@srv_cltID", SrvClt_Id);
            cmd.Parameters.AddWithValue("@srv_tipo", Srv_type);
            cmd.Parameters.AddWithValue("@srv_precio", Srv_Precio);
            cmd.Parameters.AddWithValue("@srv_descrip", Srv_Descripción);
            cmd.Parameters.AddWithValue("@srv_Fecha", Srv_Fecha);
            cmd.Parameters.AddWithValue("@srv_estatus", Srv_Estado);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al guardar los datos =>" + ex);
            }
            con.Close();
            return band;
        }
        public bool Eliminar()
        {
            cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Servicios";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@srv_Id", Srv_ID);
            cmd.Parameters.AddWithValue("@srv_cltID", SrvClt_Id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al borrar los datos =>" + ex);
            }
            con.Close();
            return band;
        }
    }
}
