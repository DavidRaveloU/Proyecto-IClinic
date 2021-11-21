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
    public partial class FrmConsultarMedico : Form
    {
        MedicoService medicoService;
        public FrmConsultarMedico()
        {
            InitializeComponent();
            medicoService = new MedicoService(ConfigConnection.Connection);
            MostrarMedicos();
            lblCantidadDeMedicos.Text = dtgConsultarMedicos.RowCount.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmVentanaAlvertencia ventanaAlvertencia = new FrmVentanaAlvertencia();
            ventanaAlvertencia.lblMensajeError.Text = "Al aceptar, no se podran recuperar los datos eliminados!";
            ventanaAlvertencia.ShowDialog();
            if (ventanaAlvertencia.DialogResult == DialogResult.OK)
            {
            
            }

        }
        public void LlenarGrid(List<Medico> medicos)
        {
            dtgConsultarMedicos.Rows.Clear();

            foreach (var item in medicos)
            {
                dtgConsultarMedicos.Rows.Add(item.NumeroDeCedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.NumeroTelefono, item.CorreoElectronico, item.Direccion, item.Sexo, item.Ciudad);
            }

            dtgConsultarMedicos.Refresh();
        }
        private void MostrarMedicos()
        {
            ConsultaResponse response = medicoService.Consultar();
            if (!response.Error)
            {
                LlenarGrid(response.Medicos);
            }
            else
            {
                MessageBox.Show(response.Mensaje, "Error al Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
