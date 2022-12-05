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
    class Cls_Detalle_Compra
    {
        bool band;

        public int DetCom_Id { get; set; }
        public int Com_Id { get; set; }
        public int Prod_Id { get; set; }
        public int Prv_Id { get; set; }
        public string DetCom_Observacion { get; set; }
        public int DetCom_Unidad { get; set; }
        public float DetCom_Precio { get; set; }
        public int DetCom_Cantidad { get; set; }
        public float Det_Importe { get; set; }
        public char DetCom_Estatus { get; set; }

        public bool Guardar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Detalle_Compra";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@DeCom_Id",DetCom_Id);
            cmd.Parameters.AddWithValue("@Produc_Id", Prod_Id);
            cmd.Parameters.AddWithValue("@Comp_ID",Com_Id );
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@DeCom_Obsersacion", DetCom_Observacion);
            cmd.Parameters.AddWithValue("@DeCom_Unidad",DetCom_Unidad );
            cmd.Parameters.AddWithValue("@DeCom_Precio", DetCom_Precio);
            cmd.Parameters.AddWithValue("@DeCom_Cantidad", DetCom_Cantidad);
            cmd.Parameters.AddWithValue("@DeCom_Importe",Det_Importe );
            cmd.Parameters.AddWithValue("@DeCom_Estatus",DetCom_Estatus );
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

        public bool Actualizar ()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Detalle_Compra";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@DeCom_Id", DetCom_Id);
            cmd.Parameters.AddWithValue("@Produc_Id", Prod_Id);
            cmd.Parameters.AddWithValue("@Comp_ID", Com_Id);
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@DeCom_Obsersacion", DetCom_Observacion);
            cmd.Parameters.AddWithValue("@DeCom_Unidad", DetCom_Unidad);
            cmd.Parameters.AddWithValue("@DeCom_Precio", DetCom_Precio);
            cmd.Parameters.AddWithValue("@DeCom_Cantidad", DetCom_Cantidad);
            cmd.Parameters.AddWithValue("@DeCom_Importe", Det_Importe);
            cmd.Parameters.AddWithValue("@DeCom_Estatus", DetCom_Estatus);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error datos no Actualizados" + ex);
            }
            con.Close();
            return band;
        }

        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Detalle_Compra";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@DeCom_Id", DetCom_Id);
            cmd.Parameters.AddWithValue("@Produc_Id", Prod_Id);
            cmd.Parameters.AddWithValue("@Comp_ID", Com_Id);
            cmd.Parameters.AddWithValue("@Prov_Id", Prv_Id);
            cmd.Parameters.AddWithValue("@DeCom_Obsersacion", DetCom_Observacion);
            cmd.Parameters.AddWithValue("@DeCom_Unidad", DetCom_Unidad);
            cmd.Parameters.AddWithValue("@DeCom_Precio", DetCom_Precio);
            cmd.Parameters.AddWithValue("@DeCom_Cantidad", DetCom_Cantidad);
            cmd.Parameters.AddWithValue("@DeCom_Importe", Det_Importe);
            cmd.Parameters.AddWithValue("@DeCom_Estatus", DetCom_Estatus);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error datos no Eliminados" + ex);
            }
            con.Close();
            return band;
        }

    }
}
