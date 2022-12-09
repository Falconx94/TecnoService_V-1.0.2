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
    internal class Cls_Ventas_Detalle
    {
		SqlConnection con = new SqlConnection(BD_Conex.conectar());
		SqlDataAdapter da;
		DataTable dt;
		bool band;

        public int Vt_Id { get; set; }
		public int Prod_Id { get; set; }
		public int us_id { get; set; }
		public int DetVent_Unidades { get; set; }
		public string DetVent_PrecioUnidad { get; set; }
		public DateTime DetVent_Fecha { get; set; }

		public void Carcardatagrid(DataGridView dgv)
        {
			try
			{

				da = new SqlDataAdapter("select * from Detalles_Venta where Vt_Id ", con);
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
			cmd.CommandText = ("Sp_VentasDetalle");

			cmd.Parameters.AddWithValue("@OP",1);
			cmd.Parameters.AddWithValue("@VT_ID", Vt_Id);
			//cmd.Parameters.AddWithValue("PROD_ID",Prod_Id);
			//cmd.Parameters.AddWithValue("US_ID", us_id);
			//cmd.Parameters.AddWithValue("detvent_unidades",DetVent_Unidades);
			//cmd.Parameters.AddWithValue("detvent_preciounidad",DetVent_PrecioUnidad);
			//cmd.Parameters.AddWithValue("detvent_fecha", DetVent_Fecha);
			
			try
            {
				con.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Busqueda con exito");
				band = true;
			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message,"Datos no encontrados");
				band = false;
            }
			con.Close();
			return band;
			

        }

    }
	
}
