namespace WFservicos
{
    partial class Add_clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_clientes));
            this.DGclientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTemail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BTadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTtelefone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTnome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BTcancela = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BThistorico = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DGclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGclientes
            // 
            this.DGclientes.AllowUserToAddRows = false;
            this.DGclientes.AllowUserToDeleteRows = false;
            this.DGclientes.AllowUserToResizeColumns = false;
            this.DGclientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGclientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGclientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DGclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGclientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.email,
            this.telefone,
            this.cod});
            this.DGclientes.DoubleBuffered = true;
            this.DGclientes.EnableHeadersVisualStyles = false;
            this.DGclientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGclientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGclientes.HeaderForeColor = System.Drawing.Color.White;
            this.DGclientes.Location = new System.Drawing.Point(254, 24);
            this.DGclientes.Name = "DGclientes";
            this.DGclientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGclientes.RowHeadersWidth = 25;
            this.DGclientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGclientes.Size = new System.Drawing.Size(483, 316);
            this.DGclientes.TabIndex = 42;
            this.DGclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGclientes_CellClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 140;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 80;
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "E-mail (opcional) :";
            // 
            // TXTemail
            // 
            this.TXTemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTemail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTemail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTemail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTemail.BorderThickness = 1;
            this.TXTemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTemail.isPassword = false;
            this.TXTemail.Location = new System.Drawing.Point(18, 133);
            this.TXTemail.Margin = new System.Windows.Forms.Padding(4);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(227, 30);
            this.TXTemail.TabIndex = 2;
            this.TXTemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTemail_KeyPress);
            // 
            // BTadd
            // 
            this.BTadd.ActiveBorderThickness = 1;
            this.BTadd.ActiveCornerRadius = 1;
            this.BTadd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.ActiveForecolor = System.Drawing.Color.White;
            this.BTadd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.BackColor = System.Drawing.Color.White;
            this.BTadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTadd.BackgroundImage")));
            this.BTadd.ButtonText = "Adicionar cliente";
            this.BTadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.IdleBorderThickness = 1;
            this.BTadd.IdleCornerRadius = 1;
            this.BTadd.IdleFillColor = System.Drawing.Color.White;
            this.BTadd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.Location = new System.Drawing.Point(18, 228);
            this.BTadd.Margin = new System.Windows.Forms.Padding(5);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(181, 41);
            this.BTadd.TabIndex = 49;
            this.BTadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Telefone:";
            // 
            // TXTtelefone
            // 
            this.TXTtelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTtelefone.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTtelefone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTtelefone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTtelefone.BorderThickness = 1;
            this.TXTtelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTtelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTtelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTtelefone.isPassword = false;
            this.TXTtelefone.Location = new System.Drawing.Point(18, 189);
            this.TXTtelefone.Margin = new System.Windows.Forms.Padding(4);
            this.TXTtelefone.Name = "TXTtelefone";
            this.TXTtelefone.Size = new System.Drawing.Size(227, 30);
            this.TXTtelefone.TabIndex = 3;
            this.TXTtelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTtelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTtelefone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nome:";
            // 
            // TXTnome
            // 
            this.TXTnome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTnome.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTnome.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTnome.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTnome.BorderThickness = 1;
            this.TXTnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTnome.isPassword = false;
            this.TXTnome.Location = new System.Drawing.Point(18, 79);
            this.TXTnome.Margin = new System.Windows.Forms.Padding(4);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(227, 30);
            this.TXTnome.TabIndex = 1;
            this.TXTnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTnome_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.DGclientes;
            // 
            // BTcancela
            // 
            this.BTcancela.ActiveBorderThickness = 1;
            this.BTcancela.ActiveCornerRadius = 1;
            this.BTcancela.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.BTcancela.ActiveForecolor = System.Drawing.Color.White;
            this.BTcancela.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.BTcancela.BackColor = System.Drawing.Color.White;
            this.BTcancela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTcancela.BackgroundImage")));
            this.BTcancela.ButtonText = "Cancelar edição";
            this.BTcancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTcancela.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTcancela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.BTcancela.IdleBorderThickness = 1;
            this.BTcancela.IdleCornerRadius = 1;
            this.BTcancela.IdleFillColor = System.Drawing.Color.White;
            this.BTcancela.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.BTcancela.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.BTcancela.Location = new System.Drawing.Point(18, 309);
            this.BTcancela.Margin = new System.Windows.Forms.Padding(5);
            this.BTcancela.Name = "BTcancela";
            this.BTcancela.Size = new System.Drawing.Size(181, 41);
            this.BTcancela.TabIndex = 60;
            this.BTcancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTcancela.Visible = false;
            this.BTcancela.Click += new System.EventHandler(this.BTcancela_Click);
            // 
            // BThistorico
            // 
            this.BThistorico.ActiveBorderThickness = 1;
            this.BThistorico.ActiveCornerRadius = 1;
            this.BThistorico.ActiveFillColor = System.Drawing.Color.Lime;
            this.BThistorico.ActiveForecolor = System.Drawing.Color.White;
            this.BThistorico.ActiveLineColor = System.Drawing.Color.Lime;
            this.BThistorico.BackColor = System.Drawing.Color.White;
            this.BThistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BThistorico.BackgroundImage")));
            this.BThistorico.ButtonText = "Gerar histórico";
            this.BThistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BThistorico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BThistorico.ForeColor = System.Drawing.Color.Lime;
            this.BThistorico.IdleBorderThickness = 1;
            this.BThistorico.IdleCornerRadius = 1;
            this.BThistorico.IdleFillColor = System.Drawing.Color.White;
            this.BThistorico.IdleForecolor = System.Drawing.Color.Lime;
            this.BThistorico.IdleLineColor = System.Drawing.Color.Lime;
            this.BThistorico.Location = new System.Drawing.Point(18, 267);
            this.BThistorico.Margin = new System.Windows.Forms.Padding(5);
            this.BThistorico.Name = "BThistorico";
            this.BThistorico.Size = new System.Drawing.Size(181, 41);
            this.BThistorico.TabIndex = 63;
            this.BThistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BThistorico.Click += new System.EventHandler(this.BTdel_Click);
            // 
            // Add_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 377);
            this.Controls.Add(this.BThistorico);
            this.Controls.Add(this.BTcancela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTtelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTemail);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.DGclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_clientes";
            this.Text = "Add_clientes";
            this.Load += new System.EventHandler(this.Add_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTemail;
        private Bunifu.Framework.UI.BunifuThinButton2 BTadd;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTtelefone;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTnome;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 BTcancela;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private Bunifu.Framework.UI.BunifuThinButton2 BThistorico;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DGclientes;
    }
}