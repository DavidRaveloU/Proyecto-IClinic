
namespace Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.btnConsultarHistorial = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsultaMedica = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsulta = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.btnConsultarPaciente = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarPaciente = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaciente = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMedico = new System.Windows.Forms.Panel();
            this.btnConsultarMedico = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarMedico = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedico = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAgenda = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAgendarMedico = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgendarCita = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgenda = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFondoDeLogo = new System.Windows.Forms.Panel();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.pnlLineaMenu = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrapper = new System.Windows.Forms.Panel();
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tmrFundir = new System.Windows.Forms.Timer(this.components);
            this.btnHorario = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            this.pnlMedico.SuspendLayout();
            this.pnlAgenda.SuspendLayout();
            this.pnlFondoDeLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnHorario);
            this.pnlMenu.Controls.Add(this.pnlConsulta);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.pnlPaciente);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.pnlMedico);
            this.pnlMenu.Controls.Add(this.btnMedico);
            this.pnlMenu.Controls.Add(this.pnlAgenda);
            this.pnlMenu.Controls.Add(this.btnAgenda);
            this.pnlMenu.Controls.Add(this.pnlFondoDeLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(198, 677);
            this.pnlMenu.TabIndex = 10;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.btnConsultarHistorial);
            this.pnlConsulta.Controls.Add(this.btnConsultaMedica);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsulta.ForeColor = System.Drawing.Color.Black;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 675);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(198, 91);
            this.pnlConsulta.TabIndex = 19;
            // 
            // btnConsultarHistorial
            // 
            this.btnConsultarHistorial.CheckedState.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.CustomImages.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarHistorial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarHistorial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarHistorial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarHistorial.DisabledState.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarHistorial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnConsultarHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarHistorial.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarHistorial.HoverState.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarHistorial.Image")));
            this.btnConsultarHistorial.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnConsultarHistorial.Location = new System.Drawing.Point(0, 45);
            this.btnConsultarHistorial.Name = "btnConsultarHistorial";
            this.btnConsultarHistorial.ShadowDecoration.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.Size = new System.Drawing.Size(198, 45);
            this.btnConsultarHistorial.TabIndex = 1;
            this.btnConsultarHistorial.Text = "Consultar historial";
            this.btnConsultarHistorial.TextOffset = new System.Drawing.Point(2, 0);
            this.btnConsultarHistorial.Click += new System.EventHandler(this.btnConsultarHistorial_Click_1);
            // 
            // btnConsultaMedica
            // 
            this.btnConsultaMedica.CheckedState.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.CustomImages.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaMedica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaMedica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaMedica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultaMedica.DisabledState.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaMedica.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnConsultaMedica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultaMedica.ForeColor = System.Drawing.Color.Black;
            this.btnConsultaMedica.HoverState.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaMedica.Image")));
            this.btnConsultaMedica.Location = new System.Drawing.Point(0, 0);
            this.btnConsultaMedica.Name = "btnConsultaMedica";
            this.btnConsultaMedica.ShadowDecoration.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.Size = new System.Drawing.Size(198, 45);
            this.btnConsultaMedica.TabIndex = 0;
            this.btnConsultaMedica.Text = "Consulta médica";
            this.btnConsultaMedica.Click += new System.EventHandler(this.btnConsultaMedica_Click_1);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Animated = true;
            this.btnConsulta.BorderRadius = 13;
            this.btnConsulta.CheckedState.Parent = this.btnConsulta;
            this.btnConsulta.CustomImages.Parent = this.btnConsulta;
            this.btnConsulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsulta.DisabledState.Parent = this.btnConsulta;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FillColor = System.Drawing.Color.Transparent;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnConsulta.HoverState.Parent = this.btnConsulta;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageOffset = new System.Drawing.Point(-20, 0);
            this.btnConsulta.ImageSize = new System.Drawing.Size(32, 32);
            this.btnConsulta.Location = new System.Drawing.Point(0, 630);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.ShadowDecoration.Parent = this.btnConsulta;
            this.btnConsulta.Size = new System.Drawing.Size(198, 45);
            this.btnConsulta.TabIndex = 18;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextOffset = new System.Drawing.Point(-17, 0);
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.Controls.Add(this.btnConsultarPaciente);
            this.pnlPaciente.Controls.Add(this.btnRegistrarPaciente);
            this.pnlPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaciente.ForeColor = System.Drawing.Color.Black;
            this.pnlPaciente.Location = new System.Drawing.Point(0, 541);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(198, 89);
            this.pnlPaciente.TabIndex = 17;
            // 
            // btnConsultarPaciente
            // 
            this.btnConsultarPaciente.CheckedState.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.CustomImages.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarPaciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarPaciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarPaciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarPaciente.DisabledState.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarPaciente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnConsultarPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarPaciente.HoverState.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarPaciente.Image")));
            this.btnConsultarPaciente.Location = new System.Drawing.Point(0, 45);
            this.btnConsultarPaciente.Name = "btnConsultarPaciente";
            this.btnConsultarPaciente.ShadowDecoration.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.Size = new System.Drawing.Size(198, 45);
            this.btnConsultarPaciente.TabIndex = 1;
            this.btnConsultarPaciente.Text = "Consultar paciente";
            this.btnConsultarPaciente.Click += new System.EventHandler(this.btnConsultarPaciente_Click);
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.CheckedState.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.CustomImages.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarPaciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarPaciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarPaciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarPaciente.DisabledState.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarPaciente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnRegistrarPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPaciente.HoverState.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPaciente.Image")));
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.ShadowDecoration.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(198, 45);
            this.btnRegistrarPaciente.TabIndex = 0;
            this.btnRegistrarPaciente.Text = "Registrar paciente";
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Animated = true;
            this.btnPaciente.BorderRadius = 13;
            this.btnPaciente.CheckedState.Parent = this.btnPaciente;
            this.btnPaciente.CustomImages.Parent = this.btnPaciente;
            this.btnPaciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaciente.DisabledState.Parent = this.btnPaciente;
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FillColor = System.Drawing.Color.Transparent;
            this.btnPaciente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnPaciente.HoverState.Parent = this.btnPaciente;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageOffset = new System.Drawing.Point(-21, 1);
            this.btnPaciente.ImageSize = new System.Drawing.Size(34, 34);
            this.btnPaciente.Location = new System.Drawing.Point(0, 491);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.ShadowDecoration.Parent = this.btnPaciente;
            this.btnPaciente.Size = new System.Drawing.Size(198, 50);
            this.btnPaciente.TabIndex = 16;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.TextOffset = new System.Drawing.Point(-18, 0);
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click_1);
            // 
            // pnlMedico
            // 
            this.pnlMedico.Controls.Add(this.btnConsultarMedico);
            this.pnlMedico.Controls.Add(this.btnRegistrarMedico);
            this.pnlMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedico.ForeColor = System.Drawing.Color.Black;
            this.pnlMedico.Location = new System.Drawing.Point(0, 402);
            this.pnlMedico.Name = "pnlMedico";
            this.pnlMedico.Size = new System.Drawing.Size(198, 89);
            this.pnlMedico.TabIndex = 15;
            // 
            // btnConsultarMedico
            // 
            this.btnConsultarMedico.CheckedState.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.CustomImages.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarMedico.DisabledState.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnConsultarMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarMedico.HoverState.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarMedico.Image")));
            this.btnConsultarMedico.Location = new System.Drawing.Point(0, 45);
            this.btnConsultarMedico.Name = "btnConsultarMedico";
            this.btnConsultarMedico.ShadowDecoration.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.Size = new System.Drawing.Size(198, 45);
            this.btnConsultarMedico.TabIndex = 1;
            this.btnConsultarMedico.Text = "Consultar médico";
            this.btnConsultarMedico.Click += new System.EventHandler(this.btnConsultarMedico_Click);
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.CheckedState.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.CustomImages.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarMedico.DisabledState.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnRegistrarMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarMedico.HoverState.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarMedico.Image")));
            this.btnRegistrarMedico.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.ShadowDecoration.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.Size = new System.Drawing.Size(198, 45);
            this.btnRegistrarMedico.TabIndex = 0;
            this.btnRegistrarMedico.Text = "Registrar médico";
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Animated = true;
            this.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMedico.BorderRadius = 13;
            this.btnMedico.CheckedState.Parent = this.btnMedico;
            this.btnMedico.CustomImages.Parent = this.btnMedico;
            this.btnMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedico.DisabledState.Parent = this.btnMedico;
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedico.FillColor = System.Drawing.Color.Transparent;
            this.btnMedico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMedico.ForeColor = System.Drawing.Color.Black;
            this.btnMedico.HoverState.Parent = this.btnMedico;
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedico.ImageOffset = new System.Drawing.Point(-12, 0);
            this.btnMedico.ImageSize = new System.Drawing.Size(50, 39);
            this.btnMedico.Location = new System.Drawing.Point(0, 357);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.ShadowDecoration.Parent = this.btnMedico;
            this.btnMedico.Size = new System.Drawing.Size(198, 45);
            this.btnMedico.TabIndex = 14;
            this.btnMedico.Text = "Medico";
            this.btnMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedico.TextOffset = new System.Drawing.Point(-16, 0);
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click_1);
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.Controls.Add(this.btnAgendarMedico);
            this.pnlAgenda.Controls.Add(this.btnAgendarCita);
            this.pnlAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgenda.Location = new System.Drawing.Point(0, 268);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.ShadowDecoration.Parent = this.pnlAgenda;
            this.pnlAgenda.Size = new System.Drawing.Size(198, 89);
            this.pnlAgenda.TabIndex = 4;
            // 
            // btnAgendarMedico
            // 
            this.btnAgendarMedico.CheckedState.Parent = this.btnAgendarMedico;
            this.btnAgendarMedico.CustomImages.Parent = this.btnAgendarMedico;
            this.btnAgendarMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendarMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendarMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendarMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendarMedico.DisabledState.Parent = this.btnAgendarMedico;
            this.btnAgendarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendarMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnAgendarMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgendarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnAgendarMedico.HoverState.Parent = this.btnAgendarMedico;
            this.btnAgendarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendarMedico.Image")));
            this.btnAgendarMedico.Location = new System.Drawing.Point(0, 45);
            this.btnAgendarMedico.Name = "btnAgendarMedico";
            this.btnAgendarMedico.ShadowDecoration.Parent = this.btnAgendarMedico;
            this.btnAgendarMedico.Size = new System.Drawing.Size(198, 45);
            this.btnAgendarMedico.TabIndex = 2;
            this.btnAgendarMedico.Text = "Agendar médico";
            this.btnAgendarMedico.TextOffset = new System.Drawing.Point(1, 0);
            this.btnAgendarMedico.Click += new System.EventHandler(this.btnAgendarMedico_Click);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.CheckedState.Parent = this.btnAgendarCita;
            this.btnAgendarCita.CustomImages.Parent = this.btnAgendarCita;
            this.btnAgendarCita.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendarCita.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendarCita.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendarCita.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendarCita.DisabledState.Parent = this.btnAgendarCita;
            this.btnAgendarCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendarCita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnAgendarCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgendarCita.ForeColor = System.Drawing.Color.Black;
            this.btnAgendarCita.HoverState.Parent = this.btnAgendarCita;
            this.btnAgendarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendarCita.Image")));
            this.btnAgendarCita.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAgendarCita.Location = new System.Drawing.Point(0, 0);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.ShadowDecoration.Parent = this.btnAgendarCita;
            this.btnAgendarCita.Size = new System.Drawing.Size(198, 45);
            this.btnAgendarCita.TabIndex = 1;
            this.btnAgendarCita.Text = "Agendar cita";
            this.btnAgendarCita.TextOffset = new System.Drawing.Point(-4, 0);
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Animated = true;
            this.btnAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgenda.BorderRadius = 13;
            this.btnAgenda.CheckedState.Parent = this.btnAgenda;
            this.btnAgenda.CustomImages.Parent = this.btnAgenda;
            this.btnAgenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgenda.DisabledState.Parent = this.btnAgenda;
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgenda.FillColor = System.Drawing.Color.Transparent;
            this.btnAgenda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgenda.ForeColor = System.Drawing.Color.Black;
            this.btnAgenda.HoverState.Parent = this.btnAgenda;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgenda.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnAgenda.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAgenda.Location = new System.Drawing.Point(0, 223);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.ShadowDecoration.Parent = this.btnAgenda;
            this.btnAgenda.Size = new System.Drawing.Size(198, 45);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgenda.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // pnlFondoDeLogo
            // 
            this.pnlFondoDeLogo.Controls.Add(this.ptrLogo);
            this.pnlFondoDeLogo.Controls.Add(this.pnlLineaMenu);
            this.pnlFondoDeLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFondoDeLogo.ForeColor = System.Drawing.Color.Black;
            this.pnlFondoDeLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondoDeLogo.Name = "pnlFondoDeLogo";
            this.pnlFondoDeLogo.Size = new System.Drawing.Size(198, 223);
            this.pnlFondoDeLogo.TabIndex = 2;
            // 
            // ptrLogo
            // 
            this.ptrLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptrLogo.Image")));
            this.ptrLogo.Location = new System.Drawing.Point(-2, -1);
            this.ptrLogo.Name = "ptrLogo";
            this.ptrLogo.Size = new System.Drawing.Size(200, 185);
            this.ptrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrLogo.TabIndex = 2;
            this.ptrLogo.TabStop = false;
            // 
            // pnlLineaMenu
            // 
            this.pnlLineaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.pnlLineaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLineaMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLineaMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.pnlLineaMenu.Location = new System.Drawing.Point(3, -1);
            this.pnlLineaMenu.Name = "pnlLineaMenu";
            this.pnlLineaMenu.Size = new System.Drawing.Size(197, 3);
            this.pnlLineaMenu.TabIndex = 1;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(997, 40);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Animated = true;
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.BorderRadius = 7;
            this.btnMinimizar.CheckedState.Parent = this.btnMinimizar;
            this.btnMinimizar.CustomImages.Parent = this.btnMinimizar;
            this.btnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimizar.DisabledState.Parent = this.btnMinimizar;
            this.btnMinimizar.FillColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnMinimizar.HoverState.Parent = this.btnMinimizar;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(934, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(28, 27);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 7;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(964, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlGrapper
            // 
            this.pnlGrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrapper.ForeColor = System.Drawing.Color.Black;
            this.pnlGrapper.Location = new System.Drawing.Point(198, 40);
            this.pnlGrapper.Name = "pnlGrapper";
            this.pnlGrapper.Size = new System.Drawing.Size(799, 677);
            this.pnlGrapper.TabIndex = 12;
            this.pnlGrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrapper_Paint);
            // 
            // sombra
            // 
            this.sombra.BorderRadius = 27;
            this.sombra.TargetForm = this;
            // 
            // btnHorario
            // 
            this.btnHorario.Animated = true;
            this.btnHorario.BorderRadius = 13;
            this.btnHorario.CheckedState.Parent = this.btnHorario;
            this.btnHorario.CustomImages.Parent = this.btnHorario;
            this.btnHorario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHorario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHorario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHorario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHorario.DisabledState.Parent = this.btnHorario;
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorario.FillColor = System.Drawing.Color.Transparent;
            this.btnHorario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHorario.ForeColor = System.Drawing.Color.Black;
            this.btnHorario.HoverState.Parent = this.btnHorario;
            this.btnHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnHorario.Image")));
            this.btnHorario.ImageOffset = new System.Drawing.Point(-23, 0);
            this.btnHorario.ImageSize = new System.Drawing.Size(32, 32);
            this.btnHorario.Location = new System.Drawing.Point(0, 766);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.ShadowDecoration.Parent = this.btnHorario;
            this.btnHorario.Size = new System.Drawing.Size(198, 45);
            this.btnHorario.TabIndex = 21;
            this.btnHorario.Text = "Horario";
            this.btnHorario.TextOffset = new System.Drawing.Point(-19, 0);
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Animated = true;
            this.btnCerrarSesion.BorderRadius = 13;
            this.btnCerrarSesion.CheckedState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.CustomImages.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesion.DisabledState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.HoverState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageOffset = new System.Drawing.Point(-13, 0);
            this.btnCerrarSesion.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 811);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.ShadowDecoration.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Size = new System.Drawing.Size(198, 45);
            this.btnCerrarSesion.TabIndex = 22;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(997, 717);
            this.Controls.Add(this.pnlGrapper);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlPaciente.ResumeLayout(false);
            this.pnlMedico.ResumeLayout(false);
            this.pnlAgenda.ResumeLayout(false);
            this.pnlFondoDeLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlGrapper;
        private System.Windows.Forms.Panel pnlLineaMenu;
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
        private System.Windows.Forms.Panel pnlFondoDeLogo;
        private Guna.UI2.WinForms.Guna2Button btnAgenda;
        private System.Windows.Forms.Timer tmrFundir;
        private System.Windows.Forms.PictureBox ptrLogo;
        private System.Windows.Forms.Panel pnlConsulta;
        private Guna.UI2.WinForms.Guna2Button btnConsultarHistorial;
        private Guna.UI2.WinForms.Guna2Button btnConsultaMedica;
        private Guna.UI2.WinForms.Guna2Button btnConsulta;
        private System.Windows.Forms.Panel pnlPaciente;
        private Guna.UI2.WinForms.Guna2Button btnConsultarPaciente;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarPaciente;
        private Guna.UI2.WinForms.Guna2Button btnPaciente;
        private System.Windows.Forms.Panel pnlMedico;
        private Guna.UI2.WinForms.Guna2Button btnConsultarMedico;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarMedico;
        private Guna.UI2.WinForms.Guna2Button btnMedico;
        private Guna.UI2.WinForms.Guna2Panel pnlAgenda;
        private Guna.UI2.WinForms.Guna2Button btnAgendarMedico;
        private Guna.UI2.WinForms.Guna2Button btnAgendarCita;
        private Guna.UI2.WinForms.Guna2Button btnHorario;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
    }
}