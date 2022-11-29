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

namespace Tecnoservice.Formas
{
    public partial class Dispositivo : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        bool band1, band2;
        char estado;
        string sdconexion;
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
            if(Valida_Cliente())
            {

            }
            else
            {
                MessageBox.Show("No hay cliente registrado con ese identificador, asegurese de que sea un cliente ya resgistrado",
                    "ERROR", MessageBoxButtons.OKCancel ,MessageBoxIcon.Error);
            }
        }
        public bool Valida_Cliente()
        {
            int cliente = Convert.ToInt32(txtCltID.Text);
            string sql = "Select * from Clientes where Clt_Id = " + cliente;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) band1 = true;
            else band1 = false;
            con.Close();
            return band1;
        }
        public void Valida_estado()
        {
            if (band2 == true)
                estado = 'A';
            else
                estado = 'I';
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
            Actualiza_Datagrid();
        }

        private void DTG_Cliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCltID.Text = this.dsClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Id.ToString();
        }
        public void Actualiza_Datagrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClientesFalcon.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dsClientesFalcon.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'dsDispositivos.Dispositivo' Puede moverla o quitarla según sea necesario.
            this.dispositivoTableAdapter.Fill(this.dsDispositivos.Dispositivo);
        }
    }
}