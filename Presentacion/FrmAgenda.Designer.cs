
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtgAgenda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnModificar);
            this.guna2ShadowPanel1.Controls.Add(this.btnEliminar);
            this.guna2ShadowPanel1.Controls.Add(this.btnAgendar);
            this.guna2ShadowPanel1.Controls.Add(this.dtgAgenda);
            this.guna2ShadowPanel1.Controls.Add(this.monthCalendar1);
            this.guna2ShadowPanel1.Controls.Add(this.lblTelefono);
            this.guna2ShadowPanel1.Controls.Add(this.lblTTelefono);
            this.guna2ShadowPanel1.Controls.Add(this.lblSexo);
            this.guna2ShadowPanel1.Controls.Add(this.lblTSexo);
            this.guna2ShadowPanel1.Controls.Add(this.lblNombre);
            this.guna2ShadowPanel1.Controls.Add(this.lblTNombre);
            this.guna2ShadowPanel1.Controls.Add(this.txtNumeroDeCedula);
            this.guna2ShadowPanel1.Controls.Add(this.lblNumeroCédula);
            this.guna2ShadowPanel1.Controls.Add(this.lblAgenda);
            this.guna2ShadowPanel1.Controls.Add(this.ptrAgenda);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(27, 28);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(743, 616);
            this.guna2ShadowPanel1.TabIndex = 1;
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
            this.txtNumeroDeCedula.Location = new System.Drawing.Point(180, 133);
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
            this.lblNumeroCédula.Location = new System.Drawing.Point(27, 140);
            this.lblNumeroCédula.Name = "lblNumeroCédula";
            this.lblNumeroCédula.Size = new System.Drawing.Size(132, 22);
            this.lblNumeroCédula.TabIndex = 21;
            this.lblNumeroCédula.Text = "Número de cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(176, 178);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTNombre
            // 
            this.lblTNombre.AutoSize = true;
            this.lblTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTNombre.Location = new System.Drawing.Point(23, 178);
            this.lblTNombre.Name = "lblTNombre";
            this.lblTNombre.Size = new System.Drawing.Size(69, 20);
            this.lblTNombre.TabIndex = 49;
            this.lblTNombre.Text = "Nombre:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexo.Location = new System.Drawing.Point(176, 216);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 52;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTSexo
            // 
            this.lblTSexo.AutoSize = true;
            this.lblTSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTSexo.Location = new System.Drawing.Point(23, 216);
            this.lblTSexo.Name = "lblTSexo";
            this.lblTSexo.Size = new System.Drawing.Size(49, 20);
            this.lblTSexo.TabIndex = 51;
            this.lblTSexo.Text = "Sexo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelefono.Location = new System.Drawing.Point(176, 255);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblTTelefono
            // 
            this.lblTTelefono.AutoSize = true;
            this.lblTTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTTelefono.Location = new System.Drawing.Point(23, 255);
            this.lblTTelefono.Name = "lblTTelefono";
            this.lblTTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTTelefono.TabIndex = 53;
            this.lblTTelefono.Text = "Telefono:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(507, 133);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 55;
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dtgAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAgenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgAgenda.EnableHeadersVisualStyles = false;
            this.dtgAgenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgAgenda.Location = new System.Drawing.Point(27, 330);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.ReadOnly = true;
            this.dtgAgenda.RowHeadersVisible = false;
            this.dtgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgenda.Size = new System.Drawing.Size(672, 204);
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
            this.btnAgendar.Location = new System.Drawing.Point(528, 551);
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
            this.btnEliminar.Location = new System.Drawing.Point(27, 551);
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
            this.btnModificar.Location = new System.Drawing.Point(283, 551);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(171, 31);
            this.btnModificar.TabIndex = 59;
            this.btnModificar.Text = "Modificar";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(799, 677);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.Text = "Form1";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
    }
}