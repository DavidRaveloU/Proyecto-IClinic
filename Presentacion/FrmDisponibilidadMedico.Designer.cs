
namespace Presentacion
{
    partial class FrmDisponibilidadMedico
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
            this.txtNumeroDeCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumeroCédula = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PnlSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cmbDisponibilidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDisponibilidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeroDeCedula
            // 
            this.txtNumeroDeCedula.Animated = true;
            this.txtNumeroDeCedula.BorderRadius = 12;
            this.txtNumeroDeCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroDeCedula.DefaultText = "";
            this.txtNumeroDeCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroDeCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroDeCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroDeCedula.DisabledState.Parent = this.txtNumeroDeCedula;
            this.txtNumeroDeCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroDeCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroDeCedula.FocusedState.Parent = this.txtNumeroDeCedula;
            this.txtNumeroDeCedula.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDeCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroDeCedula.HoverState.Parent = this.txtNumeroDeCedula;
            this.txtNumeroDeCedula.Location = new System.Drawing.Point(320, 73);
            this.txtNumeroDeCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroDeCedula.Name = "txtNumeroDeCedula";
            this.txtNumeroDeCedula.PasswordChar = '\0';
            this.txtNumeroDeCedula.PlaceholderText = "Ej: 123456789";
            this.txtNumeroDeCedula.SelectedText = "";
            this.txtNumeroDeCedula.ShadowDecoration.Parent = this.txtNumeroDeCedula;
            this.txtNumeroDeCedula.Size = new System.Drawing.Size(196, 29);
            this.txtNumeroDeCedula.TabIndex = 10;
            // 
            // lblNumeroCédula
            // 
            this.lblNumeroCédula.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroCédula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCédula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumeroCédula.Location = new System.Drawing.Point(179, 75);
            this.lblNumeroCédula.Name = "lblNumeroCédula";
            this.lblNumeroCédula.Size = new System.Drawing.Size(132, 22);
            this.lblNumeroCédula.TabIndex = 9;
            this.lblNumeroCédula.Text = "Número de cédula";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.ShadowDecoration.Parent = this.PnlSuperior;
            this.PnlSuperior.Size = new System.Drawing.Size(718, 37);
            this.PnlSuperior.TabIndex = 11;
            this.PnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseMove);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnCancelar);
            this.guna2ShadowPanel1.Controls.Add(this.btnGuardar);
            this.guna2ShadowPanel1.Controls.Add(this.lblNombre);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.lblDisponibilidad);
            this.guna2ShadowPanel1.Controls.Add(this.cmbDisponibilidad);
            this.guna2ShadowPanel1.Controls.Add(this.txtNumeroDeCedula);
            this.guna2ShadowPanel1.Controls.Add(this.lblNumeroCédula);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(12, 54);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(694, 365);
            this.guna2ShadowPanel1.TabIndex = 12;
            // 
            // cmbDisponibilidad
            // 
            this.cmbDisponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.cmbDisponibilidad.BorderRadius = 14;
            this.cmbDisponibilidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisponibilidad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDisponibilidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDisponibilidad.FocusedState.Parent = this.cmbDisponibilidad;
            this.cmbDisponibilidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDisponibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDisponibilidad.HoverState.Parent = this.cmbDisponibilidad;
            this.cmbDisponibilidad.ItemHeight = 30;
            this.cmbDisponibilidad.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.cmbDisponibilidad.ItemsAppearance.Parent = this.cmbDisponibilidad;
            this.cmbDisponibilidad.Location = new System.Drawing.Point(320, 170);
            this.cmbDisponibilidad.Name = "cmbDisponibilidad";
            this.cmbDisponibilidad.ShadowDecoration.Parent = this.cmbDisponibilidad;
            this.cmbDisponibilidad.Size = new System.Drawing.Size(196, 36);
            this.cmbDisponibilidad.TabIndex = 11;
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisponibilidad.Location = new System.Drawing.Point(179, 175);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(101, 22);
            this.lblDisponibilidad.TabIndex = 12;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(179, 126);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 22);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(320, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 22);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 13;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.DisabledState.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(476, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(171, 31);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 13;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.DisabledState.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(47, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(171, 31);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmDisponibilidadMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 431);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.PnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDisponibilidadMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisponibilidadMedico";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNumeroDeCedula;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumeroCédula;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDisponibilidad;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDisponibilidad;
        private Guna.UI2.WinForms.Guna2Panel PnlSuperior;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}