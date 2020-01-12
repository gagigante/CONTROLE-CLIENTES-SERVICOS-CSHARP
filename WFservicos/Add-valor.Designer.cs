namespace WFservicos
{
    partial class Add_valor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_valor));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTadd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BTsair = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TXTpagamento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Valor:";
            // 
            // TXTadd
            // 
            this.TXTadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTadd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTadd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTadd.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTadd.BorderThickness = 1;
            this.TXTadd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTadd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTadd.isPassword = false;
            this.TXTadd.Location = new System.Drawing.Point(58, 67);
            this.TXTadd.Margin = new System.Windows.Forms.Padding(4);
            this.TXTadd.Name = "TXTadd";
            this.TXTadd.Size = new System.Drawing.Size(138, 30);
            this.TXTadd.TabIndex = 58;
            this.TXTadd.Text = "0";
            this.TXTadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTadd_KeyPress);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Adicionar valor";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(58, 164);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(138, 41);
            this.bunifuThinButton21.TabIndex = 59;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BTsair
            // 
            this.BTsair.BackColor = System.Drawing.SystemColors.Control;
            this.BTsair.Image = ((System.Drawing.Image)(resources.GetObject("BTsair.Image")));
            this.BTsair.ImageActive = null;
            this.BTsair.Location = new System.Drawing.Point(233, 7);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(25, 25);
            this.BTsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTsair.TabIndex = 61;
            this.BTsair.TabStop = false;
            this.BTsair.Zoom = 10;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Forma de pgamento:";
            // 
            // TXTpagamento
            // 
            this.TXTpagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTpagamento.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTpagamento.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTpagamento.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTpagamento.BorderThickness = 1;
            this.TXTpagamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTpagamento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTpagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTpagamento.isPassword = false;
            this.TXTpagamento.Location = new System.Drawing.Point(58, 125);
            this.TXTpagamento.Margin = new System.Windows.Forms.Padding(4);
            this.TXTpagamento.Name = "TXTpagamento";
            this.TXTpagamento.Size = new System.Drawing.Size(138, 30);
            this.TXTpagamento.TabIndex = 62;
            this.TXTpagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTpagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTpagamento_KeyPress);
            // 
            // Add_valor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTpagamento);
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTadd);
            this.Controls.Add(this.bunifuThinButton21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_valor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_valor";
            this.Load += new System.EventHandler(this.Add_valor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTadd;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton BTsair;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTpagamento;
    }
}