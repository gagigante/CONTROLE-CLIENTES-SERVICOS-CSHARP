namespace WFservicos
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTreceita = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BTmov = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Pconteudo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTreceita);
            this.panel1.Controls.Add(this.BTmov);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 55);
            this.panel1.TabIndex = 76;
            // 
            // BTreceita
            // 
            this.BTreceita.ActiveBorderThickness = 1;
            this.BTreceita.ActiveCornerRadius = 1;
            this.BTreceita.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTreceita.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.BTreceita.ActiveLineColor = System.Drawing.Color.Lime;
            this.BTreceita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTreceita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTreceita.BackgroundImage")));
            this.BTreceita.ButtonText = "Estatísticas";
            this.BTreceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTreceita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTreceita.ForeColor = System.Drawing.Color.Lime;
            this.BTreceita.IdleBorderThickness = 1;
            this.BTreceita.IdleCornerRadius = 1;
            this.BTreceita.IdleFillColor = System.Drawing.Color.White;
            this.BTreceita.IdleForecolor = System.Drawing.Color.Lime;
            this.BTreceita.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTreceita.Location = new System.Drawing.Point(182, 5);
            this.BTreceita.Margin = new System.Windows.Forms.Padding(5);
            this.BTreceita.Name = "BTreceita";
            this.BTreceita.Size = new System.Drawing.Size(159, 41);
            this.BTreceita.TabIndex = 75;
            this.BTreceita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTreceita.Click += new System.EventHandler(this.BTreceita_Click);
            // 
            // BTmov
            // 
            this.BTmov.ActiveBorderThickness = 1;
            this.BTmov.ActiveCornerRadius = 1;
            this.BTmov.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTmov.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.BTmov.ActiveLineColor = System.Drawing.Color.Lime;
            this.BTmov.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTmov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTmov.BackgroundImage")));
            this.BTmov.ButtonText = "Movimentações";
            this.BTmov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTmov.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTmov.ForeColor = System.Drawing.Color.Lime;
            this.BTmov.IdleBorderThickness = 1;
            this.BTmov.IdleCornerRadius = 1;
            this.BTmov.IdleFillColor = System.Drawing.Color.White;
            this.BTmov.IdleForecolor = System.Drawing.Color.Lime;
            this.BTmov.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTmov.Location = new System.Drawing.Point(13, 5);
            this.BTmov.Margin = new System.Windows.Forms.Padding(5);
            this.BTmov.Name = "BTmov";
            this.BTmov.Size = new System.Drawing.Size(159, 41);
            this.BTmov.TabIndex = 74;
            this.BTmov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTmov.Click += new System.EventHandler(this.BTmov_Click);
            // 
            // Pconteudo
            // 
            this.Pconteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pconteudo.Location = new System.Drawing.Point(0, 55);
            this.Pconteudo.Name = "Pconteudo";
            this.Pconteudo.Size = new System.Drawing.Size(761, 322);
            this.Pconteudo.TabIndex = 77;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 377);
            this.Controls.Add(this.Pconteudo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 BTmov;
        private Bunifu.Framework.UI.BunifuThinButton2 BTreceita;
        private System.Windows.Forms.Panel Pconteudo;
    }
}