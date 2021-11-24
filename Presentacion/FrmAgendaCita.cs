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

        private void btnAgregarHora_Click(object sender, EventArgs e)
        {
            GenerarListaDeHora();
        }

        private void GenerarListaDeHora()
        {

            FrmHorario frmHorario = new FrmHorario();
            frmHorario.ShowDialog();

            if (frmHorario.txtHoraInicialDeAtancion.Text != "" && frmHorario.txtHoraFinalDeAtencion.Text != "")
            {
                DateTime time = new DateTime();
                var horaInicial = Convert.ToInt32(frmHorario.txtHoraInicialDeAtancion.Text);
                var hours = Convert.ToInt32(frmHorario.txtHoraFinalDeAtencion.Text);
                    for (int i = horaInicial; i < hours; i++)
                    {
                        DateTime tiempo = time.AddHours(i);
                        string Formato = tiempo.ToString("HH':'mm");
                        cmbHora.Items.Add(Formato);

                        for (int j = 1; j <= 3; j++)
                        {
                            tiempo = tiempo.AddMinutes(15);
                            string FormatoM = tiempo.ToString("HH':'mm");
                            cmbHora.Items.Add(FormatoM);
                        }


                    }
                
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cmbHora.Items.Clear();
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
