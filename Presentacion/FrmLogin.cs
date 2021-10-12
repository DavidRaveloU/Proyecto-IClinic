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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Opacity = 0.0;
            tmrFundir.Start();
        }

        int m, mx, my;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string validar = ValidarCredenciales();
            if (string.IsNullOrEmpty(validar))
            {
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show(validar);
            }
        }

        private string ValidarCredenciales()
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                return "Por favor ingrese un usuario";
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                return "Por favor ingrese una contraseña";
            }

            return ""; 
        }

        private int contador = 0;
        private void tmrFundir_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.28;
            contador += 1;
            if (contador == 100)
            {
                tmrFundir.Stop();

            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
