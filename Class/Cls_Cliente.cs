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
    public class Cls_Cliente
    {
        bool band;

        public int Clt_Id { get; set; }
        public string Clt_Nombre { get; set; }
        public string Clt_Ap_Paterno { get; set; }
        public string Clt_Ap_Materno { get; set; }
        public string Clt_Telefono { get; set; }
        public char Clt_Estatus { get; set; }

        public bool Guardar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Clientes";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@clt_Id", Clt_Id);
            cmd.Parameters.AddWithValue("@clt_Nombre", Clt_Nombre);
            cmd.Parameters.AddWithValue("@clt_Ap_Paterno", Clt_Ap_Paterno);
            cmd.Parameters.AddWithValue("@clt_Ap_Materno", Clt_Ap_Materno);
            cmd.Parameters.AddWithValue("@clt_Telefono", Clt_Telefono);
            cmd.Parameters.AddWithValue("@clt_estatus", Clt_Estatus);

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
        public bool Actualizar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Clientes";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@clt_Id", Clt_Id);
            cmd.Parameters.AddWithValue("@clt_Nombre", Clt_Nombre);
            cmd.Parameters.AddWithValue("@clt_Ap_Paterno", Clt_Ap_Paterno);
            cmd.Parameters.AddWithValue("@clt_Ap_Materno", Clt_Ap_Materno);
            cmd.Parameters.AddWithValue("@clt_Telefono", Clt_Telefono);
            cmd.Parameters.AddWithValue("@clt_estatus", Clt_Estatus);
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
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Clientes";
            cmd.Parameters.AddWithValue("@OP", 4);
            cmd.Parameters.AddWithValue("@clt_Id", Clt_Id);

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

