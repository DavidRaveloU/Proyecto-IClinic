using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private void txtNumeroDeCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNumeroDeCedula.TextLength > 11)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            validarSoloNumeros(e);
        }
        private void validarSoloNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 ||
                e.KeyChar >= 58)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
        private void validarSoloNumerosYDosPuntos(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 ||
                e.KeyChar >= 59)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
        private void txtHoraInicialDeAtancion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtHoraInicialDeAtancion.TextLength > 4)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            if (txtHoraInicialDeAtancion.Text.Contains(":"))
            {
                if(e.KeyChar == 58)
                {
                    e.Handled=true;
                }
            }
            validarSoloNumerosYDosPuntos(e);
        }

        private void txtHoraFinalDeAtencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtHoraFinalDeAtencion.TextLength > 4)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            if (txtHoraFinalDeAtencion.Text.Contains(":"))
            {
                if (e.KeyChar == 58)
                {
                    e.Handled = true;
                }
            }
            validarSoloNumerosYDosPuntos(e);
        }
    }
}
