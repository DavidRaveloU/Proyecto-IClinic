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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private int posX = 0;
        private int posY = 0;

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }
        private Form frmPadre = null;
        private void AbrirFormulario(Form frmHijo)
        {
            if (frmPadre != null)
                frmPadre.Close();
            frmPadre = frmHijo;
            frmHijo.TopLevel = false;
            pnlGrapper.Dock = DockStyle.Fill;
            pnlGrapper.Controls.Add(frmHijo);
            pnlGrapper.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }
    }
}
