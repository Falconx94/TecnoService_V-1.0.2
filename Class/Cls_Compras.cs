using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tecnoservice.Class;
namespace Tecnoservice.Class
{
    class Cls_Compras
    {
        bool band;
        public int Com_Id { get; set; }
        public int Prv_Id { get; set; }
        public string Com_Total { get; set; }
        public DataSetDateTime Com_Fecha { get; set; }

        public bool Guardar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Compras";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@Comp_Id", Com_Id);
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@com_Total", Com_Total);
            cmd.Parameters.AddWithValue("@Comp_Fecha", Com_Fecha);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error datos no Guardados" + ex);
            }
            con.Close();
            return band;
        }

        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Compras";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@Comp_Id", Com_Id);
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@com_Total", Com_Total);
            cmd.Parameters.AddWithValue("@Comp_Fecha", Com_Fecha);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error datos no eliminadops" + ex);
            }
            con.Close();
            return band;
        }
    }
}
