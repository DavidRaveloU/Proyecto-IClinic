
namespace Presentacion
{
    partial class FrmConsultarMedico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarMedico));
            this.pnlFondoConsultarMedico = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtConsulta = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.dtgConsultarMedicos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.pnlCantidadDeMedicos = new System.Windows.Forms.Panel();
            this.lblCantidadDeMedicos = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.pnlLineaSeparadora = new System.Windows.Forms.Panel();
            this.ptrCantidadDeMedicos = new System.Windows.Forms.PictureBox();
            this.pnlFondoConsultarMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultarMedicos)).BeginInit();
            this.pnlCantidadDeMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondoConsultarMedico
            // 
            this.pnlFondoConsultarMedico.BackColor = System.Drawing.Color.Transparent;
            this.pnlFondoConsultarMedico.Controls.Add(this.txtConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.btnModificar);
            this.pnlFondoConsultarMedico.Controls.Add(this.dtgConsultarMedicos);
            this.pnlFondoConsultarMedico.Controls.Add(this.lblConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.pnlCantidadDeMedicos);
            this.pnlFondoConsultarMedico.FillColor = System.Drawing.Color.White;
            this.pnlFondoConsultarMedico.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFondoConsultarMedico.Location = new System.Drawing.Point(25, 30);
            this.pnlFondoConsultarMedico.Name = "pnlFondoConsultarMedico";
            this.pnlFondoConsultarMedico.ShadowColor = System.Drawing.Color.Black;
            this.pnlFondoConsultarMedico.ShadowShift = 10;
            this.pnlFondoConsultarMedico.Size = new System.Drawing.Size(754, 616);
            this.pnlFondoConsultarMedico.TabIndex = 1;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Animated = true;
            this.txtConsulta.BorderColor = System.Drawing.Color.Black;
            this.txtConsulta.BorderRadius = 12;
            this.txtConsulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsulta.DefaultText = "";
            this.txtConsulta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsulta.DisabledState.Parent = this.txtConsulta;
            this.txtConsulta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsulta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsulta.FocusedState.Parent = this.txtConsulta;
            this.txtConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsulta.HoverState.Parent = this.txtConsulta;
            this.txtConsulta.Location = new System.Drawing.Point(155, 170);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.PasswordChar = '\0';
            this.txtConsulta.PlaceholderText = "Digite número de cédula";
            this.txtConsulta.SelectedText = "";
            this.txtConsulta.ShadowDecoration.Parent = this.txtConsulta;
            this.txtConsulta.Size = new System.Drawing.Size(408, 29);
            this.txtConsulta.TabIndex = 9;
            this.txtConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsulta_KeyUp);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 13;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
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
            this.btnModificar.Location = new System.Drawing.Point(525, 546);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(171, 31);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            // 
            // dtgConsultarMedicos
            // 
            this.dtgConsultarMedicos.AllowUserToAddRows = false;
            this.dtgConsultarMedicos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgConsultarMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsultarMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgConsultarMedicos.BackgroundColor = System.Drawing.Color.White;
            this.dtgConsultarMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultarMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsultarMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultarMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultarMedicos.ColumnHeadersHeight = 25;
            this.dtgConsultarMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCedula,
            this.ColumnPrimerNombre,
            this.ColumnSegundoNombre,
            this.ColumnPrimerApellido,
            this.ColumnSegundoApellido,
            this.ColumnTelefono,
            this.ColumnCorreo,
            this.ColumnDireccion,
            this.ColumnSexo,
            this.ColumnCiudad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsultarMedicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsultarMedicos.EnableHeadersVisualStyles = false;
            this.dtgConsultarMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.dtgConsultarMedicos.Location = new System.Drawing.Point(40, 229);
            this.dtgConsultarMedicos.Name = "dtgConsultarMedicos";
            this.dtgConsultarMedicos.ReadOnly = true;
            this.dtgConsultarMedicos.RowHeadersVisible = false;
            this.dtgConsultarMedicos.RowHeadersWidth = 40;
            this.dtgConsultarMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultarMedicos.Size = new System.Drawing.Size(656, 288);
            this.dtgConsultarMedicos.TabIndex = 3;
            this.dtgConsultarMedicos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsultarMedicos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgConsultarMedicos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgConsultarMedicos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgConsultarMedicos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgConsultarMedicos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsultarMedicos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.dtgConsultarMedicos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.dtgConsultarMedicos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgConsultarMedicos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgConsultarMedicos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgConsultarMedicos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgConsultarMedicos.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgConsultarMedicos.ThemeStyle.ReadOnly = true;
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.Height = 22;
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsultarMedicos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnCedula
            // 
            this.ColumnCedula.HeaderText = "Cedula";
            this.ColumnCedula.Name = "ColumnCedula";
            this.ColumnCedula.ReadOnly = true;
            this.ColumnCedula.Width = 74;
            // 
            // ColumnPrimerNombre
            // 
            this.ColumnPrimerNombre.HeaderText = "Primer nombre";
            this.ColumnPrimerNombre.Name = "ColumnPrimerNombre";
            this.ColumnPrimerNombre.ReadOnly = true;
            this.ColumnPrimerNombre.Width = 124;
            // 
            // ColumnSegundoNombre
            // 
            this.ColumnSegundoNombre.HeaderText = "Segundo nombre";
            this.ColumnSegundoNombre.Name = "ColumnSegundoNombre";
            this.ColumnSegundoNombre.ReadOnly = true;
            this.ColumnSegundoNombre.Width = 138;
            // 
            // ColumnPrimerApellido
            // 
            this.ColumnPrimerApellido.HeaderText = "Primer apellido";
            this.ColumnPrimerApellido.Name = "ColumnPrimerApellido";
            this.ColumnPrimerApellido.ReadOnly = true;
            this.ColumnPrimerApellido.Width = 123;
            // 
            // ColumnSegundoApellido
            // 
            this.ColumnSegundoApellido.HeaderText = "Segundo apellido";
            this.ColumnSegundoApellido.Name = "ColumnSegundoApellido";
            this.ColumnSegundoApellido.ReadOnly = true;
            this.ColumnSegundoApellido.Width = 137;
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            this.ColumnTelefono.ReadOnly = true;
            this.ColumnTelefono.Width = 83;
            // 
            // ColumnCorreo
            // 
            this.ColumnCorreo.HeaderText = "Correo";
            this.ColumnCorreo.Name = "ColumnCorreo";
            this.ColumnCorreo.ReadOnly = true;
            this.ColumnCorreo.Width = 74;
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            this.ColumnDireccion.ReadOnly = true;
            this.ColumnDireccion.Width = 88;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            this.ColumnSexo.Width = 60;
            // 
            // ColumnCiudad
            // 
            this.ColumnCiudad.HeaderText = "Ciudad";
            this.ColumnCiudad.Name = "ColumnCiudad";
            this.ColumnCiudad.ReadOnly = true;
            this.ColumnCiudad.Width = 75;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblConsulta.Location = new System.Drawing.Point(58, 172);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(93, 26);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = "Consulta";
            // 
            // pnlCantidadDeMedicos
            // 
            this.pnlCantidadDeMedicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCantidadDeMedicos.BackgroundImage")));
            this.pnlCantidadDeMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCantidadDeMedicos.Controls.Add(this.lblCantidadDeMedicos);
            this.pnlCantidadDeMedicos.Controls.Add(this.lblMedico);
            this.pnlCantidadDeMedicos.Controls.Add(this.pnlLineaSeparadora);
            this.pnlCantidadDeMedicos.Controls.Add(this.ptrCantidadDeMedicos);
            this.pnlCantidadDeMedicos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCantidadDeMedicos.Location = new System.Drawing.Point(40, 24);
            this.pnlCantidadDeMedicos.Name = "pnlCantidadDeMedicos";
            this.pnlCantidadDeMedicos.Size = new System.Drawing.Size(222, 91);
            this.pnlCantidadDeMedicos.TabIndex = 0;
            // 
            // lblCantidadDeMedicos
            // 
            this.lblCantidadDeMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeMedicos.Location = new System.Drawing.Point(61, 21);
            this.lblCantidadDeMedicos.Name = "lblCantidadDeMedicos";
            this.lblCantidadDeMedicos.Size = new System.Drawing.Size(142, 32);
            this.lblCantidadDeMedicos.TabIndex = 3;
            this.lblCantidadDeMedicos.Text = "0";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(15, 59);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(158, 20);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Cantidad de médicos";
            // 
            // pnlLineaSeparadora
            // 
            this.pnlLineaSeparadora.BackColor = System.Drawing.Color.Black;
            this.pnlLineaSeparadora.Location = new System.Drawing.Point(13, 56);
            this.pnlLineaSeparadora.Name = "pnlLineaSeparadora";
            this.pnlLineaSeparadora.Size = new System.Drawing.Size(190, 1);
            this.pnlLineaSeparadora.TabIndex = 1;
            // 
            // ptrCantidadDeMedicos
            // 
            this.ptrCantidadDeMedicos.Image = ((System.Drawing.Image)(resources.GetObject("ptrCantidadDeMedicos.Image")));
            this.ptrCantidadDeMedicos.Location = new System.Drawing.Point(12, 5);
            this.ptrCantidadDeMedicos.Name = "ptrCantidadDeMedicos";
            this.ptrCantidadDeMedicos.Size = new System.Drawing.Size(46, 50);
            this.ptrCantidadDeMedicos.TabIndex = 0;
            this.ptrCantidadDeMedicos.TabStop = false;
            // 
            // FrmConsultarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.pnlFondoConsultarMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarMedico";
            this.Text = "FrmConsultarMedico";
            this.pnlFondoConsultarMedico.ResumeLayout(false);
            this.pnlFondoConsultarMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultarMedicos)).EndInit();
            this.pnlCantidadDeMedicos.ResumeLayout(false);
            this.pnlCantidadDeMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFondoConsultarMedico;
        private System.Windows.Forms.Panel pnlCantidadDeMedicos;
        private System.Windows.Forms.Label lblCantidadDeMedicos;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Panel pnlLineaSeparadora;
        private System.Windows.Forms.PictureBox ptrCantidadDeMedicos;
        private System.Windows.Forms.Label lblConsulta;
        private Guna.UI2.WinForms.Guna2DataGridView dtgConsultarMedicos;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCiudad;
    }
}