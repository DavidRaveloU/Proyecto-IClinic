using System;
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
    public partial class FrmConsultaHistorial : Form
    {
        ConsultaMedicaService ConsultaMedicaService;
        
        public FrmConsultaHistorial()
        {
           InitializeComponent();
            ConsultaMedicaService = new ConsultaMedicaService(ConfigConnection.Connection);
            MostrarConsultas();
           lblCantidadDeHistoriales.Text =  dtgConsulta.RowCount.ToString();
        }

        private void txtConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            ConsultaResponse response = ConsultaMedicaService.FiltrarConsultaMedica(txtConsulta.Text);
            if (!response.Error)
            {
                LlenarGrid(response.ConsultaMedicas);
            }
            else
            {
                MessageBox.Show(response.Mensaje, "Error al Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarGrid(List<ConsultaMedica> consultaMedicas)
        {
            dtgConsulta.Rows.Clear();

            foreach (var item in consultaMedicas)
            {
                    dtgConsulta.Rows.Add(item.IdConsulta,item.Peso,item.Estatura,
                    item.PresionArterial,item.RitmoCardiaco,
                    item.AntecedentesQuirurjicos,
                    item.IdTratamiento, item.IdDiagnostico,item.IdRecetaMedica,item.CedulaMedico,
                    item.CedulaPaciente);
            }

            dtgConsulta.Refresh();
        }

        private void MostrarConsultas()
        {
            ConsultaResponse response = ConsultaMedicaService.Consultar();
            if (!response.Error)
            {
                LlenarGrid(response.ConsultaMedicas);
            }
            else
            {
                MessageBox.Show(response.Mensaje, "Error al Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
