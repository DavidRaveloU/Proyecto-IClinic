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

namespace Presentacion
{
    public partial class FrmRegistrarPaciente : Form
    {
        public FrmRegistrarPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validarCampos = ValidarCampos();
            if (!validarCampos.Equals("ok"))
            {
                FrmVentanaError frmVentanaError = new FrmVentanaError();
                frmVentanaError.lblMensajeError.Text = validarCampos;
                frmVentanaError.ShowDialog();
            }
            else
            {
                FrmVentanaCorrecto frmVentanaCorrecto = new FrmVentanaCorrecto();
                frmVentanaCorrecto.lblMensajeCorrecto.Text = "Datos guardados correctamente";
                frmVentanaCorrecto.ShowDialog();
            }
        }
        public string ValidarCampos()
        {
            bool validarEmail = ValidarEmail();
            if (string.IsNullOrEmpty(txtNumeroDeCedula.Text) || txtNumeroDeCedula.Text.Length < 6)
            {
                return "Ingrese un cedula válida";
            }
            else if (string.IsNullOrEmpty(txtPrimerNombre.Text) || txtPrimerNombre.Text.Length < 3)
            {
                return "Ingrese un primer nombre válido";
            }
            else if (string.IsNullOrEmpty(txtPrimerApellido.Text) || txtPrimerApellido.Text.Length < 3)
            {
                return "Ingrese un primer apellido válido";
            }
            else if (string.IsNullOrEmpty(txtSegundoApellido.Text) || txtSegundoApellido.Text.Length < 3)
            {
                return "Ingrese un segundo apellido válido";
            }
            else if (string.IsNullOrEmpty(txtSegundoApellido.Text) || txtSegundoApellido.Text.Length < 3)
            {
                return "Ingrese un segundo apellido válido";
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length != 10)
            {
                return "Ingrese un telefono válido";
            }
            else if (validarEmail == false)
            {
                return "Ingrese un correo válido";
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text) || txtDireccion.Text.Length < 6)
            {
                return "Ingrese una dirección válida";
            }
            else if (string.IsNullOrEmpty(cmbSexo.Text))
            {
                return "Eliga un sexo";
            }
            else if (string.IsNullOrEmpty(txtCiudad.Text) || txtCiudad.Text.Length < 3)
            {
                return "Ingrese una ciudad válida";
            }
            return "ok";
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
            validarSoloNumeros(e);
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }
    }
}
