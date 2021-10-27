
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarMedico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFondoConsultarMedico = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnEstado = new Guna.UI2.WinForms.Guna2Button();
            this.txtConsulta = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.ptrConsulta = new System.Windows.Forms.PictureBox();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.dtgConsulta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.pnlCantidadDeMedicos = new System.Windows.Forms.Panel();
            this.lblCantidadDeMedicos = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.pnlLineaSeparadora = new System.Windows.Forms.Panel();
            this.ptrCantidadDeMedicos = new System.Windows.Forms.PictureBox();
            this.pnlFondoConsultarMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.pnlCantidadDeMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondoConsultarMedico
            // 
            this.pnlFondoConsultarMedico.BackColor = System.Drawing.Color.Transparent;
            this.pnlFondoConsultarMedico.Controls.Add(this.btnEstado);
            this.pnlFondoConsultarMedico.Controls.Add(this.txtConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.btnEliminar);
            this.pnlFondoConsultarMedico.Controls.Add(this.ptrConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.btnModificar);
            this.pnlFondoConsultarMedico.Controls.Add(this.dtgConsulta);
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
            // btnEstado
            // 
            this.btnEstado.BorderRadius = 13;
            this.btnEstado.CheckedState.Parent = this.btnEstado;
            this.btnEstado.CustomImages.Parent = this.btnEstado;
            this.btnEstado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstado.DisabledState.Parent = this.btnEstado;
            this.btnEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(191)))), ((int)(((byte)(250)))));
            this.btnEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.HoverState.Parent = this.btnEstado;
            this.btnEstado.Location = new System.Drawing.Point(290, 546);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.ShadowDecoration.Parent = this.btnEstado;
            this.btnEstado.Size = new System.Drawing.Size(171, 31);
            this.btnEstado.TabIndex = 69;
            this.btnEstado.Text = "Disponibilidad";
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
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
            this.btnEliminar.Location = new System.Drawing.Point(52, 546);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(171, 31);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ptrConsulta
            // 
            this.ptrConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrConsulta.Image = ((System.Drawing.Image)(resources.GetObject("ptrConsulta.Image")));
            this.ptrConsulta.Location = new System.Drawing.Point(569, 172);
            this.ptrConsulta.Name = "ptrConsulta";
            this.ptrConsulta.Size = new System.Drawing.Size(31, 27);
            this.ptrConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrConsulta.TabIndex = 3;
            this.ptrConsulta.TabStop = false;
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
            // dtgConsulta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dtgConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsulta.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsulta.EnableHeadersVisualStyles = false;
            this.dtgConsulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsulta.Location = new System.Drawing.Point(40, 229);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.RowHeadersVisible = false;
            this.dtgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsulta.Size = new System.Drawing.Size(656, 288);
            this.dtgConsulta.TabIndex = 3;
            this.dtgConsulta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsulta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgConsulta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgConsulta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgConsulta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgConsulta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsulta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsulta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgConsulta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgConsulta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgConsulta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgConsulta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgConsulta.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgConsulta.ThemeStyle.ReadOnly = false;
            this.dtgConsulta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsulta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsulta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgConsulta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgConsulta.ThemeStyle.RowsStyle.Height = 22;
            this.dtgConsulta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsulta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.ptrConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
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
        private System.Windows.Forms.PictureBox ptrConsulta;
        private Guna.UI2.WinForms.Guna2DataGridView dtgConsulta;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtConsulta;
        private Guna.UI2.WinForms.Guna2Button btnEstado;
    }
}