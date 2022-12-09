using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnoservice.Class;


namespace Tecnoservice.Formas
{
    public partial class Menu_Principal : Form
    {
        string scon;
        Abonos ab = new Abonos();
        Clientes clt = new Clientes();
        compras cmp = new compras();
        //Dispositivo dsp = new Dispositivo(this.scon);
        proveedores prv = new proveedores();
        Servicios srv = new Servicios();
        Venta vnt = new Venta();
       


        public Menu_Principal()
        {
            InitializeComponent();
           this.scon  = BD_Conex.conectar();
        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ab.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            clt.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmp.Show();
        }

        private void btnDispositivo_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Dispositivo dsp = new Dispositivo(this.scon);
            dsp.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            prv.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            srv.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            vnt.Show();
        }

        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToShortTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }


    }
}
