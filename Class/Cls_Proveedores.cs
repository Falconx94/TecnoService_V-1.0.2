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
    class Cls_Proveedores
    {
        //BD_Conex scon = new BD_Conex();
        //SqlDataReader dr;
        bool band;

        public int Prv_Id { get; set; }
        public string Prv_Razonsocial { get; set; }
        public string Prv_Nombre_Contaco { get; set; }
        public string Prv_Telefono { get; set; }
        public string Prv_Direccion { get; set; }
        public char Prv_Estatus { get; set; }

        public bool Guardar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Proveedores";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@Prov_RasSoci", Prv_Razonsocial);
            cmd.Parameters.AddWithValue("@Prov_NomContac", Prv_Nombre_Contaco);
            cmd.Parameters.AddWithValue("@Prov_Telefono", Prv_Telefono);
            cmd.Parameters.AddWithValue("@Prov_Direccion", Prv_Direccion);
            cmd.Parameters.AddWithValue("@Prov_estatus", Prv_Estatus);

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

        public bool Actualizar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Proveedores";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@Prov_RasSoci", Prv_Razonsocial);
            cmd.Parameters.AddWithValue("@Prov_NomContac", Prv_Nombre_Contaco);
            cmd.Parameters.AddWithValue("@Prov_Telefono", Prv_Telefono);
            cmd.Parameters.AddWithValue("@Prov_Direccion", Prv_Direccion);
            cmd.Parameters.AddWithValue("@Prov_estatus", Prv_Estatus);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al actualizar datos" + ex);
            }
            con.Close();
            return band;

        }

        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Proveedores";
            cmd.Parameters.AddWithValue("@OP", 5);
            cmd.Parameters.AddWithValue("@Prov_Id",Prv_Id);
            cmd.Parameters.AddWithValue("@Prov_RasSoci", Prv_Razonsocial);
            cmd.Parameters.AddWithValue("@Prov_NomContac", Prv_Nombre_Contaco);
            cmd.Parameters.AddWithValue("@Prov_Telefono", Prv_Telefono);
            cmd.Parameters.AddWithValue("@Prov_Direccion", Prv_Direccion);
            cmd.Parameters.AddWithValue("@Prov_estatus", Prv_Estatus);

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
