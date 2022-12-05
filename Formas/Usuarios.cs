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
    public partial class Usuarios : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Usuarios clsus = new Cls_Usuarios();
        bool band1 = false;
        string Conex;
        public Usuarios()
        {
            InitializeComponent();
            Conex = BD_Conex.conectar();

        }
        public void llenardatawrid()
        {
            this.usuarioTableAdapter.Fill(this.dsUsuarioclass.Usuario);

        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsUsuarioclass.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dsUsuarioclass.Usuario);
            Consecutivo();
            txtid.Focus();
        }
        public void Guardar_usuario()
        {
           try
            {
                clsus.us_id = Convert.ToInt32(txtid.Text);
                clsus.us_nombre = txtnombre.Text;
                clsus.us_pass = txtpassword.Text;
                clsus.us_priapellido = txtpriapellido.Text;
                clsus.us_segapellido = txtsegapellido.Text;
                clsus.us_telefono = txttelefono.Text;
                clsus.us_nivel = txtnivel.Text;
                if (clsus.Guardar())
                {
                    MessageBox.Show("Los datos se guardaron correctamente");
                }
                else
                {
                    MessageBox.Show("Error los datos no se guardaron correctamene");
                }
                this.usuarioTableAdapter.Fill(this.dsUsuarioclass.Usuario);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,"ERROR");
            }
            Llenargrid();
            con.Close();

        }
        public void Actualizar_usuario()
        {
            clsus.us_id = Convert.ToInt32(txtid.Text);  
            clsus.us_nombre = txtnombre.Text;   
            clsus.us_pass=txtpassword.Text;
            clsus.us_priapellido = txtpriapellido.Text;
            clsus.us_segapellido = txtsegapellido.Text;
            clsus.us_telefono = txttelefono.Text;
            clsus.us_nivel = txtnivel.Text;
            if(clsus.Actualizar())
            {
                MessageBox.Show("Los datos se guardaron correctamente");
                llenardatawrid();
            }
            else
            {
                MessageBox.Show("Error Los datos no se guardaron correctamente");
            }
            con.Close();
            Llenargrid();
            Limpiar_campos();
            Consecutivo();
        }
        public void Eliminar_usuario()
        {
            try
            {
            clsus.us_id=Convert.ToInt32(txtid.Text);
            clsus.us_nombre=txtnombre.Text;
            clsus.us_pass= txtpassword.Text;
            clsus.us_priapellido= txtpriapellido.Text;
            clsus.us_segapellido= txtsegapellido.Text;
            clsus.us_telefono= txttelefono.Text;

            if(clsus.Eliminar())
            {
                MessageBox.Show("Los datos se eliminaron correctamente");
                
            }
            else
            {
                MessageBox.Show("Error los datos no se eliminaron correctamente");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            Llenargrid();
            Limpiar_campos();
            Consecutivo();
        }
        public void Limpiar_campos()
        {
            //txtid.Text = "";
            //txtnombre.Text = "";
            //txtpassword.Text = "";
            //txtpriapellido.Text = "";
            //txtsegapellido.Text = "";
            //txttelefono.Text = "";
            //txtnivel.Text = "";
            //Consecutivo();
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            Llenargrid();
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("select isnull(MAX(Us_Id),0)+1 From Usuario",con);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txtid.Text=Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncapturar_Click(object sender, EventArgs e)
        {
            Guardar_usuario();
            Limpiar_campos();
           
                
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
           Actualizar_usuario();
            Limpiar_campos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar_usuario();
            Limpiar_campos();
            llenardatawrid();
            Llenargrid();
        }
        public void Llenargrid()
        {
            con.Open();
            string consulta = "select * from Usuario ";
            da = new SqlDataAdapter(consulta, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();

            con.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_Id.ToString();
            txtnombre.Text = this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_Nombre.ToString();
            txtpassword.Text=this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_pass.ToString();
            txtpriapellido.Text=this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_Ap_Paterno.ToString();
            txtsegapellido.Text=this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_Ap_Materno.ToString();
            txttelefono.Text=this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_Telefono.ToString();
            txtnivel.Text=this.dsUsuarioclass.Usuario[usuarioBindingSource.Position].Us_Nivel.ToString();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
        DataTable dt;
        SqlDataAdapter da;
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)13)
            {
                try
                {
                    con.Open();
                    string consulta = "select * from Usuario where Us_Id =" + txtid.Text + "";
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
        }

        private void txtlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_campos();
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                try
                {
                    con.Open();
                    string consulta = "select * from Usuario where Us_Id =" + txtbuscar.Text + "";
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
        }
    }
}
