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
        int cliente;
        //string sdconexion;
        public Dispositivo(string sconexion)
        {
            InitializeComponent();
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
        public void GuardarDispositivo()
        {
            if(Valida_Info())
            { 
                if (Valida_Cliente())
                {
                    Valida_estado();
                    dsp.Dis_Id = Convert.ToInt32(txtIdDispositivo.Text);
                    dsp.Dis_CltId = Convert.ToInt32(txtCltID.Text);
                    dsp.Dis_Marca = txtMarcaDispo.Text;
                    dsp.Dis_Modelo = txtModeloDispo.Text;
                    dsp.Dis_Imei = txtIMEIDispo.Text;
                    dsp.Dis_Detalles = txtDetDispositivo.Text;
                    dsp.Dis_Estado = estado;
                    if (dsp.Guardar())
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
        }
        public bool Valida_Info()
        {
            if (txtIdDispositivo.Text == "" || txtCltID.Text == "" || txtDetDispositivo.Text == "" || txtMarcaDispo.Text == "" || txtModeloDispo.Text == "")
                band2 = false;
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
        }
        public void Datos_Fijos()
        {
            txtIdDispositivo.Enabled = false;
            txtDetDispositivo.Enabled = false;
            txtIMEIDispo.Enabled = false;
            txtMarcaDispo.Enabled = false;
            txtModeloDispo.Enabled = false;
        }
        private void Dispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }
        private void Dispositivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDispositivosFalcon.Dispositivo' Puede moverla o quitarla según sea necesario.
            this.dispositivoTableAdapter.Fill(this.dsDispositivosFalcon.Dispositivo);
            Actualiza_Datagrid();
        }
        public void obtener_cliente()
        {
            cliente = Convert.ToInt32(this.dsClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Id.ToString());
        }
        public void Dispositivos_Cliente()
        {
            string sql = "Select * from Dispositivo where Clt_Id = " + cliente;
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
        private void DTG_Cliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener_cliente();
            txtCltID.Text = Convert.ToString(cliente);
            Dispositivos_Cliente();
        }
        public void Actualiza_Datagrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClientesFalcon.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dsClientesFalcon.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'dsDispositivosFalcon.Dispositivo' Puede moverla o quitarla según sea necesario.
            this.dispositivoTableAdapter.Fill(this.dsDispositivosFalcon.Dispositivo);
        }
    }
}