
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlGrapper = new System.Windows.Forms.Panel();
            this.pnlLineaMenu = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(889, 6);
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
            this.btnMinimizar.Location = new System.Drawing.Point(859, 6);
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
            this.pnlMenu.Controls.Add(this.pnlLineaMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(157, 489);
            this.pnlMenu.TabIndex = 10;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(924, 40);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            // 
            // pnlGrapper
            // 
            this.pnlGrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrapper.Location = new System.Drawing.Point(157, 40);
            this.pnlGrapper.Name = "pnlGrapper";
            this.pnlGrapper.Size = new System.Drawing.Size(767, 489);
            this.pnlGrapper.TabIndex = 12;
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(924, 529);
            this.Controls.Add(this.pnlGrapper);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPrincipal";
            this.pnlMenu.ResumeLayout(false);
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
    }
}