
namespace Presentacion
{
    partial class FrmVentanaCorrecto
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
            this.lblMensajeCorrecto = new System.Windows.Forms.Label();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lblError = new System.Windows.Forms.Label();
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
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Correcto;
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensajeCorrecto
            // 
            this.lblMensajeCorrecto.Location = new System.Drawing.Point(46, 170);
            this.lblMensajeCorrecto.Name = "lblMensajeCorrecto";
            this.lblMensajeCorrecto.Size = new System.Drawing.Size(185, 13);
            this.lblMensajeCorrecto.TabIndex = 3;
            this.lblMensajeCorrecto.Text = "Este es un mensaje de como se vería";
            this.lblMensajeCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Animated = true;
            this.btnAceptar.BorderRadius = 12;
            this.btnAceptar.CheckedState.Parent = this.btnAceptar;
            this.btnAceptar.CustomImages.Parent = this.btnAceptar;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.DisabledState.Parent = this.btnAceptar;
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(221)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.HoverState.Parent = this.btnAceptar;
            this.btnAceptar.Location = new System.Drawing.Point(49, 201);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.ShadowDecoration.Parent = this.btnAceptar;
            this.btnAceptar.Size = new System.Drawing.Size(180, 45);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(221)))));
            this.lblError.Location = new System.Drawing.Point(92, 110);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(88, 23);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Correcto";
            // 
            // FrmVentanaCorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 284);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMensajeCorrecto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentanaCorrecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentaCorrecto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblMensajeCorrecto;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private System.Windows.Forms.Label lblError;
    }
}