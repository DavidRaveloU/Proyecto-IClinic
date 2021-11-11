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
        private void ValidarCampo(Label label, Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            label.Text = (string.IsNullOrEmpty(textBox.Text)) ? "*Digite Informacion*" : " ";
        }

        private void HabilitarBotonSiguiente()
        {
            if (txtCedula.Text != string.Empty && !string.IsNullOrEmpty(txtTemperatura.Text)
                && !string.IsNullOrEmpty(txtEstatura.Text) && !string.IsNullOrEmpty(txtPeso.Text) 
                && !string.IsNullOrEmpty(txtPresion.Text) && txtDiagnostico.Text != string.Empty)
            {
                btnSiguiente1.Enabled = true;
            }
            else
            {
                btnSiguiente1.Enabled=false;    
            }
        }

        private void txtNombreTratamiento_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorTratamiento,txtNombreTratamiento);
            HabilitarBotonSiguiente();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErroCedula, txtCedula);
            HabilitarBotonSiguiente();
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorTemperatura, txtTemperatura);
            HabilitarBotonSiguiente();
        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorEstatura , txtEstatura );
            HabilitarBotonSiguiente();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorPeso,txtPeso);
            HabilitarBotonSiguiente();
        }

        private void txtPresion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorPresion, txtPresion);
            HabilitarBotonSiguiente();
        }

        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorDiagnostico,txtDiagnostico);
            HabilitarBotonSiguiente();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorDescripcion, txtDescripcion);
            HabilitarBotonFinalizar();
        }

        private void txtNombreMedicamento_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorMedicamento,txtNombreMedicamento);
            HabilitarBotonFinalizar();
        }

        private void txtIndicaciones_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(lblErrorIndicaciones, txtIndicaciones);
            HabilitarBotonFinalizar();
        }
        private void HabilitarBotonFinalizar()
        {
            if (txtDescripcion.Text != string.Empty && txtNombreMedicamento.Text != string.Empty &&
                txtIndicaciones.Text != string.Empty)
            {
                btnFinalizar.Enabled = true;
            }
            else
            {
                btnFinalizar.Enabled =false;    
            }
        }

    }
}
