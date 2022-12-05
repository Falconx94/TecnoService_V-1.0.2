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
namespace Tecnoservice.Formas
{
    public partial class Ventas : Form
    {
       // DataTable contexto = new DataTable();
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Ventas clsvt = new Cls_Ventas();
        bool band1 = false;
        string Conex;
        public Ventas()
        {
            InitializeComponent();
           
        }
        
        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecnoServiceDataSet1.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.tecnoServiceDataSet1.Ventas);
            cargararticulos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // contexto.DefaultView.RowFilter =  txtarticulo.Text; 
        
        
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
                     
        }
        public void Buscar_Articulo()
            
        {
            try
            {
                con.Open();
                string consulta = "select * from ventas where Vt_id=" + txtarticulo.Text + "";
                da = new SqlDataAdapter(consulta, con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand cmd = new SqlCommand(consulta, con);
                dr = cmd.ExecuteReader();

                con.Close();
            }
            catch
            {
                MessageBox.Show("No se encontraron datos");
            }

        }
        SqlDataAdapter da;
        DataTable dt;
        public void cargararticulos()
        {

            con.Open();
            string consulta = "select * from Ventas";
            da = new SqlDataAdapter(consulta, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();

            con.Close();
            
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar_Articulo();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ventasTableAdapter.Fill(this.tecnoServiceDataSet1.Ventas);

        }

        private void btnbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtarticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Buscar_Articulo();
            }
        }
    }
}
