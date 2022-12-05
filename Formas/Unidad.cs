using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Tecnoservice.Class;

namespace Tecnoservice.Formas
{
    public partial class Unidad : Form
    {
        Cls_Unidad clsuni = new Cls_Unidad();
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        

        public Unidad()
        {
            InitializeComponent();
        }

        private void Unidad_Load(object sender, EventArgs e)
        {
            Consecutivo();
            // TODO: esta línea de código carga datos en la tabla 'tecnoServiceDataSet5.Unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.tecnoServiceDataSet5.Unidad);

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            con.Open();
            clsuni.unit_id = Convert.ToInt32(txtcodigo.Text);
            clsuni.unit_descripcion = txtcodigo.Text;
            clsuni.unit_unidad=Convert.ToInt32(txtunidad.Text);
            
            if(clsuni.Guardar())
            {
                MessageBox.Show("Datos guardados");
            }
            else
            {
                MessageBox.Show("Datos no guardados");
            }
            con.Close();
            Eliminar_campos();
            this.unidadTableAdapter.Fill(this.tecnoServiceDataSet5.Unidad);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            con.Open();
            clsuni.unit_id = Convert.ToInt32(txtcodigo.Text);
            clsuni.unit_descripcion=txtdescripcion.Text;
            clsuni.unit_unidad = Convert.ToInt32(txtunidad.Text);
            if(clsuni.Actualizar())
            {
                MessageBox.Show("Datos actualizado");
            }
            else
            {
                MessageBox.Show("Datos no actualizado");
            }
            Eliminar_campos();
            con.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            clsuni.unit_id=Convert.ToInt32(txtcodigo.Text);
            clsuni.unit_descripcion=txtdescripcion.Text;
            clsuni.unit_unidad=Convert.ToInt32(txtunidad.Text);
            if(clsuni.Eliminar())
            {
                MessageBox.Show("Datos eliminados");
            }
            else
            {
                MessageBox.Show("Error Datos no eliminados");
            }
            con.Close();
            Eliminar_campos();
        }
        public void Consecutivo()
        {
            con.Open();
            cmd = new SqlCommand("SELECT ISNULL(MAX(Unit_Id),0) + 1 FROM Unidad", con);
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               txtcodigo.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
        public void Eliminar_campos()
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtunidad.Text = "";
            Consecutivo();
            Llenargrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtID.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Id.ToString();
           
        }

        private void txtunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                con.Open();
                clsuni.unit_id = Convert.ToInt32(txtcodigo.Text);
                clsuni.unit_descripcion = txtcodigo.Text;
                clsuni.unit_unidad = Convert.ToInt32(txtunidad.Text);

                if (clsuni.Guardar())
                {
                    MessageBox.Show("Datos guardados");
                }
                else
                {
                    MessageBox.Show("Datos no guardados");
                }
                con.Close();
                Eliminar_campos();
                Llenargrid();
            }
            this.unidadTableAdapter.Fill(this.tecnoServiceDataSet5.Unidad);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        DataTable dt;
        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar ==(char)13)
            {
                try
                {
                    con.Open();
                    string consulta = "select * from Unidad where Unit_Id =" + txtbuscar.Text + "";
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
                    MessageBox.Show("No existe datos"+txtbuscar+"");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = this.tecnoServiceDataSet5.Unidad[unidadBindingSource.Position].Unit_Id.ToString();
            txtdescripcion.Text = this.tecnoServiceDataSet5.Unidad[unidadBindingSource.Position].Unit_Descripcion.ToString();
            txtunidad.Text = this.tecnoServiceDataSet5.Unidad[unidadBindingSource.Position].Unit_Cantidad.ToString();

           
        }
        public void Llenargrid()
        {
            con.Open();
            string consulta = "select * from Unidad ";
            da = new SqlDataAdapter(consulta, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();

            con.Close();
        }

        private void Unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar ==(char)Keys.Escape)
            //{
            //    Llenargrid();
            //    Eliminar_campos();
            //    txtcodigo.Focus();
            //    Consecutivo();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Llenargrid();
            Eliminar_campos();
            txtcodigo.Focus();
            Consecutivo();
        }
    }
}
