using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tecnoservice.Class;
using System.Windows.Forms;
namespace Tecnoservice.Class
{
    internal class Cls_Ventas
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        bool band;

        public int vt_id { get; set; }
        public int clt_id { get; set; }
        public double vt_total { get; set; }
        public string us_id { get; set; }
        public DateTime vt_fecha { get; set; }

        
        //public bool pagar()
        //{
        //    SqlConnection con = new SqlConnection(BD_Conex.conectar());
        //    SqlCommand cmd = new SqlCommand("", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "SP_Ventas";

        //    cmd.Parameters.AddWithValue("OP", 1);
        //    cmd.Parameters.AddWithValue("Vt_Id", vt_id);
        //    cmd.Parameters.AddWithValue("Clt_Id", clt_id);
        //    cmd.Parameters.AddWithValue("Vt_Total", vt_total);
        //    cmd.Parameters.AddWithValue("Us_Id", us_id);
        //    cmd.Parameters.AddWithValue("Vt_Fecha", vt_fecha);

        //    try
        //    {
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        band = false;
        //        MessageBox.Show("la venta ha sido completada");
        //    }
        //    catch (Exception ex)
        //    {
        //        band = false;
        //        MessageBox.Show("Error no se guardaron los datos correctamente =>" + ex);

        //    }
        //    con.Close();
        //    return band;
        //}
        public void cargararticulos(DataGridView dgv)
        {
            try
            {
                
                da = new SqlDataAdapter("select * from Venta where Vt_Id ", con);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(dgv.Rows[0].ToString() + dt);
            }
        }
        public bool Buscar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Ventas";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@VT_ID", vt_id);
            try
            {               
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
            }
            con.Close();
            return band;
        }
       // public bool Eliminar()
       // {
            //SqlConnection con = new SqlConnection(BD_Conex.conectar());
            //SqlCommand cmd = new SqlCommand("", con);
            //cmd.CommandType= CommandType.StoredProcedure;
            //cmd.CommandText = "SP_Venta";
            //cmd.Parameters.AddWithValue("@OP", 3);
            //cmd.Parameters.AddWithValue("@Vt_Id", vt_id);
            //try
            //{
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    band = true;
            //    MessageBox.Show("Eliminado con exito");
            //}
            //catch(Exception ex)
            //{
            //    band= false;
            //    MessageBox.Show("No se pudo eiminar la venta");
            //}
            //con.Close();
            //return band;
       // }   
    }
}
