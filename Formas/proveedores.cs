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
    public partial class proveedores : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Proveedores clsprv = new Cls_Proveedores();
        bool band1 = false, band2 = false;
        char estado;
        string Conex;

        private void proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProveedores.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.dsProveedores.Proveedores);
            Actualizar_Datagrid();
            Consecutivo();
        }

        public proveedores()
        {
            InitializeComponent();
            Conex = BD_Conex.conectar();
        }

        public void Actualizar_Datagrid()
        {
            this.proveedoresTableAdapter.Fill(this.dsProveedores.Proveedores);
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Prv_Id),0) + 1 FROM Proveedores", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtIDProveedor.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }

        public void Validar_estado()
        {
            if (band2 == true)
                estado = 'A';
            else
                estado = 'I';
        }

        public void GuardarProveedor()
        {
            if (valida_info())
            {
                Validar_estado();
                clsprv.Prv_Id = Convert.ToInt32(txtIDProveedor.Text);
                clsprv.Prv_Razonsocial = txtRazo.Text;
                clsprv.Prv_Nombre_Contaco = txtNomContac.Text;
                clsprv.Prv_Telefono = txtTelef.Text;
                clsprv.Prv_Direccion = txtDireccion.Text;
                clsprv.Prv_Estatus = estado;
                if (clsprv.Guardar())
                {
                    MessageBox.Show("Datos Guardados Correctamente");
                }
                else
                {
                    MessageBox.Show("Los Datos NO se Guardaron!!");
                }
                con.Close();
                Consecutivo();
                Actualizar_Datagrid();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
            Limpiar();
        }

        public void Limpiar()
        {
            txtIDProveedor.Text = "";
            txtRazo.Text = "";
            txtNomContac.Text = "";
            txtDireccion.Text = "";
            txtTelef.Text = "";
            Consecutivo();
            Actualizar_Datagrid();
        }

        public void Actualizar()
        {
            if (valida_info())
            {
                Validar_estado();
                clsprv.Prv_Id = Convert.ToInt32(txtIDProveedor.Text);
                clsprv.Prv_Razonsocial = txtRazo.Text;
                clsprv.Prv_Nombre_Contaco = txtNomContac.Text;
                clsprv.Prv_Telefono = txtTelef.Text;
                clsprv.Prv_Direccion = txtDireccion.Text;
                clsprv.Prv_Estatus = estado;
                if (clsprv.Actualizar())
                {
                    MessageBox.Show("Datos Guardados exitosamente");
                }
                else
                {
                    MessageBox.Show("Datos no Guardados");
                }
                con.Close();
                Consecutivo();
                Actualizar_Datagrid();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Limpiar();
        }

        private void Radbtn_Activo_Click(object sender, EventArgs e)
        {
            if (Radbtn_Activo.Checked)
            {
                Radbtn_Inactivo.Checked = band1;
                band2 = true;
            }
            else
            {
                Radbtn_Activo.Checked = band1;
                band2 = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
        }

        private void btnEliminarActive_Click(object sender, EventArgs e)
        {
            txtIDProveedor.Enabled = true;
            btnEliminar.Visible = true;
            txtRazo.Enabled = false;
            txtNomContac.Enabled = false;
            txtTelef.Enabled = false;
            txtDireccion.Enabled = false;
        }

        //private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
           
        //}

        public void Eliminar()
        {
            if (valida_info())
            {
                clsprv.Prv_Id = Convert.ToInt32(txtIDProveedor.Text);
                clsprv.Prv_Razonsocial = txtRazo.Text;
                clsprv.Prv_Nombre_Contaco = txtNomContac.Text;
                clsprv.Prv_Telefono = txtTelef.Text;
                clsprv.Prv_Direccion = txtDireccion.Text;
                clsprv.Prv_Estatus = estado;
                if (clsprv.Eliminar())
                {
                    MessageBox.Show("Datos Eliminados");
                }
                else
                {
                    MessageBox.Show("Datos NO ELIMINADOS!!!");
                }
                con.Close();
                Consecutivo();
                Actualizar_Datagrid();
            }
        }

        private void proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            txtIDProveedor.Text = this.dsProveedores.Proveedores[proveedoresBindingSource.Position].Prv_Id.ToString();
            txtRazo.Text = this.dsProveedores.Proveedores[proveedoresBindingSource.Position].Prv_Razonsocial.ToString();
            txtNomContac.Text = this.dsProveedores.Proveedores[proveedoresBindingSource.Position].Prv_Nombre_Contacto.ToString();
            txtTelef.Text = this.dsProveedores.Proveedores[proveedoresBindingSource.Position].Prv_Telefono.ToString();
            txtDireccion.Text = this.dsProveedores.Proveedores[proveedoresBindingSource.Position].Prv_Direccion.ToString();
            char Status = Convert.ToChar(dsProveedores.Proveedores[proveedoresBindingSource.Position].Prv_Estatus);
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

        public bool valida_info()
        {
            if (txtRazo.Text == "" || txtNomContac.Text == "" || txtTelef.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Asegurar que los campos esten LLenos");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }
    }
}
