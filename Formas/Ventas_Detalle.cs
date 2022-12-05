using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Tecnoservice.Class;
using System.Windows.Forms;
namespace Tecnoservice.Formas
{
    public partial class Ventas_Detalle : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        Cls_Ventas_Detalle clsvd = new Cls_Ventas_Detalle();
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        SqlDataReader dr;

        bool band;
        string conex;

        public Ventas_Detalle()
        {
            InitializeComponent();
            conex=BD_Conex.conectar();
        }

        private void Ventas_Detalle_Load(object sender, EventArgs e)
        {
            Actualizar_DataGrid();
        }
        public void Actualizar_DataGrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDETVENT_Cholo.Detalles_Venta' Puede moverla o quitarla según sea necesario.
            this.detalles_VentaTableAdapter.Fill(this.dsDETVENT_Cholo.Detalles_Venta);
        }
        
         public void buscar()
        {
            try
            {
                con.Open();
                string consulta = "select * from Detalles_venta where Vt_Id=" + txtventa.Text + "";
                da = new SqlDataAdapter(consulta, con);
                dt = new DataTable();
                da.Fill(dt);
                dtgventas.DataSource = dt;
                SqlCommand cmd = new SqlCommand(consulta, con);
                dr = cmd.ExecuteReader();
                
                con.Close();
                band = true;
            }
            catch
            {
                MessageBox.Show("No se encontraron datos");
                band = false;
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            buscar();
        }

        private void dtgventas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void txtventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                buscar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenargrid();
        }
        public void llenargrid()
        {
            con.Open();
            string consulta = "select * from Detalles_venta";
            da = new SqlDataAdapter(consulta, con);
            dt = new DataTable();
            da.Fill(dt);
            dtgventas.DataSource = dt;
            SqlCommand cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();

            con.Close();
            band = true;
        }
            
    }
}
