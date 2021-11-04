
namespace Presentacion
{
    partial class FrmAgendaMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendaMedico));
            this.pnlAgenda = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblNumeroAgenda = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblIdagenda = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFechafinal = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFechaInicial = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTTelefono = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTNombre = new System.Windows.Forms.Label();
            this.txtNumeroDeCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumeroCédula = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAgenda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptrAgenda = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgenda.Controls.Add(this.lblNumeroAgenda);
            this.pnlAgenda.Controls.Add(this.lblIdagenda);
            this.pnlAgenda.Controls.Add(this.lblFechafinal);
            this.pnlAgenda.Controls.Add(this.lblFechaInicial);
            this.pnlAgenda.Controls.Add(this.guna2DateTimePicker2);
            this.pnlAgenda.Controls.Add(this.guna2DateTimePicker1);
            this.pnlAgenda.Controls.Add(this.lblCodigo);
            this.pnlAgenda.Controls.Add(this.lblTCodigo);
            this.pnlAgenda.Controls.Add(this.btnEliminar);
            this.pnlAgenda.Controls.Add(this.btnAgendar);
            this.pnlAgenda.Controls.Add(this.lblTelefono);
            this.pnlAgenda.Controls.Add(this.lblTTelefono);
            this.pnlAgenda.Controls.Add(this.lblSexo);
            this.pnlAgenda.Controls.Add(this.lblTSexo);
            this.pnlAgenda.Controls.Add(this.lblNombre);
            this.pnlAgenda.Controls.Add(this.lblTNombre);
            this.pnlAgenda.Controls.Add(this.txtNumeroDeCedula);
            this.pnlAgenda.Controls.Add(this.lblNumeroCédula);
            this.pnlAgenda.Controls.Add(this.lblAgenda);
            this.pnlAgenda.Controls.Add(this.ptrAgenda);
            this.pnlAgenda.FillColor = System.Drawing.Color.White;
            this.pnlAgenda.Location = new System.Drawing.Point(27, 29);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.ShadowColor = System.Drawing.Color.Black;
            this.pnlAgenda.ShadowShift = 10;
            this.pnlAgenda.Size = new System.Drawing.Size(743, 616);
            this.pnlAgenda.TabIndex = 1;
            // 
            // lblNumeroAgenda
            // 
            this.lblNumeroAgenda.AllowParentOverrides = false;
            this.lblNumeroAgenda.AutoEllipsis = false;
            this.lblNumeroAgenda.CursorType = null;
            this.lblNumeroAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAgenda.Location = new System.Drawing.Point(177, 111);
            this.lblNumeroAgenda.Name = "lblNumeroAgenda";
            this.lblNumeroAgenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumeroAgenda.Size = new System.Drawing.Size(9, 20);
            this.lblNumeroAgenda.TabIndex = 72;
            this.lblNumeroAgenda.Text = "0";
            this.lblNumeroAgenda.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNumeroAgenda.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblIdagenda
            // 
            this.lblIdagenda.AllowParentOverrides = false;
            this.lblIdagenda.AutoEllipsis = false;
            this.lblIdagenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIdagenda.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblIdagenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdagenda.Location = new System.Drawing.Point(20, 111);
            this.lblIdagenda.Name = "lblIdagenda";
            this.lblIdagenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdagenda.Size = new System.Drawing.Size(75, 20);
            this.lblIdagenda.TabIndex = 71;
            this.lblIdagenda.Text = "ID agenda";
            this.lblIdagenda.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIdagenda.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFechafinal
            // 
            this.lblFechafinal.AllowParentOverrides = false;
            this.lblFechafinal.AutoEllipsis = false;
            this.lblFechafinal.CursorType = null;
            this.lblFechafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafinal.Location = new System.Drawing.Point(474, 244);
            this.lblFechafinal.Name = "lblFechafinal";
            this.lblFechafinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechafinal.Size = new System.Drawing.Size(165, 20);
            this.lblFechafinal.TabIndex = 70;
            this.lblFechafinal.Text = "Fecha final de atención";
            this.lblFechafinal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFechafinal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AllowParentOverrides = false;
            this.lblFechaInicial.AutoEllipsis = false;
            this.lblFechaInicial.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFechaInicial.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(474, 150);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaInicial.Size = new System.Drawing.Size(171, 20);
            this.lblFechaInicial.TabIndex = 69;
            this.lblFechaInicial.Text = "Fecha inicio de atención";
            this.lblFechaInicial.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFechaInicial.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderRadius = 12;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(474, 283);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(233, 36);
            this.guna2DateTimePicker2.TabIndex = 68;
            this.guna2DateTimePicker2.Value = new System.DateTime(2021, 10, 31, 14, 39, 50, 721);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 12;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(474, 189);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(229, 36);
            this.guna2DateTimePicker1.TabIndex = 67;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 10, 31, 14, 39, 50, 721);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(173, 187);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 61;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTCodigo
            // 
            this.lblTCodigo.AutoSize = true;
            this.lblTCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTCodigo.Location = new System.Drawing.Point(20, 184);
            this.lblTCodigo.Name = "lblTCodigo";
            this.lblTCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblTCodigo.TabIndex = 60;
            this.lblTCodigo.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.DisabledState.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(329, 554);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(171, 31);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnAgendar
            // 
            this.btnAgendar.BorderRadius = 13;
            this.btnAgendar.CheckedState.Parent = this.btnAgendar;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.CustomImages.Parent = this.btnAgendar;
            this.btnAgendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendar.DisabledState.Parent = this.btnAgendar;
            this.btnAgendar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.HoverState.Parent = this.btnAgendar;
            this.btnAgendar.Location = new System.Drawing.Point(532, 554);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.ShadowDecoration.Parent = this.btnAgendar;
            this.btnAgendar.Size = new System.Drawing.Size(171, 31);
            this.btnAgendar.TabIndex = 57;
            this.btnAgendar.Text = "Agendar";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelefono.Location = new System.Drawing.Point(173, 293);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblTTelefono
            // 
            this.lblTTelefono.AutoSize = true;
            this.lblTTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTTelefono.Location = new System.Drawing.Point(20, 292);
            this.lblTTelefono.Name = "lblTTelefono";
            this.lblTTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTTelefono.TabIndex = 53;
            this.lblTTelefono.Text = "Telefono:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexo.Location = new System.Drawing.Point(173, 256);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 52;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTSexo
            // 
            this.lblTSexo.AutoSize = true;
            this.lblTSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTSexo.Location = new System.Drawing.Point(20, 256);
            this.lblTSexo.Name = "lblTSexo";
            this.lblTSexo.Size = new System.Drawing.Size(49, 20);
            this.lblTSexo.TabIndex = 51;
            this.lblTSexo.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(173, 222);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTNombre
            // 
            this.lblTNombre.AutoSize = true;
            this.lblTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTNombre.Location = new System.Drawing.Point(20, 220);
            this.lblTNombre.Name = "lblTNombre";
            this.lblTNombre.Size = new System.Drawing.Size(69, 20);
            this.lblTNombre.TabIndex = 49;
            this.lblTNombre.Text = "Nombre:";
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
            this.txtNumeroDeCedula.Location = new System.Drawing.Point(175, 145);
            this.txtNumeroDeCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroDeCedula.Name = "txtNumeroDeCedula";
            this.txtNumeroDeCedula.PasswordChar = '\0';
            this.txtNumeroDeCedula.PlaceholderText = "Digite la información";
            this.txtNumeroDeCedula.SelectedText = "";
            this.txtNumeroDeCedula.ShadowDecoration.Parent = this.txtNumeroDeCedula;
            this.txtNumeroDeCedula.Size = new System.Drawing.Size(196, 29);
            this.txtNumeroDeCedula.TabIndex = 22;
            // 
            // lblNumeroCédula
            // 
            this.lblNumeroCédula.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroCédula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCédula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumeroCédula.Location = new System.Drawing.Point(20, 146);
            this.lblNumeroCédula.Name = "lblNumeroCédula";
            this.lblNumeroCédula.Size = new System.Drawing.Size(132, 22);
            this.lblNumeroCédula.TabIndex = 21;
            this.lblNumeroCédula.Text = "Número de cédula";
            // 
            // lblAgenda
            // 
            this.lblAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lblAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.lblAgenda.Location = new System.Drawing.Point(329, 64);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(175, 26);
            this.lblAgenda.TabIndex = 20;
            this.lblAgenda.Text = "AGENDAR MÉDICO";
            // 
            // ptrAgenda
            // 
            this.ptrAgenda.Image = ((System.Drawing.Image)(resources.GetObject("ptrAgenda.Image")));
            this.ptrAgenda.ImageRotate = 0F;
            this.ptrAgenda.Location = new System.Drawing.Point(273, 25);
            this.ptrAgenda.Name = "ptrAgenda";
            this.ptrAgenda.ShadowDecoration.Parent = this.ptrAgenda;
            this.ptrAgenda.Size = new System.Drawing.Size(61, 65);
            this.ptrAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrAgenda.TabIndex = 19;
            this.ptrAgenda.TabStop = false;
            // 
            // FrmAgendaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.pnlAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgendaMedico";
            this.Text = "Form1";
            this.pnlAgenda.ResumeLayout(false);
            this.pnlAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAgenda;
        private Guna.UI2.WinForms.Guna2PictureBox ptrAgenda;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAgenda;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroDeCedula;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumeroCédula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTTelefono;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTSexo;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTCodigo;
        private Bunifu.UI.WinForms.BunifuLabel lblFechaInicial;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Bunifu.UI.WinForms.BunifuLabel lblNumeroAgenda;
        private Bunifu.UI.WinForms.BunifuLabel lblIdagenda;
        private Bunifu.UI.WinForms.BunifuLabel lblFechafinal;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
    }
}