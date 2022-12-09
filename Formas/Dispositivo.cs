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
using MessageBox = System.Windows.Forms.MessageBox;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Tecnoservice.Formas
{
    public partial class Dispositivo : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        Cls_Dispositivo dsp = new Cls_Dispositivo();
        bool band1, band2;
        char estado;
        int idcliente;
        string cliente,sql;
        public Dispositivo(string sconexion)
        {
            InitializeComponent();
            Consecutivo();
        }
        public void Limpiar()
        {
            txtIdDispositivo.Text = "";
            txtCltID.Text = "";
            txtIdDispositivo.Text = "";
            txtMarcaDispo.Text = "";
            txtModeloDispo.Text = "";
            txtIMEIDispo.Text = "";
            txtDetDispositivo.Text = "";
            txtNameCliente.Text = "";
            Actualiza_Datagrid();
            Consecutivo();
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Ds_Id),0) + 1 FROM Dispositivo", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtIdDispositivo.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
        public void Eliminar()
        {
            Set_Datos();
            if (dsp.Eliminar())
            {
                MessageBox.Show("Datos eliminados exitosamente");
            }
            else
            {
                MessageBox.Show("Los datos no se eliminaron");
            }
            con.Close();
            Limpiar();
        }
        public void Set_Datos()
        {
            dsp.Dis_Id = Convert.ToInt32(txtIdDispositivo.Text);
            dsp.Dis_CltId = Convert.ToInt32(txtCltID.Text);
            dsp.Dis_Marca = txtMarcaDispo.Text;
            dsp.Dis_Modelo = txtModeloDispo.Text;
            dsp.Dis_Imei = txtIMEIDispo.Text;
            dsp.Dis_Detalles = txtDetDispositivo.Text;
            dsp.Dis_Estado = estado;
        }
        public void GuardarDispositivo()
        {
            if(Valida_Info())
            {
                if (Valida_Cliente())
                {
                    Valida_estado();
                    Set_Datos();
                    if (Valida_Imei())
                    { 
                        if (dsp.Guardar())
                        {
                            MessageBox.Show("Datos guardados exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("Los datos no se guardaron");
                        }
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("El IMEI ingresado ya existe, desea actualizarlo??","Adevertencia",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        switch(res)
                        {
                            case DialogResult.Yes:
                                if (dsp.Guardar())
                                {
                                    MessageBox.Show("Se cambiara el IMEI, datos guardados exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show("Los datos no se guardaron");
                                }
                                break;
                            case DialogResult.No:
                                if (dsp.Guardar())
                                {
                                    MessageBox.Show("No se cambiara el IMEI, datos guardados exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show("Los datos no se guardaron");
                                }
                                break;
                        }
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No hay cliente registrado con ese identificador, asegurese de que sea un cliente ya resgistrado",
                        "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegurese de que todos los campos estan llenados",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Limpiar();
        }
        public bool Valida_Info()
        {
            if (txtIdDispositivo.Text == "" || txtCltID.Text == "" || txtDetDispositivo.Text == ""
                || txtMarcaDispo.Text == "" || txtModeloDispo.Text == "" || txtIMEIDispo.Text == "")
            {
                if (Radbtn_Activo.Checked == false && Radbtn_Inactivo.Checked == false)
                    band2 = false;
                if (Radbtn_Activo.Checked == true) band2 = true;
                if (Radbtn_Inactivo.Checked == true) band2 = false;
            }
            else
                band2 = true;
            return band2;
        }
        public bool Valida_Cliente()
        {
            int cliente = Convert.ToInt32(txtCltID.Text);
            string sql = "Select Clt_Id from Clientes where Clt_Id = " + cliente;
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) band1 = true;
            else band1 = false;
            con.Close();
            return band1;
        }
        public void Valida_estado()
        {
            if (Radbtn_Activo.Checked == true)
                estado = 'A';
            else
                estado = 'I';
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDispositivo();
            Actualiza_Datagrid();
            Consecutivo();
        }
        private void Dispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }
        private void Dispositivo_Load(object sender, EventArgs e)
        {
            Actualiza_Datagrid();
        }
        public bool Valida_Imei()
        {
            sql = "Select Ds_IMEI from Dispositivo where Ds_IMEI = " + dsp.Dis_Imei;
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) band1 = false;
            else band1 = true;
            return band1;
        }
        public void Dispositivos_Cliente()
        {
            sql = "Select * from Dispositivo where Clt_Id = " + idcliente;
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DTG_Dispositivo.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No existen Dispositivos registrados de este cliente");
            }
            con.Close();
        }
        public void obtener_cliente()
        {
            idcliente = Convert.ToInt32(this.dsClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Id.ToString());
            cliente = this.dsClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Nombre;
        }
        private void DTG_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener_cliente();
            txtCltID.Text = Convert.ToString(idcliente);
            txtNameCliente.Text = cliente;
            DTG_Dispositivo.DataSource = null;
            dt.Clear();
            DTG_Dispositivo.Refresh();
            Dispositivos_Cliente();
        }
        private void btnDeleteActive_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void txtIMEIDispo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Actualiza_Datagrid();
        }
        private void DTG_Dispositivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDispositivo.Text = this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Ds_Id.ToString();
            txtCltID.Text = this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Clt_Id.ToString();
            txtMarcaDispo.Text = this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Ds_Marca;
            txtModeloDispo.Text = this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Ds_Modelo;
            txtIMEIDispo.Text = this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Ds_IMEI.ToString();
            txtDetDispositivo.Text = this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Ds_Problema;
            estado = Convert.ToChar(this.dS_DispositivosFalcon.Dispositivo[dispositivoBindingSource.Position].Ds_Estado);
            switch(estado)
            {
                case 'A':
                    Radbtn_Activo.Checked = true;
                    Radbtn_Inactivo.Checked = false;
                    break;
                case 'I':
                    Radbtn_Activo.Checked = false;
                    Radbtn_Inactivo.Checked = true;
                    break;
            }
        }
        public void Actualiza_Datagrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_DispositivosFalcon.Dispositivo' Puede moverla o quitarla según sea necesario.
            this.dispositivoTableAdapter.Fill(this.dS_DispositivosFalcon.Dispositivo);
            // TODO: esta línea de código carga datos en la tabla 'dsClientesFalcon.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dsClientesFalcon.Clientes);
        }
    }
}