
namespace Presentacion
{
    partial class FrmRegistrarMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFondoRegistrarMedico = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SuspendLayout();
            // 
            // pnlFondoRegistrarMedico
            // 
            this.pnlFondoRegistrarMedico.BackColor = System.Drawing.Color.Transparent;
            this.pnlFondoRegistrarMedico.FillColor = System.Drawing.Color.White;
            this.pnlFondoRegistrarMedico.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFondoRegistrarMedico.Location = new System.Drawing.Point(34, 26);
            this.pnlFondoRegistrarMedico.Name = "pnlFondoRegistrarMedico";
            this.pnlFondoRegistrarMedico.ShadowColor = System.Drawing.Color.Gray;
            this.pnlFondoRegistrarMedico.ShadowShift = 6;
            this.pnlFondoRegistrarMedico.Size = new System.Drawing.Size(722, 616);
            this.pnlFondoRegistrarMedico.TabIndex = 0;
            // 
            // FrmRegistrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.pnlFondoRegistrarMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarMedico";
            this.Text = "FrmRegistrarMedico";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFondoRegistrarMedico;
    }
}