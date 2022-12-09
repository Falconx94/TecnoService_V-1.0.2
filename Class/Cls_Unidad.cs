using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Tecnoservice.Class;
using System.Windows.Forms;
namespace Tecnoservice.Class
{
    
    internal class Cls_Unidad
    {
        //SqlConnection con = new SqlConnection(BD_Conex.conectar());

        public int unit_id { get; set; }
        public String unit_descripcion { get; set; }
        public int unit_unidad { get; set; }

        public bool Guardar()
        {
            bool band;
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Unidad";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@Unit_Id",unit_id);
            cmd.Parameters.AddWithValue("@Unit_Descripcion",unit_descripcion);
            cmd.Parameters.AddWithValue("@Unit_Cantidad", unit_unidad);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
                
            }
            catch 
            {
                MessageBox.Show("Datos no guardados");
                band = false;
            }
            con.Close();
            return band;
        }

        public bool Actualizar()
        {
            bool band;
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Unidad";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@Unit_Id",unit_id);
            cmd.Parameters.AddWithValue("@Unit_Descripcion", unit_descripcion);
            cmd.Parameters.AddWithValue("@Unit_Cantidad", unit_unidad);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados");
                band=true;
            }
            catch
            {
                MessageBox.Show("Datos no actualizados");
                band=(false);
            }
            return band;
            con.Close();

        }
        public bool Eliminar()
        {
            bool band;
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Unidad";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@Unit_Id", unit_id);
            cmd.Parameters.AddWithValue("@Unit_Descripcion", unit_descripcion);
            cmd.Parameters.AddWithValue("@Unit_Cantidad", unit_unidad);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery ();
                MessageBox.Show("Datos eliminados");
                band = true;
            }
            catch
            {
                MessageBox.Show("Datos no eliminados");
                band =false;
            }
            con.Close();
            return band;
        }
       
    }
}
