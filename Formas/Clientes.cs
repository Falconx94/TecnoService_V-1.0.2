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
using Tecnoservice.Class;


namespace Tecnoservice.Formas
{
    public partial class Clientes : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Cliente clsclt = new Cls_Cliente();
        //Dispositivo dispo = new Dispositivo();
        bool band1 = false, band2 = false;
        char estado;
        string Conex,query;

        public Clientes()
        {
            InitializeComponent();
            Conex = BD_Conex.conectar();
            //ClientesTableAdapter.Connection.ConnectionString = Conex;
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            Actualiza_Datagrid();
            Consecutivo();
        }
        public void Actualiza_Datagrid()
        {
            //this.clientesTableAdapter1.Fill(this.dsClientesOros.Clientes);
            this.clientesTableAdapter.Fill(this.dsClientes.Clientes);
        }
        public void Set_Data()
        {
            clsclt.Clt_Id = Convert.ToInt32(txtID.Text);
            clsclt.Clt_Nombre = txtNombre.Text;
            clsclt.Clt_Ap_Paterno = txtAp_Paterno.Text;
            clsclt.Clt_Ap_Materno = txtAp_Materno.Text;
            clsclt.Clt_Telefono = txtTelefono.Text;
            clsclt.Clt_Estatus = estado;
        }
        public void GuardarCliente()
        {
            Set_Data();
            if (valida_info())
            {
                Valida_estado();
                
                if (clsclt.Guardar())
                {
                    MessageBox.Show("Datos guardados exitosamente");
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron");
                }
                con.Close();
                Consecutivo();
                Actualiza_Datagrid();
            }
        }
        public void Actualizar()
        {
            if (valida_info())
            {
                Valida_estado();
                //MANDA A LLAMAR A LA CLASE Cls_Cliente PARA GUARDAR 
                clsclt.Clt_Id = Convert.ToInt32(txtID.Text);
                clsclt.Clt_Nombre = txtNombre.Text;
                clsclt.Clt_Ap_Paterno = txtAp_Paterno.Text;
                clsclt.Clt_Ap_Materno = txtAp_Materno.Text;
                clsclt.Clt_Telefono = txtTelefono.Text;
                clsclt.Clt_Estatus = estado;
                if (clsclt.Actualizar())
                {
                    MessageBox.Show("Datos guardados exitosamente");
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron");
                }
                con.Close();
                Consecutivo();
                Actualiza_Datagrid();
            }
        }
        public void Eliminar()
        {
            Set_Data();
            if (valida_info())
            {
                if (comparayelimina_servicio())
                {
                    if (comparayelimina_dispositivo())
                    {
                        if (comparayelimina_abonos())
                        {
                            if (comparayelimina_ventas())
                            {
                                if (clsclt.Eliminar())
                                {
                                    MessageBox.Show("Datos eliminados exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show("Los datos no se eliminaron");
                                }
                            }
                        }
                    }
                }
                con.Close();
                Consecutivo();
            }
            Actualiza_Datagrid();
        }
        public bool comparayelimina_ventas()
        {
            query = "Select Clt_id from Ventas where Clt_id = " + clsclt.Clt_Id;
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    con.Close();
                    query = "Delete from Ventas where Clt_Id =" + clsclt.Clt_Id;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    band2 = true;
                }
                catch (Exception ex)
                {
                    band2 = false;
                    MessageBox.Show("Error al borrar los datos =>" + ex);
                }
            }
            con.Close();
            return band1;
        }
        public bool comparayelimina_abonos()
        {
            query = "Select Clt_id from Abonos where Clt_id = " + clsclt.Clt_Id;
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    con.Close();
                    query = "Delete from Abonos where Clt_Id =" + clsclt.Clt_Id;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    band2 = true;
                }
                catch (Exception ex)
                {
                    band2 = false;
                    MessageBox.Show("Error al borrar los datos =>" + ex);
                }
            }
            con.Close();
            return band1;
        }
        public bool comparayelimina_dispositivo()
        {
            query = "Select Clt_id from Dispositivo where Clt_id = " + clsclt.Clt_Id;
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    con.Close();
                    query = "Delete from Dispositivo where Clt_Id =" + clsclt.Clt_Id;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    band2 = true;
                }
                catch (Exception ex)
                {
                    band2 = false;
                    MessageBox.Show("Error al borrar los datos =>" + ex);
                }
            }
            con.Close();
            return band1;
        }
        public bool comparayelimina_servicio()
        {
            query = "Select Clt_id from Servicio where Clt_id = "+clsclt.Clt_Id;
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                { 
                    con.Close();
                    query = "Delete from Servicio where Clt_Id =" + clsclt.Clt_Id;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    band2 = true;
                }
                catch (Exception ex)
                {
                    band2 = false;
                    MessageBox.Show("Error al borrar los datos =>" + ex);
                }
            }
            con.Close();
            return band2;
        }
        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtAp_Paterno.Text = "";
            txtAp_Materno.Text = "";
            txtTelefono.Text = "";
            Consecutivo();
            Actualiza_Datagrid();
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Clt_Id),0) + 1 FROM Clientes", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
        public void Valida_estado()
        {
            if (band2 == true)
                estado = 'A';
            else
                estado = 'I';
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Armar();
            GuardarCliente();
            Limpiar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Armar();
            Actualizar();
            Limpiar();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Id.ToString();
            txtNombre.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Nombre.ToString();
            txtAp_Paterno.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Ap_Paterno.ToString();
            txtAp_Materno.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Ap_Materno.ToString();
            txtTelefono.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Telefono.ToString();
            char Status = Convert.ToChar(dsClientes.Clientes[clientesBindingSource.Position].Clt_Estatus);
            switch (Status)
            {
                case 'A':
                    Radbtn_Activo.Checked = true;
                    break;
                case 'I':
                    Radbtn_Inactivo.Checked = true;
                    break;
                default:
                    Radbtn_Activo.Checked = false;
                    Radbtn_Inactivo.Checked = false;
                    break;
            }
        }
        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }
        private void Radbtn_Activo_Click(object sender, EventArgs e)
        {
            if (Radbtn_Activo.Checked == true) band2 = true;
            else band2 = false;

        }
        public bool valida_info()
        {
            if (txtNombre.Text == "" || txtAp_Paterno.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Verificar que los datos esten llenos");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }
        private void btnDeleteActive_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtNombre.Enabled = false;
            txtAp_Paterno.Enabled = false;
            txtAp_Materno.Enabled = false;
            txtTelefono.Enabled = false;
            Eliminar();
            Armar();
            Limpiar();
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        public void Armar()
        {
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtAp_Paterno.Enabled = true;
            txtAp_Materno.Enabled = true;
            txtTelefono.Enabled = true;
        }
    }
}