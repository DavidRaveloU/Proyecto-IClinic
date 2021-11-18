
namespace Presentacion
{
    partial class FrmAgendaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendaCita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAgenda = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNombreMedico = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblNumeroAgenda = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblIdagenda = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFechaInicial = new Bunifu.UI.WinForms.BunifuLabel();
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
            this.ptrAgendaCita = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgendaCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgenda.Controls.Add(this.guna2DataGridView1);
            this.pnlAgenda.Controls.Add(this.guna2ComboBox1);
            this.pnlAgenda.Controls.Add(this.lblNombreMedico);
            this.pnlAgenda.Controls.Add(this.lblNumeroAgenda);
            this.pnlAgenda.Controls.Add(this.lblIdagenda);
            this.pnlAgenda.Controls.Add(this.lblFechaInicial);
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
            this.pnlAgenda.Controls.Add(this.ptrAgendaCita);
            this.pnlAgenda.FillColor = System.Drawing.Color.White;
            this.pnlAgenda.Location = new System.Drawing.Point(28, 30);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.ShadowColor = System.Drawing.Color.Black;
            this.pnlAgenda.ShadowShift = 10;
            this.pnlAgenda.Size = new System.Drawing.Size(743, 616);
            this.pnlAgenda.TabIndex = 2;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 12;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(474, 292);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(229, 36);
            this.guna2ComboBox1.TabIndex = 76;
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AllowParentOverrides = false;
            this.lblNombreMedico.AutoEllipsis = false;
            this.lblNombreMedico.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNombreMedico.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedico.Location = new System.Drawing.Point(474, 256);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreMedico.Size = new System.Drawing.Size(142, 20);
            this.lblNombreMedico.TabIndex = 75;
            this.lblNombreMedico.Text = "Médicos disponibles";
            this.lblNombreMedico.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombreMedico.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lblIdagenda.Size = new System.Drawing.Size(46, 20);
            this.lblIdagenda.TabIndex = 71;
            this.lblIdagenda.Text = "ID cita";
            this.lblIdagenda.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIdagenda.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lblFechaInicial.Size = new System.Drawing.Size(132, 20);
            this.lblFechaInicial.TabIndex = 69;
            this.lblFechaInicial.Text = "Fecha  de atención";
            this.lblFechaInicial.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFechaInicial.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.btnEliminar.Location = new System.Drawing.Point(346, 562);
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
            this.btnAgendar.Location = new System.Drawing.Point(550, 562);
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
            this.lblAgenda.Location = new System.Drawing.Point(328, 66);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(143, 26);
            this.lblAgenda.TabIndex = 20;
            this.lblAgenda.Text = "AGENDAR CITA \r\n";
            // 
            // ptrAgendaCita
            // 
            this.ptrAgendaCita.Image = ((System.Drawing.Image)(resources.GetObject("ptrAgendaCita.Image")));
            this.ptrAgendaCita.ImageRotate = 0F;
            this.ptrAgendaCita.Location = new System.Drawing.Point(267, 37);
            this.ptrAgendaCita.Name = "ptrAgendaCita";
            this.ptrAgendaCita.ShadowDecoration.Parent = this.ptrAgendaCita;
            this.ptrAgendaCita.Size = new System.Drawing.Size(61, 65);
            this.ptrAgendaCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrAgendaCita.TabIndex = 19;
            this.ptrAgendaCita.TabStop = false;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnFechaAtencion,
            this.ColumnHora,
            this.ColumnSeleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(20, 344);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(683, 187);
            this.guna2DataGridView1.TabIndex = 77;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnFechaAtencion
            // 
            this.ColumnFechaAtencion.HeaderText = "Fecha de atención";
            this.ColumnFechaAtencion.Name = "ColumnFechaAtencion";
            this.ColumnFechaAtencion.ReadOnly = true;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora de atención";
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            // 
            // ColumnSeleccionar
            // 
            this.ColumnSeleccionar.HeaderText = "";
            this.ColumnSeleccionar.Name = "ColumnSeleccionar";
            this.ColumnSeleccionar.ReadOnly = true;
            // 
            // FrmAgendaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.pnlAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgendaCita";
            this.Text = "FrmAgendaCita";
            this.pnlAgenda.ResumeLayout(false);
            this.pnlAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgendaCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAgenda;
        private Bunifu.UI.WinForms.BunifuLabel lblNumeroAgenda;
        private Bunifu.UI.WinForms.BunifuLabel lblIdagenda;
        private Bunifu.UI.WinForms.BunifuLabel lblFechaInicial;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTCodigo;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTTelefono;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroDeCedula;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumeroCédula;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAgenda;
        private Guna.UI2.WinForms.Guna2PictureBox ptrAgendaCita;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblNombreMedico;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeleccionar;
    }
}