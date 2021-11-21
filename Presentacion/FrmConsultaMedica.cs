﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace Presentacion
{
    public partial class FrmConsultaMedica : Form
    {
        ConsultaMedicaService consultaMedicaService;
        public FrmConsultaMedica()
        {
            InitializeComponent();
            consultaMedicaService = new ConsultaMedicaService(ConfigConnection.Connection);
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            chkConsultaMedica.Checked = chkConsultaMedica.Enabled = true;
            lblConslutaMedica.ForeColor = Color.Blue;
            tabConsultaMedica.SetPage("tratamiento");
            lblIdTratamiento.Text = lblidConsulta.Text;
            lblIdRecetaMedica.Text = lblidConsulta.Text;


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
        private void ValidarCampoVacio(Label label, Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            label.Text = (string.IsNullOrEmpty(textBox.Text)) ? "*Digite Informacion*" : " ";
        }

        private void HabilitarBotonSiguiente()
        {
            if (txtCedulaPaciente.Text != string.Empty && !string.IsNullOrEmpty(txtTemperatura.Text)
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
            ValidarCampoVacio(lblErrorTratamiento,txtNombreTratamiento);
            HabilitarBotonSiguiente();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErroCedula, txtCedulaPaciente);
            HabilitarBotonSiguiente();
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorTemperatura, txtTemperatura);
            HabilitarBotonSiguiente();
        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorEstatura , txtEstatura );
            HabilitarBotonSiguiente();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorPeso,txtPeso);
            HabilitarBotonSiguiente();
        }

        private void txtPresion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorPresion, txtPresion);
            HabilitarBotonSiguiente();
        }

        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorDiagnostico,txtDiagnostico);
            HabilitarBotonSiguiente();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorDescripcion, txtDescripcion);
            HabilitarBotonFinalizar();
        }

        private void txtNombreMedicamento_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorMedicamento,txtNombreMedicamento);
            HabilitarBotonFinalizar();
        }

        private void txtIndicaciones_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoVacio(lblErrorIndicaciones, txtIndicaciones);
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

        private void FrmConsultaMedica_Load(object sender, EventArgs e)
        {
            string numero = "0";
            DataTable dt = consultaMedicaService.ExtraerNumeroSecuencia();  
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                numero = Convert.ToString(row[0]);
            }
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.ToShortDateString();
            lblidConsulta.Text = numero;
            lblFechaHoy.Text = date.ToString();
        }

        private void ptbBuscarCedulaMedico_Click(object sender, EventArgs e)
        {
            ConsultaResponse respuesta;
            respuesta = consultaMedicaService.FiltrarPorCedulaMedico(txtCedulaMedico.Text);
            List<Medico> medicos = respuesta.Medicos;
            if (!medicos.Any())
            {
                MessageBox.Show("El medico no existe");
            }
            
        }

        private void ptbBuscarCedulaPaciente_Click(object sender, EventArgs e)
        {
            ConsultaResponse respuesta;
            respuesta = consultaMedicaService.FiltrarPorCedulaPaciente(txtCedulaPaciente.Text);
            List<Paciente> pacientes = respuesta.Pacientes;
            if (pacientes.Any())
            {
                foreach (var item in pacientes)
                {
                    lblNombre.Text = item.PrimerNombre;
                }
            }
            else
            {
                lblNombre.Text = "Nombre";
                MessageBox.Show("El paciente no existe");
            }
        }
    }
}
