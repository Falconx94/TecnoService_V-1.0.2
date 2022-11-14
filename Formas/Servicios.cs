using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnoservice.Formas
{
    public partial class Servicios : Form
    {
        bool band = true;
        public Servicios()
        {
            InitializeComponent();
        }
        private void Servicios_Load(object sender, EventArgs e)
        {
            Validar_Radbtn();
        }
        public void Validar_Radbtn()
        {
            Radbtn_Espera.Checked = band;
            if (Radbtn_Espera.Checked == false)
                Radbtn_Activo.Checked = band;
            else
                Radbtn_Activo.Checked = false;
        }
        private void Radbtn_Espera_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Radbtn_Activo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Radbtn_Espera_Click(object sender, EventArgs e)
        {
            if (Radbtn_Espera.Checked == band)
                Radbtn_Espera.Checked = false;
            else
                Radbtn_Espera.Checked = band;
        }

        private void Servicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
