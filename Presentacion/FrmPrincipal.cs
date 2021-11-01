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
            AbrirFormulario(new FrmAgendaCita());
        }

        private string formularioAbierto = "agendar cita";

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
            if (!formularioAbierto.ToLower().Equals("registrar medico"))
            {
                AbrirFormulario(new FrmRegistrarMedico());
                HideSubmenu();
                formularioAbierto = "registrar medico";
            }
        }

        private void btnConsultarMedico_Click(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("consultar medico"))
            {
                AbrirFormulario(new FrmConsultarMedico());
                HideSubmenu();
                formularioAbierto = "consultar medico";
            }
        }

        private void btnPaciente_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlPaciente);
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("registrar paciente"))
            {
                AbrirFormulario(new FrmRegistrarPaciente());
                HideSubmenu();
                formularioAbierto = "registrar paciente";
            }
        }

        private void btnConsultarPaciente_Click(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("consultar paciente"))
            {
                AbrirFormulario(new FrmConsultarPaciente());
                HideSubmenu();
                formularioAbierto = "consultar paciente";
            }
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlConsulta);
        }

        private void btnConsultaMedica_Click_1(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("consulta medica"))
            {
                AbrirFormulario(new FrmConsultaMedica());
                HideSubmenu();
                formularioAbierto = "consula medica";
            }
        }

        private void btnConsultarHistorial_Click_1(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("consultar historial"))
            {
                AbrirFormulario(new FrmConsultaHistorial());
                HideSubmenu();
                formularioAbierto = "consultar historial";
            }
        }

        private void btnAgendarMedico_Click(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("agendar medico")) 
            {
            AbrirFormulario(new FrmAgendaMedico());
            HideSubmenu();
                formularioAbierto = "agendar medico";
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            if (!formularioAbierto.ToLower().Equals("agendar cita"))
            {
                AbrirFormulario(new FrmAgendaCita());
                HideSubmenu();
                formularioAbierto = "agendar cita";
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Dispose();
        }
    }
}
