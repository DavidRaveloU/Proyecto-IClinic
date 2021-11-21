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
    public partial class FrmAgendaCita : Form
    {
        CitaMedicaService citaMedicaService;
        public FrmAgendaCita()
        {
            InitializeComponent();
            citaMedicaService = new CitaMedicaService(ConfigConnection.Connection);
        }

        private void FrmAgendaCita_Load(object sender, EventArgs e)
        {
            string numero = "0";
            DataTable dt = citaMedicaService.ExtraerNumeroSecuencia();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                numero = Convert.ToString(row[0]);
            }
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.ToShortDateString();
            lblNumeroAgenda.Text = numero;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

        }
        /*private CitaMedica MapearCita()
        {
            CitaMedica cita = new CitaMedica();
            cita.IdCita = txtNumeroDeCedula.Text;
            cita.HoraCitaMedica = hor;
            cita.FechaCitaMedica = txtSegundoNombre.Text;
            cita.Medico.NumeroDeCedula = txtPrimerApellido.Text;
            cita.CedulaPaciente = txtSegundoNombre.Text;
            return cita;
        }*/
    }
}
