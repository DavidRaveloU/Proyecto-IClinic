
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSecion = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnAgenda = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFondoDeLogo = new System.Windows.Forms.Panel();
            this.pnlLineaMenu = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlGrapper = new System.Windows.Forms.Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tmrFundir = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            this.pnlMedico.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
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
            this.btnMinimizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(36)))));
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnCerrarSecion);
            this.pnlMenu.Controls.Add(this.pnlConsulta);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.pnlPaciente);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.pnlMedico);
            this.pnlMenu.Controls.Add(this.btnMedico);
            this.pnlMenu.Controls.Add(this.btnAgenda);
            this.pnlMenu.Controls.Add(this.pnlFondoDeLogo);
            this.pnlMenu.Controls.Add(this.pnlLineaMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(157, 745);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.CheckedState.Parent = this.btnCerrarSecion;
            this.btnCerrarSecion.CustomImages.Parent = this.btnCerrarSecion;
            this.btnCerrarSecion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSecion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSecion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSecion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSecion.DisabledState.Parent = this.btnCerrarSecion;
            this.btnCerrarSecion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSecion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrarSecion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSecion.HoverState.Parent = this.btnCerrarSecion;
            this.btnCerrarSecion.Location = new System.Drawing.Point(0, 626);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.ShadowDecoration.Parent = this.btnCerrarSecion;
            this.btnCerrarSecion.Size = new System.Drawing.Size(157, 45);
            this.btnCerrarSecion.TabIndex = 13;
            this.btnCerrarSecion.Text = "Cerrar Sesión";
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.btnConsultarHistorial);
            this.pnlConsulta.Controls.Add(this.btnConsultaMedica);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 535);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(157, 91);
            this.pnlConsulta.TabIndex = 12;
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
            this.btnConsultarHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnConsultarHistorial.HoverState.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.Location = new System.Drawing.Point(0, 45);
            this.btnConsultarHistorial.Name = "btnConsultarHistorial";
            this.btnConsultarHistorial.ShadowDecoration.Parent = this.btnConsultarHistorial;
            this.btnConsultarHistorial.Size = new System.Drawing.Size(157, 46);
            this.btnConsultarHistorial.TabIndex = 1;
            this.btnConsultarHistorial.Text = "Consultar Historial";
            this.btnConsultarHistorial.Click += new System.EventHandler(this.guna2Button8_Click);
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
            this.btnConsultaMedica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultaMedica.ForeColor = System.Drawing.Color.White;
            this.btnConsultaMedica.HoverState.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.Location = new System.Drawing.Point(0, 0);
            this.btnConsultaMedica.Name = "btnConsultaMedica";
            this.btnConsultaMedica.ShadowDecoration.Parent = this.btnConsultaMedica;
            this.btnConsultaMedica.Size = new System.Drawing.Size(157, 45);
            this.btnConsultaMedica.TabIndex = 0;
            this.btnConsultaMedica.Text = "Consulta Médica";
            this.btnConsultaMedica.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.CheckedState.Parent = this.btnConsulta;
            this.btnConsulta.CustomImages.Parent = this.btnConsulta;
            this.btnConsulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsulta.DisabledState.Parent = this.btnConsulta;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.HoverState.Parent = this.btnConsulta;
            this.btnConsulta.Location = new System.Drawing.Point(0, 490);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.ShadowDecoration.Parent = this.btnConsulta;
            this.btnConsulta.Size = new System.Drawing.Size(157, 45);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.Controls.Add(this.btnConsultarPaciente);
            this.pnlPaciente.Controls.Add(this.btnRegistrarPaciente);
            this.pnlPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaciente.Location = new System.Drawing.Point(0, 401);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(157, 89);
            this.pnlPaciente.TabIndex = 10;
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
            this.btnConsultarPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPaciente.HoverState.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.Location = new System.Drawing.Point(0, 45);
            this.btnConsultarPaciente.Name = "btnConsultarPaciente";
            this.btnConsultarPaciente.ShadowDecoration.Parent = this.btnConsultarPaciente;
            this.btnConsultarPaciente.Size = new System.Drawing.Size(157, 44);
            this.btnConsultarPaciente.TabIndex = 1;
            this.btnConsultarPaciente.Text = "Consultar Paciente";
            this.btnConsultarPaciente.Click += new System.EventHandler(this.guna2Button4_Click);
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
            this.btnRegistrarPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPaciente.HoverState.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.ShadowDecoration.Parent = this.btnRegistrarPaciente;
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(157, 45);
            this.btnRegistrarPaciente.TabIndex = 0;
            this.btnRegistrarPaciente.Text = "Registrar Paciente";
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.CheckedState.Parent = this.btnPaciente;
            this.btnPaciente.CustomImages.Parent = this.btnPaciente;
            this.btnPaciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaciente.DisabledState.Parent = this.btnPaciente;
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.HoverState.Parent = this.btnPaciente;
            this.btnPaciente.Location = new System.Drawing.Point(0, 351);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.ShadowDecoration.Parent = this.btnPaciente;
            this.btnPaciente.Size = new System.Drawing.Size(157, 50);
            this.btnPaciente.TabIndex = 9;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pnlMedico
            // 
            this.pnlMedico.Controls.Add(this.btnConsultarMedico);
            this.pnlMedico.Controls.Add(this.btnRegistrarMedico);
            this.pnlMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedico.Location = new System.Drawing.Point(0, 262);
            this.pnlMedico.Name = "pnlMedico";
            this.pnlMedico.Size = new System.Drawing.Size(157, 89);
            this.pnlMedico.TabIndex = 8;
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
            this.btnConsultarMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultarMedico.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMedico.HoverState.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.Location = new System.Drawing.Point(0, 45);
            this.btnConsultarMedico.Name = "btnConsultarMedico";
            this.btnConsultarMedico.ShadowDecoration.Parent = this.btnConsultarMedico;
            this.btnConsultarMedico.Size = new System.Drawing.Size(157, 44);
            this.btnConsultarMedico.TabIndex = 1;
            this.btnConsultarMedico.Text = "Consultar Médico";
            this.btnConsultarMedico.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.btnRegistrarMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarMedico.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMedico.HoverState.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.ShadowDecoration.Parent = this.btnRegistrarMedico;
            this.btnRegistrarMedico.Size = new System.Drawing.Size(157, 45);
            this.btnRegistrarMedico.TabIndex = 0;
            this.btnRegistrarMedico.Text = "Registrar Médico";
            this.btnRegistrarMedico.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.CheckedState.Parent = this.btnMedico;
            this.btnMedico.CustomImages.Parent = this.btnMedico;
            this.btnMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedico.DisabledState.Parent = this.btnMedico;
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMedico.ForeColor = System.Drawing.Color.White;
            this.btnMedico.HoverState.Parent = this.btnMedico;
            this.btnMedico.Location = new System.Drawing.Point(0, 212);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.ShadowDecoration.Parent = this.btnMedico;
            this.btnMedico.Size = new System.Drawing.Size(157, 50);
            this.btnMedico.TabIndex = 7;
            this.btnMedico.Text = "Medico";
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.CheckedState.Parent = this.btnAgenda;
            this.btnAgenda.CustomImages.Parent = this.btnAgenda;
            this.btnAgenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgenda.DisabledState.Parent = this.btnAgenda;
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgenda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAgenda.HoverState.Parent = this.btnAgenda;
            this.btnAgenda.Location = new System.Drawing.Point(0, 167);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.ShadowDecoration.Parent = this.btnAgenda;
            this.btnAgenda.Size = new System.Drawing.Size(157, 45);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // pnlFondoDeLogo
            // 
            this.pnlFondoDeLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFondoDeLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondoDeLogo.Name = "pnlFondoDeLogo";
            this.pnlFondoDeLogo.Size = new System.Drawing.Size(157, 167);
            this.pnlFondoDeLogo.TabIndex = 2;
            // 
            // pnlLineaMenu
            // 
            this.pnlLineaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.pnlLineaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLineaMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLineaMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.pnlLineaMenu.Location = new System.Drawing.Point(2, 1);
            this.pnlLineaMenu.Name = "pnlLineaMenu";
            this.pnlLineaMenu.Size = new System.Drawing.Size(157, 3);
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
            // pnlGrapper
            // 
            this.pnlGrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrapper.Location = new System.Drawing.Point(157, 40);
            this.pnlGrapper.Name = "pnlGrapper";
            this.pnlGrapper.Size = new System.Drawing.Size(840, 745);
            this.pnlGrapper.TabIndex = 12;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(997, 785);
            this.Controls.Add(this.pnlGrapper);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPrincipal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlPaciente.ResumeLayout(false);
            this.pnlMedico.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel pnlFondoDeLogo;
        private Guna.UI2.WinForms.Guna2Button btnMedico;
        private Guna.UI2.WinForms.Guna2Button btnAgenda;
        private System.Windows.Forms.Panel pnlMedico;
        private Guna.UI2.WinForms.Guna2Button btnConsultarMedico;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarMedico;
        private System.Windows.Forms.Panel pnlPaciente;
        private Guna.UI2.WinForms.Guna2Button btnConsultarPaciente;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarPaciente;
        private Guna.UI2.WinForms.Guna2Button btnPaciente;
        private System.Windows.Forms.Panel pnlConsulta;
        private Guna.UI2.WinForms.Guna2Button btnConsultarHistorial;
        private Guna.UI2.WinForms.Guna2Button btnConsultaMedica;
        private Guna.UI2.WinForms.Guna2Button btnConsulta;
        private System.Windows.Forms.Timer tmrFundir;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSecion;
    }
}