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
    public partial class Detalle_Compra : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Detalle_Compra clsDetCom = new Cls_Detalle_Compra();
        bool band1 = false, band2 = false;
        char estado;
        string Conex;

        public Detalle_Compra()
        {
            InitializeComponent();
            Conex = BD_Conex.conectar();
        }

        private void Detalle_Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDetalleCompra.Detalles_Compra' Puede moverla o quitarla según sea necesario.
            this.detalles_CompraTableAdapter.Fill(this.dsDetalleCompra.Detalles_Compra);
            Actualizar_Datagrid();
            Consecutivo();

        }
        public void Actualizar_Datagrid()
        {
            this.detalles_CompraTableAdapter.Fill(dsDetalleCompra.Detalles_Compra);
        }

        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(DetCom_Id),0) + 1 FROM Detalles_Compra", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtDetComID.Text = Convert.ToString(dr.GetInt32(0));
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

        public void GuardarDetalleCom()
        {
            if (valida_info())
            {
                Validar_estado();
                clsDetCom.DetCom_Id = Convert.ToInt32(txtDetComID.Text);
                clsDetCom.Com_Id = Convert.ToInt32(txtcompraID.Text);
                clsDetCom.Prod_Id = Convert.ToInt32(txtproducID.Text);
                clsDetCom.Prv_Id = Convert.ToInt32(txtIDProveedor.Text);
                clsDetCom.DetCom_Observacion = txtObservacion.Text;
                clsDetCom.DetCom_Unidad = Convert.ToInt32(txtUnidad.Text);
                clsDetCom.DetCom_Precio = Convert.ToInt32(txtPrecio.Text);
                clsDetCom.DetCom_Cantidad = Convert.ToInt32(txtCantidad.Text);
                clsDetCom.Det_Importe = Convert.ToInt32(txtImporte.Text);
                clsDetCom.DetCom_Estatus = estado;
                if (clsDetCom.Guardar())
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

        public void Eliminar()
        {
            if (valida_info())
            {
                Validar_estado();
                clsDetCom.DetCom_Id = Convert.ToInt32(txtDetComID.Text);
                clsDetCom.Com_Id = Convert.ToInt32(txtcompraID.Text);
                clsDetCom.Prod_Id = Convert.ToInt32(txtproducID.Text);
                clsDetCom.Prv_Id = Convert.ToInt32(txtIDProveedor.Text);
                clsDetCom.DetCom_Observacion = txtObservacion.Text;
                clsDetCom.DetCom_Unidad = Convert.ToInt32(txtUnidad.Text);
                clsDetCom.DetCom_Precio = Convert.ToInt32(txtPrecio.Text);
                clsDetCom.DetCom_Cantidad = Convert.ToInt32(txtCantidad.Text);
                clsDetCom.Det_Importe = Convert.ToInt32(txtImporte.Text);
                clsDetCom.DetCom_Estatus = estado;
                if (clsDetCom.Eliminar())
                {
                    MessageBox.Show("Datos Eliminados Correctamente");
                }
                else
                {
                    MessageBox.Show("Los Datos NO se Eliminaron!!");
                }
                con.Close();
                Consecutivo();
                Actualizar_Datagrid();
            }
        }

        public void Actualizar()
        {
            if (valida_info())
            {
                Validar_estado();
                clsDetCom.DetCom_Id = Convert.ToInt32(txtDetComID.Text);
                clsDetCom.Com_Id = Convert.ToInt32(txtcompraID.Text);
                clsDetCom.Prod_Id = Convert.ToInt32(txtproducID.Text);
                clsDetCom.Prv_Id = Convert.ToInt32(txtIDProveedor.Text);
                clsDetCom.DetCom_Observacion = txtObservacion.Text;
                clsDetCom.DetCom_Unidad = Convert.ToInt32(txtUnidad.Text);
                clsDetCom.DetCom_Precio = Convert.ToInt32(txtPrecio.Text);
                clsDetCom.DetCom_Cantidad = Convert.ToInt32(txtCantidad.Text);
                clsDetCom.Det_Importe = Convert.ToInt32(txtImporte.Text);
                clsDetCom.DetCom_Estatus = estado;
                if (clsDetCom.Actualizar())
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

        private void Detalle_Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetComID.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].DetCom_Id.ToString();
            txtcompraID.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].Com_Id.ToString();
            txtproducID.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].Prod_Id.ToString();
            txtIDProveedor.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].Prv_Id.ToString();
            txtObservacion.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].DetCom_Observacion.ToString();
            txtUnidad.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].DetCom_Unidad.ToString();
            txtPrecio.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].DetCom_Precio.ToString();
            txtCantidad.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].DetCom_Cantidad.ToString();
            txtImporte.Text = this.dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].Det_importe.ToString();
            char Status = Convert.ToChar(dsDetalleCompra.Detalles_Compra[detallesCompraBindingSource.Position].DetCom_Estatus);
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
            if (txtcompraID.Text == "" || txtproducID.Text == "" || txtIDProveedor.Text == "" || txtObservacion.Text == "" || txtUnidad.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "" || txtImporte.Text == "")
            {
                MessageBox.Show("Asegurar que los campos esten LLenos");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }

        public void Limpiar()
        {
            txtDetComID.Text = "";
            txtcompraID.Text = "";
            txtproducID.Text = "";
            txtIDProveedor.Text = "";
            txtObservacion.Text = "";
            txtUnidad.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtImporte.Text = "";
            Consecutivo();
            Actualizar_Datagrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDetalleCom();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
        }

        private void btnElimininarAct_Click(object sender, EventArgs e)
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
    }
}
