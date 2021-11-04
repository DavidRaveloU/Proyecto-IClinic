
namespace Presentacion
{
    partial class FrmHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorario));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PnlSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblHoraFinalDeAtencion = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHoraInicialDeAtencion = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtHoraFinalDeAtencion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoraInicialDeAtancion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumeroHorario = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHorario = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2ShadowPanel1.Controls.Add(this.lblHoraFinalDeAtencion);
            this.guna2ShadowPanel1.Controls.Add(this.lblHoraInicialDeAtencion);
            this.guna2ShadowPanel1.Controls.Add(this.txtHoraFinalDeAtencion);
            this.guna2ShadowPanel1.Controls.Add(this.txtHoraInicialDeAtancion);
            this.guna2ShadowPanel1.Controls.Add(this.lblNumeroHorario);
            this.guna2ShadowPanel1.Controls.Add(this.lblHorario);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancelar);
            this.guna2ShadowPanel1.Controls.Add(this.btnGuardar);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(12, 54);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(694, 365);
            this.guna2ShadowPanel1.TabIndex = 12;
            // 
            // lblHoraFinalDeAtencion
            // 
            this.lblHoraFinalDeAtencion.AllowParentOverrides = false;
            this.lblHoraFinalDeAtencion.AutoEllipsis = false;
            this.lblHoraFinalDeAtencion.CursorType = null;
            this.lblHoraFinalDeAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFinalDeAtencion.Location = new System.Drawing.Point(176, 180);
            this.lblHoraFinalDeAtencion.Name = "lblHoraFinalDeAtencion";
            this.lblHoraFinalDeAtencion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoraFinalDeAtencion.Size = new System.Drawing.Size(155, 20);
            this.lblHoraFinalDeAtencion.TabIndex = 84;
            this.lblHoraFinalDeAtencion.Text = "Hora final de atención";
            this.lblHoraFinalDeAtencion.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHoraFinalDeAtencion.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblHoraInicialDeAtencion
            // 
            this.lblHoraInicialDeAtencion.AllowParentOverrides = false;
            this.lblHoraInicialDeAtencion.AutoEllipsis = false;
            this.lblHoraInicialDeAtencion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHoraInicialDeAtencion.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHoraInicialDeAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicialDeAtencion.Location = new System.Drawing.Point(176, 138);
            this.lblHoraInicialDeAtencion.Name = "lblHoraInicialDeAtencion";
            this.lblHoraInicialDeAtencion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoraInicialDeAtencion.Size = new System.Drawing.Size(164, 20);
            this.lblHoraInicialDeAtencion.TabIndex = 83;
            this.lblHoraInicialDeAtencion.Text = "Hora inicial de atención";
            this.lblHoraInicialDeAtencion.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHoraInicialDeAtencion.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtHoraFinalDeAtencion
            // 
            this.txtHoraFinalDeAtencion.Animated = true;
            this.txtHoraFinalDeAtencion.BorderRadius = 12;
            this.txtHoraFinalDeAtencion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoraFinalDeAtencion.DefaultText = "";
            this.txtHoraFinalDeAtencion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoraFinalDeAtencion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoraFinalDeAtencion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraFinalDeAtencion.DisabledState.Parent = this.txtHoraFinalDeAtencion;
            this.txtHoraFinalDeAtencion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraFinalDeAtencion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraFinalDeAtencion.FocusedState.Parent = this.txtHoraFinalDeAtencion;
            this.txtHoraFinalDeAtencion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFinalDeAtencion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraFinalDeAtencion.HoverState.Parent = this.txtHoraFinalDeAtencion;
            this.txtHoraFinalDeAtencion.Location = new System.Drawing.Point(352, 177);
            this.txtHoraFinalDeAtencion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoraFinalDeAtencion.Name = "txtHoraFinalDeAtencion";
            this.txtHoraFinalDeAtencion.PasswordChar = '\0';
            this.txtHoraFinalDeAtencion.PlaceholderText = "Digite la información";
            this.txtHoraFinalDeAtencion.SelectedText = "";
            this.txtHoraFinalDeAtencion.ShadowDecoration.Parent = this.txtHoraFinalDeAtencion;
            this.txtHoraFinalDeAtencion.Size = new System.Drawing.Size(196, 29);
            this.txtHoraFinalDeAtencion.TabIndex = 82;
            // 
            // txtHoraInicialDeAtancion
            // 
            this.txtHoraInicialDeAtancion.Animated = true;
            this.txtHoraInicialDeAtancion.BorderRadius = 12;
            this.txtHoraInicialDeAtancion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoraInicialDeAtancion.DefaultText = "";
            this.txtHoraInicialDeAtancion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoraInicialDeAtancion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoraInicialDeAtancion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraInicialDeAtancion.DisabledState.Parent = this.txtHoraInicialDeAtancion;
            this.txtHoraInicialDeAtancion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraInicialDeAtancion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraInicialDeAtancion.FocusedState.Parent = this.txtHoraInicialDeAtancion;
            this.txtHoraInicialDeAtancion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicialDeAtancion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraInicialDeAtancion.HoverState.Parent = this.txtHoraInicialDeAtancion;
            this.txtHoraInicialDeAtancion.Location = new System.Drawing.Point(352, 134);
            this.txtHoraInicialDeAtancion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoraInicialDeAtancion.Name = "txtHoraInicialDeAtancion";
            this.txtHoraInicialDeAtancion.PasswordChar = '\0';
            this.txtHoraInicialDeAtancion.PlaceholderText = "Digite la información";
            this.txtHoraInicialDeAtancion.SelectedText = "";
            this.txtHoraInicialDeAtancion.ShadowDecoration.Parent = this.txtHoraInicialDeAtancion;
            this.txtHoraInicialDeAtancion.Size = new System.Drawing.Size(196, 29);
            this.txtHoraInicialDeAtancion.TabIndex = 81;
            // 
            // lblNumeroHorario
            // 
            this.lblNumeroHorario.AllowParentOverrides = false;
            this.lblNumeroHorario.AutoEllipsis = false;
            this.lblNumeroHorario.CursorType = null;
            this.lblNumeroHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHorario.Location = new System.Drawing.Point(352, 96);
            this.lblNumeroHorario.Name = "lblNumeroHorario";
            this.lblNumeroHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumeroHorario.Size = new System.Drawing.Size(9, 20);
            this.lblNumeroHorario.TabIndex = 80;
            this.lblNumeroHorario.Text = "0";
            this.lblNumeroHorario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNumeroHorario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblHorario
            // 
            this.lblHorario.AllowParentOverrides = false;
            this.lblHorario.AutoEllipsis = false;
            this.lblHorario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHorario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(176, 96);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHorario.Size = new System.Drawing.Size(73, 20);
            this.lblHorario.TabIndex = 79;
            this.lblHorario.Text = "ID Horario";
            this.lblHorario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHorario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            // FrmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 431);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.PnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisponibilidadMedico";
            this.TopMost = true;
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel PnlSuperior;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Bunifu.UI.WinForms.BunifuLabel lblHoraFinalDeAtencion;
        private Bunifu.UI.WinForms.BunifuLabel lblHoraInicialDeAtencion;
        private Guna.UI2.WinForms.Guna2TextBox txtHoraFinalDeAtencion;
        private Guna.UI2.WinForms.Guna2TextBox txtHoraInicialDeAtancion;
        private Bunifu.UI.WinForms.BunifuLabel lblNumeroHorario;
        private Bunifu.UI.WinForms.BunifuLabel lblHorario;
    }
}