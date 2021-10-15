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
            CustomizedDesing();
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
        private void CustomizedDesing()
        {
            pnlMedico.Visible = false;
            pnlPaciente.Visible = false;
            pnlConsulta.Visible = false;
        }
        private void HideSubmenu()
        {
            if (pnlMedico.Visible == true)
                pnlMedico.Visible = false;
            if (pnlPaciente.Visible == true)
                pnlPaciente.Visible = false;
            if (pnlConsulta.Visible == true)
                pnlConsulta.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

      

        private void btnMedico_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlMedico);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarMedico());
            HideSubmenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultarMedico());
            HideSubmenu();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlPaciente);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlConsulta);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
