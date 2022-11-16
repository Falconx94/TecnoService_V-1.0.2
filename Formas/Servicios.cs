using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnoservice.Class;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Tecnoservice.Formas
{
    public partial class Servicios : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Servicios clssrv = new Cls_Servicios();
        bool band1 = true, band2 = false;
        int a;
        char estado;
        public Servicios()
        {
            InitializeComponent();
        }
        private void Servicios_Load(object sender, EventArgs e)
        {
            Actualiza_Datagrid();
            Consecutivo();
        }
        public void Actualiza_Datagrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dsServicios.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dsServicios.Servicio);
        }
        public void GuardarServico()
        {
            if (valida_info())
            {
                Valida_estado();
                Valida_Servicio();
                clssrv.Srv_ID = Convert.ToInt32(txtSVID.Text);
                clssrv.SrvClt_Id = Convert.ToInt32(txtCltId.Text);
                clssrv.Srv_type = a;
                clssrv.Srv_Fecha = Convert.ToDateTime(dtpFec_Servicio.Text);
                clssrv.Srv_Precio = Convert.ToDouble(txtPrecio.Text);
                clssrv.Srv_Descripción = txtDescripcion.Text;
                clssrv.Srv_Estado
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
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Sv_Id),0) + 1 FROM Servicio", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtSVID.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
        public void Valida_Servicio()
        {
            if (Cbox_TipoServicio.SelectedIndex == 0) a = 1;
            else a = 2;
        }
        public void Valida_estado()
        {
            if (Radbtn_Proceso.Checked == false)
            {
                estado = 'P';
            }
            //    Radbtn_Activo.Checked = band1;
            //else
            //    Radbtn_Activo.Checked = false;
            //    Radbtn_Fin.Checked = false;
        }
        public bool valida_info()
        {
            if (txtCltId.Text == "" || txtSVID.Text == "" || Cbox_TipoServicio.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Verificar que los datos esten llenos");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }

        private void Servicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }

    }
}
