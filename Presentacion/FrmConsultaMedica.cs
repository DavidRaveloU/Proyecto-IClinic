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
            tabConsultaMedica.SetPage("tratamiento");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tabConsultaMedica.SetPage("consulta medica");
        }
    }
}
