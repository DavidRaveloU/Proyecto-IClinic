
namespace Presentacion
{
    partial class FrmVentanaError
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 210;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblError.Location = new System.Drawing.Point(106, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(55, 23);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Error";
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.Location = new System.Drawing.Point(46, 170);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(185, 13);
            this.lblMensajeError.TabIndex = 2;
            this.lblMensajeError.Text = "Este es un mensaje de como se vería";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Animated = true;
            this.btnCerrar.BorderRadius = 12;
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar.DisabledState.Parent = this.btnCerrar;
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Location = new System.Drawing.Point(49, 201);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(180, 45);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Volver a intentarlo";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmVentanaError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 284);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentanaError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentanaError";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.Label lblMensajeError;
    }
}