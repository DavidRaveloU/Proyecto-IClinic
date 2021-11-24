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
    public partial class FrmHorario : Form
    {
        public FrmHorario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtHoraFinalDeAtencion.Text = "";
            txtHoraInicialDeAtancion.Text = "";
            this.Close();
        }
        private int posX = 0;
        private int posY = 0;
        private void PnlSuperior_MouseMove(object sender, MouseEventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmVentanaError error = new FrmVentanaError();
            if (txtHoraInicialDeAtancion.Text == "" || txtHoraFinalDeAtencion.Text == "" )
            {
                error.lblMensajeError.Text = "Digite informacion en los campos pertinentes";
                error.Show();
                error.TopMost = true;
            }
            else if ((Convert.ToInt32(txtHoraInicialDeAtancion.Text) > Convert.ToInt32(txtHoraFinalDeAtencion.Text)))
            {
                error.lblMensajeError.Text = "La hora inicial debe ser menor a la hora final";
                error.Show();
                error.TopMost = true;
            }
            else
            {
                this.Close();
            }

        }

        private void VerificarHora()
        { 
        
        
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
