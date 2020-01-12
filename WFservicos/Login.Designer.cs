namespace WFservicos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTentrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTsenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTusuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Pheader = new System.Windows.Forms.Panel();
            this.PBlogo = new System.Windows.Forms.PictureBox();
            this.BTsair = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.Pheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTentrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXTsenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXTusuario);
            this.panel1.Location = new System.Drawing.Point(9, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 340);
            this.panel1.TabIndex = 1;
            // 
            // BTentrar
            // 
            this.BTentrar.ActiveBorderThickness = 1;
            this.BTentrar.ActiveCornerRadius = 1;
            this.BTentrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTentrar.ActiveForecolor = System.Drawing.Color.White;
            this.BTentrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTentrar.BackColor = System.Drawing.Color.White;
            this.BTentrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTentrar.BackgroundImage")));
            this.BTentrar.ButtonText = "Entrar";
            this.BTentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTentrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTentrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTentrar.IdleBorderThickness = 1;
            this.BTentrar.IdleCornerRadius = 1;
            this.BTentrar.IdleFillColor = System.Drawing.Color.White;
            this.BTentrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTentrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTentrar.Location = new System.Drawing.Point(50, 155);
            this.BTentrar.Margin = new System.Windows.Forms.Padding(5);
            this.BTentrar.Name = "BTentrar";
            this.BTentrar.Size = new System.Drawing.Size(181, 41);
            this.BTentrar.TabIndex = 14;
            this.BTentrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTentrar.Click += new System.EventHandler(this.BTentrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha:";
            // 
            // TXTsenha
            // 
            this.TXTsenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTsenha.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTsenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTsenha.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTsenha.BorderThickness = 1;
            this.TXTsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTsenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTsenha.isPassword = true;
            this.TXTsenha.Location = new System.Drawing.Point(27, 116);
            this.TXTsenha.Margin = new System.Windows.Forms.Padding(4);
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.Size = new System.Drawing.Size(227, 30);
            this.TXTsenha.TabIndex = 10;
            this.TXTsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTsenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTsenha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuário:";
            // 
            // TXTusuario
            // 
            this.TXTusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTusuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTusuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTusuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTusuario.BorderThickness = 1;
            this.TXTusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTusuario.isPassword = false;
            this.TXTusuario.Location = new System.Drawing.Point(27, 59);
            this.TXTusuario.Margin = new System.Windows.Forms.Padding(4);
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(227, 30);
            this.TXTusuario.TabIndex = 8;
            this.TXTusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTusuario_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // Pheader
            // 
            this.Pheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.Pheader.Controls.Add(this.PBlogo);
            this.Pheader.Controls.Add(this.BTsair);
            this.Pheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pheader.Location = new System.Drawing.Point(0, 0);
            this.Pheader.Name = "Pheader";
            this.Pheader.Size = new System.Drawing.Size(300, 100);
            this.Pheader.TabIndex = 6;
            // 
            // PBlogo
            // 
            this.PBlogo.Image = ((System.Drawing.Image)(resources.GetObject("PBlogo.Image")));
            this.PBlogo.Location = new System.Drawing.Point(90, 12);
            this.PBlogo.Name = "PBlogo";
            this.PBlogo.Size = new System.Drawing.Size(120, 63);
            this.PBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBlogo.TabIndex = 6;
            this.PBlogo.TabStop = false;
            // 
            // BTsair
            // 
            this.BTsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTsair.Image = ((System.Drawing.Image)(resources.GetObject("BTsair.Image")));
            this.BTsair.ImageActive = null;
            this.BTsair.Location = new System.Drawing.Point(268, 5);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(25, 25);
            this.BTsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTsair.TabIndex = 5;
            this.BTsair.TabStop = false;
            this.BTsair.Zoom = 10;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Pheader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.PBlogo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.Pheader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 BTentrar;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTsenha;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTusuario;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel Pheader;
        private System.Windows.Forms.PictureBox PBlogo;
        private Bunifu.Framework.UI.BunifuImageButton BTsair;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}