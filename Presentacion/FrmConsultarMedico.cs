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
    public partial class FrmConsultarMedico : Form
    {
        public FrmConsultarMedico()
        {
            InitializeComponent();
            
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
    }
}
