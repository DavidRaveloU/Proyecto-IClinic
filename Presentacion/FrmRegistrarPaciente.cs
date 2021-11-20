using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class FrmRegistrarPaciente : Form
    {
        PacienteService pacienteService;
        public FrmRegistrarPaciente()
        {
            InitializeComponent();
            pacienteService = new PacienteService(ConfigConnection.Connection);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Paciente paciente = MapearPaciente();
            string mensaje = pacienteService.Guardar(paciente);
            MessageBox.Show(mensaje, "Guardar Medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidarEmail()
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtCorreo.Text, expresion))
            {
                if (Regex.Replace(txtCorreo.Text, expresion, String.Empty).Length == 0)
                { 
                    return true; 
                }
            }
            return false;
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
        private void validarSoloLetras(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 ||
                e.KeyChar >= 91 && e.KeyChar <= 96 ||
                e.KeyChar >= 123)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTelefono.TextLength > 9)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            validarSoloNumeros(e);
        }
        private void Validar()
        {
            bool validaEmail = ValidarEmail();
            if (txtNumeroDeCedula.Text != string.Empty && txtPrimerNombre.Text != string.Empty && txtPrimerApellido.Text != string.Empty
                && txtTelefono.Text != string.Empty && txtCorreo.Text != string.Empty && validaEmail == true && txtDireccion.Text != string.Empty &&
                cmbSexo.Text != string.Empty && txtCiudad.Text != string.Empty)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
        private void txtNumeroDeCedula_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroDeCedula.Text))
            {
                lblErrorCedula.Visible = true;
                Validar();
            }
            else
            {
                lblErrorCedula.Visible = false;
                Validar();
            }
        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                lblErrorPN.Visible = true;
                Validar();
            }
            else
            {
                lblErrorPN.Visible = false;
                Validar();
            }
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                lblErrorPA.Visible = true;
                Validar();
            }
            else
            {
                lblErrorPA.Visible = false;
                Validar();
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblErrorCelular.Visible = true;
                Validar();
            }
            else
            {
                lblErrorCelular.Visible = false;
                Validar();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            bool validarEmail = ValidarEmail();
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                lblErrorCorreo.Text = "* Campo obligatorio";
                lblErrorCorreo.Visible = true;
                Validar();
            }
            else if(!validarEmail)
            {
                lblErrorCorreo.Text = "Formato de correo invalido";
                lblErrorCorreo.Visible = true;
                Validar();
            }
            else
            {
                lblErrorCorreo.Visible = false;
                lblErrorCorreo.Text = "* Campo obligatorio";
                Validar();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lblErrorDireccion.Visible = true;
                Validar();
            }
            else
            {
                lblErrorDireccion.Visible = false;
                Validar();
            }
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                lblErrorCiudad.Visible = true;
                Validar();
            }
            else
            {
                lblErrorCiudad.Visible = false;
                Validar();
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSexo.SelectedIndex == -1)
            {
                lblErrorSexo.Visible = true;
                Validar();
            }
            else
            {
                lblErrorSexo.Visible = false;
                Validar();
            }
        }
        private Paciente MapearPaciente()
        {
            Paciente paciente = new Paciente();
            paciente.NumeroDeCedula = txtNumeroDeCedula.Text;
            paciente.PrimerNombre = txtPrimerNombre.Text;
            paciente.SegundoNombre = txtSegundoNombre.Text;
            paciente.PrimerApellido = txtPrimerApellido.Text;
            paciente.SegundoApellido = txtSegundoNombre.Text;
            paciente.NumeroTelefono = txtTelefono.Text;
            paciente.CorreoElectronico = txtCorreo.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Sexo = cmbSexo.Text;
            paciente.Ciudad = txtCiudad.Text;
            return paciente;
        }
    }
}
