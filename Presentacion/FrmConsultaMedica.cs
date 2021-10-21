using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConsultaMedica : Form
    {
        public FrmConsultaMedica()
        {
            InitializeComponent();
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            chkConsultaMedica.Checked = chkConsultaMedica.Enabled = true;
            lblConslutaMedica.ForeColor = Color.Blue;
            tabConsultaMedica.SetPage("tratamiento");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CheckDisable();
            tabConsultaMedica.SetPage("consulta medica");
        }

        private void CheckDisable()
        {
            chkTratamiento.Checked = chkTratamiento.AutoCheck = false;
            lblTratamiento.ForeColor = Color.FromArgb(152, 152, 152);
            chkConsultaMedica.Checked = chkConsultaMedica.AutoCheck = false;
            lblConslutaMedica.ForeColor = Color.FromArgb(152, 152, 152);
           
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            chkTratamiento.Checked = chkTratamiento.Enabled = true;
            lblTratamiento.ForeColor = Color.Blue;

        }
    }
}
