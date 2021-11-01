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
            AbrirFormulario(new FrmAgenda());
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
            pnlAgenda.Visible = false;
        }
        private void HideSubmenu()
        {
            if (pnlAgenda.Visible == true)
                pnlAgenda.Visible = false;
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
   
       
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlAgenda);
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void pnlGrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedico_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlMedico);
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarMedico());
            HideSubmenu();
        }

        private void btnConsultarMedico_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultarMedico());
            HideSubmenu();
        }

        private void btnPaciente_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlPaciente);
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarPaciente());
            HideSubmenu();
        }

        private void btnConsultarPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultarPaciente());
            HideSubmenu();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlConsulta);
        }

        private void btnConsultaMedica_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultaMedica());
            HideSubmenu();
        }

        private void btnConsultarHistorial_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultaHistorial());
            HideSubmenu();
        }

        private void btnAgendarMedico_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgenda());
            HideSubmenu();
        }
    }
}
