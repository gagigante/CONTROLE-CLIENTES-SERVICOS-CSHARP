namespace WFservicos
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTsenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTusuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BTadicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BTremover = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DGusuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBnomeForm = new System.Windows.Forms.Label();
            this.BTsair = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Senha:";
            // 
            // TXTsenha
            // 
            this.TXTsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTsenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTsenha.BorderColorFocused = System.Drawing.Color.White;
            this.TXTsenha.BorderColorIdle = System.Drawing.Color.White;
            this.TXTsenha.BorderColorMouseHover = System.Drawing.Color.White;
            this.TXTsenha.BorderThickness = 1;
            this.TXTsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTsenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTsenha.ForeColor = System.Drawing.Color.White;
            this.TXTsenha.isPassword = true;
            this.TXTsenha.Location = new System.Drawing.Point(80, 174);
            this.TXTsenha.Margin = new System.Windows.Forms.Padding(4);
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.Size = new System.Drawing.Size(131, 30);
            this.TXTsenha.TabIndex = 52;
            this.TXTsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTsenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTsenha_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Usuário:";
            // 
            // TXTusuario
            // 
            this.TXTusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTusuario.BorderColorFocused = System.Drawing.Color.White;
            this.TXTusuario.BorderColorIdle = System.Drawing.Color.White;
            this.TXTusuario.BorderColorMouseHover = System.Drawing.Color.White;
            this.TXTusuario.BorderThickness = 1;
            this.TXTusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTusuario.ForeColor = System.Drawing.Color.White;
            this.TXTusuario.isPassword = false;
            this.TXTusuario.Location = new System.Drawing.Point(80, 119);
            this.TXTusuario.Margin = new System.Windows.Forms.Padding(4);
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(131, 30);
            this.TXTusuario.TabIndex = 50;
            this.TXTusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTusuario_KeyPress);
            // 
            // BTadicionar
            // 
            this.BTadicionar.ActiveBorderThickness = 1;
            this.BTadicionar.ActiveCornerRadius = 1;
            this.BTadicionar.ActiveFillColor = System.Drawing.Color.White;
            this.BTadicionar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadicionar.ActiveLineColor = System.Drawing.Color.White;
            this.BTadicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTadicionar.BackgroundImage")));
            this.BTadicionar.ButtonText = "Adicionar";
            this.BTadicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTadicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTadicionar.ForeColor = System.Drawing.Color.White;
            this.BTadicionar.IdleBorderThickness = 1;
            this.BTadicionar.IdleCornerRadius = 1;
            this.BTadicionar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadicionar.IdleForecolor = System.Drawing.Color.White;
            this.BTadicionar.IdleLineColor = System.Drawing.Color.White;
            this.BTadicionar.Location = new System.Drawing.Point(80, 213);
            this.BTadicionar.Margin = new System.Windows.Forms.Padding(5);
            this.BTadicionar.Name = "BTadicionar";
            this.BTadicionar.Size = new System.Drawing.Size(131, 41);
            this.BTadicionar.TabIndex = 49;
            this.BTadicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTadicionar.Click += new System.EventHandler(this.BTadicionar_Click);
            // 
            // BTremover
            // 
            this.BTremover.ActiveBorderThickness = 1;
            this.BTremover.ActiveCornerRadius = 1;
            this.BTremover.ActiveFillColor = System.Drawing.Color.White;
            this.BTremover.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTremover.ActiveLineColor = System.Drawing.Color.White;
            this.BTremover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTremover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTremover.BackgroundImage")));
            this.BTremover.ButtonText = "Remover";
            this.BTremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTremover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTremover.ForeColor = System.Drawing.Color.White;
            this.BTremover.IdleBorderThickness = 1;
            this.BTremover.IdleCornerRadius = 1;
            this.BTremover.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTremover.IdleForecolor = System.Drawing.Color.White;
            this.BTremover.IdleLineColor = System.Drawing.Color.White;
            this.BTremover.Location = new System.Drawing.Point(80, 248);
            this.BTremover.Margin = new System.Windows.Forms.Padding(5);
            this.BTremover.Name = "BTremover";
            this.BTremover.Size = new System.Drawing.Size(131, 41);
            this.BTremover.TabIndex = 48;
            this.BTremover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTremover.Click += new System.EventHandler(this.BTremover_Click);
            // 
            // DGusuarios
            // 
            this.DGusuarios.AllowUserToAddRows = false;
            this.DGusuarios.AllowUserToDeleteRows = false;
            this.DGusuarios.AllowUserToResizeColumns = false;
            this.DGusuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGusuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGusuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGusuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.cod});
            this.DGusuarios.DoubleBuffered = true;
            this.DGusuarios.EnableHeadersVisualStyles = false;
            this.DGusuarios.GridColor = System.Drawing.SystemColors.Control;
            this.DGusuarios.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.DGusuarios.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGusuarios.Location = new System.Drawing.Point(231, 99);
            this.DGusuarios.Name = "DGusuarios";
            this.DGusuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGusuarios.RowHeadersWidth = 25;
            this.DGusuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGusuarios.Size = new System.Drawing.Size(140, 186);
            this.DGusuarios.TabIndex = 47;
            // 
            // user
            // 
            this.user.HeaderText = "Usuário";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // LBnomeForm
            // 
            this.LBnomeForm.AutoSize = true;
            this.LBnomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnomeForm.ForeColor = System.Drawing.Color.White;
            this.LBnomeForm.Location = new System.Drawing.Point(93, 26);
            this.LBnomeForm.Name = "LBnomeForm";
            this.LBnomeForm.Size = new System.Drawing.Size(267, 24);
            this.LBnomeForm.TabIndex = 46;
            this.LBnomeForm.Text = "ADICIONAR NOVO USUÁRIO ";
            // 
            // BTsair
            // 
            this.BTsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTsair.Image = ((System.Drawing.Image)(resources.GetObject("BTsair.Image")));
            this.BTsair.ImageActive = null;
            this.BTsair.Location = new System.Drawing.Point(437, 8);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(25, 25);
            this.BTsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTsair.TabIndex = 45;
            this.BTsair.TabStop = false;
            this.BTsair.Zoom = 10;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.DGusuarios;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(471, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTusuario);
            this.Controls.Add(this.BTadicionar);
            this.Controls.Add(this.BTremover);
            this.Controls.Add(this.DGusuarios);
            this.Controls.Add(this.LBnomeForm);
            this.Controls.Add(this.BTsair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTsenha;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTusuario;
        private Bunifu.Framework.UI.BunifuThinButton2 BTadicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 BTremover;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGusuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.Label LBnomeForm;
        private Bunifu.Framework.UI.BunifuImageButton BTsair;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}