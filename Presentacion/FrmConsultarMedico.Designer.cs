
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFondoConsultarMedico = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlCantidadDeMedicos = new System.Windows.Forms.Panel();
            this.ptrCantidadDeMedicos = new System.Windows.Forms.PictureBox();
            this.pnlLineaSeparadora = new System.Windows.Forms.Panel();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblCantidadDeMedicos = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.pnlConsulta = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptrConsulta = new System.Windows.Forms.PictureBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dtgConsulta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFondoConsultarMedico.SuspendLayout();
            this.pnlCantidadDeMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).BeginInit();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondoConsultarMedico
            // 
            this.pnlFondoConsultarMedico.BackColor = System.Drawing.Color.Transparent;
            this.pnlFondoConsultarMedico.Controls.Add(this.btnEliminar);
            this.pnlFondoConsultarMedico.Controls.Add(this.btnModificar);
            this.pnlFondoConsultarMedico.Controls.Add(this.dtgConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.pnlConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.lblConsulta);
            this.pnlFondoConsultarMedico.Controls.Add(this.pnlCantidadDeMedicos);
            this.pnlFondoConsultarMedico.FillColor = System.Drawing.Color.White;
            this.pnlFondoConsultarMedico.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFondoConsultarMedico.Location = new System.Drawing.Point(38, 30);
            this.pnlFondoConsultarMedico.Name = "pnlFondoConsultarMedico";
            this.pnlFondoConsultarMedico.ShadowColor = System.Drawing.Color.DimGray;
            this.pnlFondoConsultarMedico.ShadowShift = 6;
            this.pnlFondoConsultarMedico.Size = new System.Drawing.Size(722, 616);
            this.pnlFondoConsultarMedico.TabIndex = 1;
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
            // ptrCantidadDeMedicos
            // 
            this.ptrCantidadDeMedicos.Image = ((System.Drawing.Image)(resources.GetObject("ptrCantidadDeMedicos.Image")));
            this.ptrCantidadDeMedicos.Location = new System.Drawing.Point(12, 5);
            this.ptrCantidadDeMedicos.Name = "ptrCantidadDeMedicos";
            this.ptrCantidadDeMedicos.Size = new System.Drawing.Size(46, 50);
            this.ptrCantidadDeMedicos.TabIndex = 0;
            this.ptrCantidadDeMedicos.TabStop = false;
            // 
            // pnlLineaSeparadora
            // 
            this.pnlLineaSeparadora.BackColor = System.Drawing.Color.Black;
            this.pnlLineaSeparadora.Location = new System.Drawing.Point(13, 56);
            this.pnlLineaSeparadora.Name = "pnlLineaSeparadora";
            this.pnlLineaSeparadora.Size = new System.Drawing.Size(190, 1);
            this.pnlLineaSeparadora.TabIndex = 1;
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
            // lblCantidadDeMedicos
            // 
            this.lblCantidadDeMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeMedicos.Location = new System.Drawing.Point(61, 21);
            this.lblCantidadDeMedicos.Name = "lblCantidadDeMedicos";
            this.lblCantidadDeMedicos.Size = new System.Drawing.Size(142, 32);
            this.lblCantidadDeMedicos.TabIndex = 3;
            this.lblCantidadDeMedicos.Text = "0";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConsulta.Location = new System.Drawing.Point(56, 170);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(93, 26);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = "Consulta";
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsulta.Controls.Add(this.ptrConsulta);
            this.pnlConsulta.Controls.Add(this.txtConsulta);
            this.pnlConsulta.FillColor = System.Drawing.Color.White;
            this.pnlConsulta.Location = new System.Drawing.Point(148, 160);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Radius = 10;
            this.pnlConsulta.ShadowColor = System.Drawing.Color.DimGray;
            this.pnlConsulta.ShadowDepth = 44;
            this.pnlConsulta.ShadowShift = 4;
            this.pnlConsulta.Size = new System.Drawing.Size(471, 44);
            this.pnlConsulta.TabIndex = 2;
            // 
            // ptrConsulta
            // 
            this.ptrConsulta.Image = ((System.Drawing.Image)(resources.GetObject("ptrConsulta.Image")));
            this.ptrConsulta.Location = new System.Drawing.Point(427, 10);
            this.ptrConsulta.Name = "ptrConsulta";
            this.ptrConsulta.Size = new System.Drawing.Size(25, 24);
            this.ptrConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrConsulta.TabIndex = 3;
            this.ptrConsulta.TabStop = false;
            // 
            // txtConsulta
            // 
            this.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(21, 11);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(400, 24);
            this.txtConsulta.TabIndex = 2;
            // 
            // dtgConsulta
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dtgConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dtgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dtgConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsulta.DefaultCellStyle = dataGridViewCellStyle30;
            this.dtgConsulta.EnableHeadersVisualStyles = false;
            this.dtgConsulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsulta.Location = new System.Drawing.Point(61, 219);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.RowHeadersVisible = false;
            this.dtgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsulta.Size = new System.Drawing.Size(600, 288);
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
            this.dtgConsulta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Location = new System.Drawing.Point(282, 542);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(180, 45);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
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
            this.btnEliminar.Location = new System.Drawing.Point(490, 542);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(180, 45);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
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
            this.pnlCantidadDeMedicos.ResumeLayout(false);
            this.pnlCantidadDeMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).EndInit();
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlConsulta;
        private System.Windows.Forms.PictureBox ptrConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private Guna.UI2.WinForms.Guna2DataGridView dtgConsulta;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
    }
}