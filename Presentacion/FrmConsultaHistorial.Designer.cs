
namespace Presentacion
{
    partial class FrmConsultaHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaHistorial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCantidadDeHistoriales = new System.Windows.Forms.Label();
            this.pnlCantidadDeMedicos = new System.Windows.Forms.Panel();
            this.lblMedico = new System.Windows.Forms.Label();
            this.pnlLineaSeparadora = new System.Windows.Forms.Panel();
            this.ptrCantidadDeMedicos = new System.Windows.Forms.PictureBox();
            this.txtConsulta = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptrConsulta = new System.Windows.Forms.PictureBox();
            this.dtgConsulta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnGenerarPDF = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlCantidadDeMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnGenerarPDF);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(27, 28);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(743, 616);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // lblCantidadDeHistoriales
            // 
            this.lblCantidadDeHistoriales.BackColor = System.Drawing.Color.White;
            this.lblCantidadDeHistoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeHistoriales.Location = new System.Drawing.Point(61, 21);
            this.lblCantidadDeHistoriales.Name = "lblCantidadDeHistoriales";
            this.lblCantidadDeHistoriales.Size = new System.Drawing.Size(142, 32);
            this.lblCantidadDeHistoriales.TabIndex = 3;
            this.lblCantidadDeHistoriales.Text = "0";
            // 
            // pnlCantidadDeMedicos
            // 
            this.pnlCantidadDeMedicos.BackColor = System.Drawing.Color.White;
            this.pnlCantidadDeMedicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCantidadDeMedicos.BackgroundImage")));
            this.pnlCantidadDeMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCantidadDeMedicos.Controls.Add(this.lblCantidadDeHistoriales);
            this.pnlCantidadDeMedicos.Controls.Add(this.lblMedico);
            this.pnlCantidadDeMedicos.Controls.Add(this.pnlLineaSeparadora);
            this.pnlCantidadDeMedicos.Controls.Add(this.ptrCantidadDeMedicos);
            this.pnlCantidadDeMedicos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCantidadDeMedicos.Location = new System.Drawing.Point(71, 92);
            this.pnlCantidadDeMedicos.Name = "pnlCantidadDeMedicos";
            this.pnlCantidadDeMedicos.Size = new System.Drawing.Size(222, 91);
            this.pnlCantidadDeMedicos.TabIndex = 10;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.White;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(15, 59);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(170, 20);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Cantidad de historiales";
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
            this.ptrCantidadDeMedicos.Location = new System.Drawing.Point(8, 3);
            this.ptrCantidadDeMedicos.Name = "ptrCantidadDeMedicos";
            this.ptrCantidadDeMedicos.Size = new System.Drawing.Size(47, 52);
            this.ptrCantidadDeMedicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrCantidadDeMedicos.TabIndex = 0;
            this.ptrCantidadDeMedicos.TabStop = false;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Animated = true;
            this.txtConsulta.BackColor = System.Drawing.Color.White;
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
            this.txtConsulta.Location = new System.Drawing.Point(186, 238);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.PasswordChar = '\0';
            this.txtConsulta.PlaceholderText = "Digite número de cédula";
            this.txtConsulta.SelectedText = "";
            this.txtConsulta.ShadowDecoration.Parent = this.txtConsulta;
            this.txtConsulta.Size = new System.Drawing.Size(408, 29);
            this.txtConsulta.TabIndex = 14;
            // 
            // ptrConsulta
            // 
            this.ptrConsulta.BackColor = System.Drawing.Color.White;
            this.ptrConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrConsulta.Image = ((System.Drawing.Image)(resources.GetObject("ptrConsulta.Image")));
            this.ptrConsulta.Location = new System.Drawing.Point(600, 240);
            this.ptrConsulta.Name = "ptrConsulta";
            this.ptrConsulta.Size = new System.Drawing.Size(31, 27);
            this.ptrConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrConsulta.TabIndex = 12;
            this.ptrConsulta.TabStop = false;
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
            this.dtgConsulta.Location = new System.Drawing.Point(71, 297);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.RowHeadersVisible = false;
            this.dtgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsulta.Size = new System.Drawing.Size(656, 268);
            this.dtgConsulta.TabIndex = 13;
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
            this.lblConsulta.BackColor = System.Drawing.Color.White;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblConsulta.Location = new System.Drawing.Point(89, 240);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(93, 26);
            this.lblConsulta.TabIndex = 11;
            this.lblConsulta.Text = "Consulta";
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BorderRadius = 13;
            this.btnGenerarPDF.CheckedState.Parent = this.btnGenerarPDF;
            this.btnGenerarPDF.CustomImages.Parent = this.btnGenerarPDF;
            this.btnGenerarPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarPDF.DisabledState.Parent = this.btnGenerarPDF;
            this.btnGenerarPDF.FillColor = System.Drawing.Color.Red;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.HoverState.Parent = this.btnGenerarPDF;
            this.btnGenerarPDF.Location = new System.Drawing.Point(501, 553);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.ShadowDecoration.Parent = this.btnGenerarPDF;
            this.btnGenerarPDF.Size = new System.Drawing.Size(171, 31);
            this.btnGenerarPDF.TabIndex = 15;
            this.btnGenerarPDF.Text = "Generar en PDF";
            // 
            // FrmConsultaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.ptrConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.pnlCantidadDeMedicos);
            this.Controls.Add(this.dtgConsulta);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaHistorial";
            this.Text = "ConsultaHistorialcs";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.pnlCantidadDeMedicos.ResumeLayout(false);
            this.pnlCantidadDeMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCantidadDeMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblCantidadDeHistoriales;
        private System.Windows.Forms.Panel pnlCantidadDeMedicos;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Panel pnlLineaSeparadora;
        private System.Windows.Forms.PictureBox ptrCantidadDeMedicos;
        private Guna.UI2.WinForms.Guna2TextBox txtConsulta;
        private System.Windows.Forms.PictureBox ptrConsulta;
        private Guna.UI2.WinForms.Guna2DataGridView dtgConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private Guna.UI2.WinForms.Guna2Button btnGenerarPDF;
    }
}