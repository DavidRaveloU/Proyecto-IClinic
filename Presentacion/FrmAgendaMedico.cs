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
    public partial class FrmAgendaMedico : Form
    {
        public FrmAgendaMedico()
        {
            InitializeComponent();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            OscurecerFondo();
        }

        private void OscurecerFondo()
        {
            Form frmEstilo = new Form();
            using (FrmDisponibilidadMedico disponibilidadMedico = new FrmDisponibilidadMedico())
            {
                frmEstilo.StartPosition = FormStartPosition.Manual;
                frmEstilo.FormBorderStyle = FormBorderStyle.None;
                frmEstilo.Opacity = .70d;
                frmEstilo.BackColor = Color.Black;
                frmEstilo.WindowState = FormWindowState.Maximized;
                frmEstilo.TopMost = true;
                frmEstilo.Location = this.Location;
                frmEstilo.ShowInTaskbar = false;
                frmEstilo.Show();
                disponibilidadMedico.Owner = frmEstilo;
                disponibilidadMedico.ShowDialog();
                frmEstilo.Dispose();
            }
        }
    }
}
