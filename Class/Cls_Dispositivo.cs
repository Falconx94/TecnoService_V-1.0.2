using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Tecnoservice.Class
{
    internal class Cls_Dispositivo
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        bool band;
        public int Dis_Id { get; set; }
        public int Dis_CltId { get; set; }
        public string Dis_Marca { get; set; }
        public string Dis_Modelo { get; set; }
        public string Dis_Imei { get; set; }
        public string Dis_Detalles { get; set; }
        public char Dis_Estado { get; set; }

        public bool Guardar()
        {
            cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Dispositivos";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@dis_Id", Dis_Id);
            cmd.Parameters.AddWithValue("@dis_CltID",Dis_CltId);
            cmd.Parameters.AddWithValue("@dis_Marca",Dis_Marca);
            cmd.Parameters.AddWithValue("@dis_Modelo",Dis_Modelo);
            cmd.Parameters.AddWithValue("@dis_IMEI",Dis_Imei);
            cmd.Parameters.AddWithValue("@dis_Problema",Dis_Detalles);
            cmd.Parameters.AddWithValue("@dis_Estado", Dis_Estado);

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
            cmd.CommandText = "SP_Dispositivos";

            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@dis_Id", Dis_Id);
            cmd.Parameters.AddWithValue("@dis_CltID", Dis_CltId);
            cmd.Parameters.AddWithValue("@dis_Marca", Dis_Marca);
            cmd.Parameters.AddWithValue("@dis_Modelo", Dis_Modelo);
            cmd.Parameters.AddWithValue("@dis_IMEI", Dis_Imei);
            cmd.Parameters.AddWithValue("@dis_Problema", Dis_Detalles);
            cmd.Parameters.AddWithValue("@dis_Estado", Dis_Estado);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al eliminar los datos =>" + ex);
            }
            con.Close();

            return band;
        }
    }
}
