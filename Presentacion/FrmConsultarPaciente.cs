using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class FrmConsultarPaciente : Form
    {
        PacienteService pacienteService;
        public FrmConsultarPaciente()
        {
            InitializeComponent();
            pacienteService = new PacienteService(ConfigConnection.Connection);
            MostrarPacientes();
        }
        public void LlenarGrid(List<Paciente> pacientes)
        {
            dtgConsulta.Rows.Clear();

            foreach (var item in pacientes)
            {
                dtgConsulta.Rows.Add(item.NumeroDeCedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.NumeroTelefono, item.CorreoElectronico, item.Direccion, item.Sexo, item.Ciudad);
            }

            dtgConsulta.Refresh();
        }
        private void MostrarPacientes()
        {
            ConsultaResponse response = pacienteService.Consultar();
            if (!response.Error)
            {
                LlenarGrid(response.Pacientes);
            }
            else
            {
                MessageBox.Show(response.Mensaje, "Error al Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
