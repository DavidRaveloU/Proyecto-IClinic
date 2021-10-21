
namespace Presentacion
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAgenda = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptrAgenda = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblAgenda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNumeroDeCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumeroCédula = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTNombre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTSexo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTTelefono = new System.Windows.Forms.Label();
            this.dtgAgenda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTCodigo = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtHora = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTHora = new System.Windows.Forms.Label();
            this.dtgMedico = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblCitas = new System.Windows.Forms.Label();
            this.bntEditar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.BackColor = System.Drawing.Color.Transparent;
            this.pnlAgenda.Controls.Add(this.bntEditar);
            this.pnlAgenda.Controls.Add(this.lblCitas);
            this.pnlAgenda.Controls.Add(this.lblMedicos);
            this.pnlAgenda.Controls.Add(this.dtgMedico);
            this.pnlAgenda.Controls.Add(this.lblTHora);
            this.pnlAgenda.Controls.Add(this.txtHora);
            this.pnlAgenda.Controls.Add(this.lblCodigo);
            this.pnlAgenda.Controls.Add(this.lblTCodigo);
            this.pnlAgenda.Controls.Add(this.btnModificar);
            this.pnlAgenda.Controls.Add(this.btnEliminar);
            this.pnlAgenda.Controls.Add(this.btnAgendar);
            this.pnlAgenda.Controls.Add(this.dtgAgenda);
            this.pnlAgenda.Controls.Add(this.monthCalendar1);
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
            // ptrAgenda
            // 
            this.ptrAgenda.Image = ((System.Drawing.Image)(resources.GetObject("ptrAgenda.Image")));
            this.ptrAgenda.ImageRotate = 0F;
            this.ptrAgenda.Location = new System.Drawing.Point(328, 25);
            this.ptrAgenda.Name = "ptrAgenda";
            this.ptrAgenda.ShadowDecoration.Parent = this.ptrAgenda;
            this.ptrAgenda.Size = new System.Drawing.Size(61, 65);
            this.ptrAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrAgenda.TabIndex = 19;
            this.ptrAgenda.TabStop = false;
            // 
            // lblAgenda
            // 
            this.lblAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lblAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.lblAgenda.Location = new System.Drawing.Point(395, 64);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(83, 26);
            this.lblAgenda.TabIndex = 20;
            this.lblAgenda.Text = "AGENDA";
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
            this.txtNumeroDeCedula.Location = new System.Drawing.Point(177, 111);
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
            this.lblNumeroCédula.Location = new System.Drawing.Point(24, 118);
            this.lblNumeroCédula.Name = "lblNumeroCédula";
            this.lblNumeroCédula.Size = new System.Drawing.Size(132, 22);
            this.lblNumeroCédula.TabIndex = 21;
            this.lblNumeroCédula.Text = "Número de cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(173, 194);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTNombre
            // 
            this.lblTNombre.AutoSize = true;
            this.lblTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTNombre.Location = new System.Drawing.Point(20, 194);
            this.lblTNombre.Name = "lblTNombre";
            this.lblTNombre.Size = new System.Drawing.Size(69, 20);
            this.lblTNombre.TabIndex = 49;
            this.lblTNombre.Text = "Nombre:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexo.Location = new System.Drawing.Point(173, 228);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 52;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTSexo
            // 
            this.lblTSexo.AutoSize = true;
            this.lblTSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTSexo.Location = new System.Drawing.Point(20, 228);
            this.lblTSexo.Name = "lblTSexo";
            this.lblTSexo.Size = new System.Drawing.Size(49, 20);
            this.lblTSexo.TabIndex = 51;
            this.lblTSexo.Text = "Sexo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelefono.Location = new System.Drawing.Point(173, 265);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblTTelefono
            // 
            this.lblTTelefono.AutoSize = true;
            this.lblTTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTTelefono.Location = new System.Drawing.Point(20, 265);
            this.lblTTelefono.Name = "lblTTelefono";
            this.lblTTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTTelefono.TabIndex = 53;
            this.lblTTelefono.Text = "Telefono:";
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dtgAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAgenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgAgenda.EnableHeadersVisualStyles = false;
            this.dtgAgenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgAgenda.Location = new System.Drawing.Point(27, 459);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.ReadOnly = true;
            this.dtgAgenda.RowHeadersVisible = false;
            this.dtgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgenda.Size = new System.Drawing.Size(672, 86);
            this.dtgAgenda.TabIndex = 56;
            this.dtgAgenda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgAgenda.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgAgenda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgAgenda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgAgenda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgAgenda.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgAgenda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgAgenda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgAgenda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgAgenda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgAgenda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgAgenda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgAgenda.ThemeStyle.ReadOnly = true;
            this.dtgAgenda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgAgenda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgAgenda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgAgenda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgAgenda.ThemeStyle.RowsStyle.Height = 22;
            this.dtgAgenda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgAgenda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnAgendar.Location = new System.Drawing.Point(525, 565);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.ShadowDecoration.Parent = this.btnAgendar;
            this.btnAgendar.Size = new System.Drawing.Size(171, 31);
            this.btnAgendar.TabIndex = 57;
            this.btnAgendar.Text = "Agendar";
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
            this.btnEliminar.Location = new System.Drawing.Point(24, 565);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(171, 31);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 13;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.DisabledState.Parent = this.btnModificar;
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(191)))), ((int)(((byte)(250)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Location = new System.Drawing.Point(280, 565);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(171, 31);
            this.btnModificar.TabIndex = 59;
            this.btnModificar.Text = "Modificar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(173, 159);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 61;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTCodigo
            // 
            this.lblTCodigo.AutoSize = true;
            this.lblTCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTCodigo.Location = new System.Drawing.Point(20, 159);
            this.lblTCodigo.Name = "lblTCodigo";
            this.lblTCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblTCodigo.TabIndex = 60;
            this.lblTCodigo.Text = "Codigo:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(524, 111);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 55;
            // 
            // txtHora
            // 
            this.txtHora.Animated = true;
            this.txtHora.BorderRadius = 12;
            this.txtHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHora.DefaultText = "";
            this.txtHora.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHora.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHora.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHora.DisabledState.Parent = this.txtHora;
            this.txtHora.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHora.FocusedState.Parent = this.txtHora;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHora.HoverState.Parent = this.txtHora;
            this.txtHora.Location = new System.Drawing.Point(571, 286);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.PlaceholderText = "Digite la hora";
            this.txtHora.SelectedText = "";
            this.txtHora.ShadowDecoration.Parent = this.txtHora;
            this.txtHora.Size = new System.Drawing.Size(111, 24);
            this.txtHora.TabIndex = 62;
            // 
            // lblTHora
            // 
            this.lblTHora.AutoSize = true;
            this.lblTHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTHora.Location = new System.Drawing.Point(520, 290);
            this.lblTHora.Name = "lblTHora";
            this.lblTHora.Size = new System.Drawing.Size(48, 20);
            this.lblTHora.TabIndex = 63;
            this.lblTHora.Text = "Hora:";
            // 
            // dtgMedico
            // 
            this.dtgMedico.AllowUserToAddRows = false;
            this.dtgMedico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgMedico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedico.BackgroundColor = System.Drawing.Color.White;
            this.dtgMedico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgMedico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMedico.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMedico.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMedico.EnableHeadersVisualStyles = false;
            this.dtgMedico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgMedico.Location = new System.Drawing.Point(27, 353);
            this.dtgMedico.Name = "dtgMedico";
            this.dtgMedico.ReadOnly = true;
            this.dtgMedico.RowHeadersVisible = false;
            this.dtgMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedico.Size = new System.Drawing.Size(672, 77);
            this.dtgMedico.TabIndex = 64;
            this.dtgMedico.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgMedico.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgMedico.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgMedico.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgMedico.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgMedico.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgMedico.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgMedico.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgMedico.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgMedico.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgMedico.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgMedico.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgMedico.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgMedico.ThemeStyle.ReadOnly = true;
            this.dtgMedico.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgMedico.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgMedico.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgMedico.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgMedico.ThemeStyle.RowsStyle.Height = 22;
            this.dtgMedico.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgMedico.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicos.Location = new System.Drawing.Point(278, 330);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(173, 20);
            this.lblMedicos.TabIndex = 65;
            this.lblMedicos.Text = "Medicos Disponibles";
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(334, 436);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(55, 20);
            this.lblCitas.TabIndex = 66;
            this.lblCitas.Text = "Citas:";
            // 
            // bntEditar
            // 
            this.bntEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntEditar.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.bntEditar.BorderThickness = 2;
            this.bntEditar.CheckedState.Parent = this.bntEditar;
            this.bntEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntEditar.CustomImages.Parent = this.bntEditar;
            this.bntEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntEditar.DisabledState.Parent = this.bntEditar;
            this.bntEditar.FillColor = System.Drawing.Color.Transparent;
            this.bntEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEditar.ForeColor = System.Drawing.Color.Black;
            this.bntEditar.HoverState.Parent = this.bntEditar;
            this.bntEditar.Location = new System.Drawing.Point(499, 327);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.ShadowDecoration.Parent = this.bntEditar;
            this.bntEditar.Size = new System.Drawing.Size(69, 23);
            this.bntEditar.TabIndex = 67;
            this.bntEditar.Text = "Editar";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.pnlAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.Text = "Form1";
            this.pnlAgenda.ResumeLayout(false);
            this.pnlAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedico)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dtgAgenda;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTCodigo;
        private System.Windows.Forms.Label lblTHora;
        private Guna.UI2.WinForms.Guna2TextBox txtHora;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgMedico;
        private Guna.UI2.WinForms.Guna2Button bntEditar;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Label lblMedicos;
    }
}