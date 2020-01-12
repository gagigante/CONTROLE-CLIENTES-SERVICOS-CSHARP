namespace WFservicos
{
    partial class Add_servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_servicos));
            this.label5 = new System.Windows.Forms.Label();
            this.DGservicos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorservico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CBcliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTvalor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTobs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TXTservicos = new System.Windows.Forms.TextBox();
            this.CBsituacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BTcancela = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BTdel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGservicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Serviços:";
            // 
            // DGservicos
            // 
            this.DGservicos.AllowUserToAddRows = false;
            this.DGservicos.AllowUserToDeleteRows = false;
            this.DGservicos.AllowUserToResizeColumns = false;
            this.DGservicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGservicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGservicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DGservicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGservicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGservicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGservicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGservicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.servicos,
            this.situacao,
            this.valor,
            this.data,
            this.valorservico,
            this.obs,
            this.cod});
            this.DGservicos.DoubleBuffered = true;
            this.DGservicos.EnableHeadersVisualStyles = false;
            this.DGservicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGservicos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGservicos.HeaderForeColor = System.Drawing.Color.White;
            this.DGservicos.Location = new System.Drawing.Point(254, 24);
            this.DGservicos.Name = "DGservicos";
            this.DGservicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGservicos.RowHeadersWidth = 25;
            this.DGservicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGservicos.Size = new System.Drawing.Size(483, 316);
            this.DGservicos.TabIndex = 41;
            this.DGservicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGservicos_CellClick);
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // servicos
            // 
            this.servicos.HeaderText = "Serviços";
            this.servicos.Name = "servicos";
            this.servicos.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 70;
            // 
            // valor
            // 
            this.valor.HeaderText = "Honorários";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 70;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // valorservico
            // 
            this.valorservico.HeaderText = "valor";
            this.valorservico.Name = "valorservico";
            this.valorservico.ReadOnly = true;
            this.valorservico.Visible = false;
            // 
            // obs
            // 
            this.obs.HeaderText = "obs";
            this.obs.Name = "obs";
            this.obs.Visible = false;
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
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
            this.BTadd.ButtonText = "Adicionar serviço";
            this.BTadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.IdleBorderThickness = 1;
            this.BTadd.IdleCornerRadius = 1;
            this.BTadd.IdleFillColor = System.Drawing.Color.White;
            this.BTadd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.Location = new System.Drawing.Point(20, 260);
            this.BTadd.Margin = new System.Windows.Forms.Padding(5);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(181, 41);
            this.BTadd.TabIndex = 39;
            this.BTadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // CBcliente
            // 
            this.CBcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcliente.FormattingEnabled = true;
            this.CBcliente.Location = new System.Drawing.Point(20, 32);
            this.CBcliente.Name = "CBcliente";
            this.CBcliente.Size = new System.Drawing.Size(121, 21);
            this.CBcliente.TabIndex = 1;
            this.CBcliente.SelectedValueChanged += new System.EventHandler(this.CBcliente_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Valor:";
            // 
            // TXTvalor
            // 
            this.TXTvalor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTvalor.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTvalor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTvalor.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTvalor.BorderThickness = 1;
            this.TXTvalor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTvalor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTvalor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTvalor.isPassword = false;
            this.TXTvalor.Location = new System.Drawing.Point(148, 222);
            this.TXTvalor.Margin = new System.Windows.Forms.Padding(4);
            this.TXTvalor.Name = "TXTvalor";
            this.TXTvalor.Size = new System.Drawing.Size(99, 30);
            this.TXTvalor.TabIndex = 5;
            this.TXTvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTvalor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "OBS(Opcional):";
            // 
            // TXTobs
            // 
            this.TXTobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTobs.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.TXTobs.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTobs.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.TXTobs.BorderThickness = 1;
            this.TXTobs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTobs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXTobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTobs.isPassword = false;
            this.TXTobs.Location = new System.Drawing.Point(20, 164);
            this.TXTobs.Margin = new System.Windows.Forms.Padding(4);
            this.TXTobs.Name = "TXTobs";
            this.TXTobs.Size = new System.Drawing.Size(227, 30);
            this.TXTobs.TabIndex = 3;
            this.TXTobs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTobs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTobs_KeyPress);
            // 
            // TXTservicos
            // 
            this.TXTservicos.Location = new System.Drawing.Point(20, 74);
            this.TXTservicos.Multiline = true;
            this.TXTservicos.Name = "TXTservicos";
            this.TXTservicos.Size = new System.Drawing.Size(227, 67);
            this.TXTservicos.TabIndex = 2;
            this.TXTservicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTservicos_KeyPress);
            // 
            // CBsituacao
            // 
            this.CBsituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBsituacao.FormattingEnabled = true;
            this.CBsituacao.Items.AddRange(new object[] {
            "A fazer",
            "Pendente",
            "Finalizado"});
            this.CBsituacao.Location = new System.Drawing.Point(20, 231);
            this.CBsituacao.Name = "CBsituacao";
            this.CBsituacao.Size = new System.Drawing.Size(121, 21);
            this.CBsituacao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Situação:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.DGservicos;
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
            this.BTcancela.Location = new System.Drawing.Point(20, 298);
            this.BTcancela.Margin = new System.Windows.Forms.Padding(5);
            this.BTcancela.Name = "BTcancela";
            this.BTcancela.Size = new System.Drawing.Size(181, 41);
            this.BTcancela.TabIndex = 61;
            this.BTcancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTcancela.Visible = false;
            this.BTcancela.Click += new System.EventHandler(this.BTcancela_Click);
            // 
            // BTdel
            // 
            this.BTdel.ActiveBorderThickness = 1;
            this.BTdel.ActiveCornerRadius = 1;
            this.BTdel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTdel.ActiveForecolor = System.Drawing.Color.White;
            this.BTdel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTdel.BackColor = System.Drawing.Color.White;
            this.BTdel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTdel.BackgroundImage")));
            this.BTdel.ButtonText = "Remover item";
            this.BTdel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTdel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTdel.IdleBorderThickness = 1;
            this.BTdel.IdleCornerRadius = 1;
            this.BTdel.IdleFillColor = System.Drawing.Color.White;
            this.BTdel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTdel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTdel.Location = new System.Drawing.Point(20, 334);
            this.BTdel.Margin = new System.Windows.Forms.Padding(5);
            this.BTdel.Name = "BTdel";
            this.BTdel.Size = new System.Drawing.Size(181, 41);
            this.BTdel.TabIndex = 62;
            this.BTdel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTdel.Visible = false;
            this.BTdel.Click += new System.EventHandler(this.BTdel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(206, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Só é possível remover itens que não possuem movimentações";
            this.label6.Visible = false;
            // 
            // Add_servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTdel);
            this.Controls.Add(this.BTcancela);
            this.Controls.Add(this.CBsituacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTservicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTvalor);
            this.Controls.Add(this.CBcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGservicos);
            this.Controls.Add(this.BTadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_servicos";
            this.Text = "Add_servicos";
            this.Load += new System.EventHandler(this.Add_servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGservicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGservicos;
        private Bunifu.Framework.UI.BunifuThinButton2 BTadd;
        private System.Windows.Forms.ComboBox CBcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTvalor;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTobs;
        private System.Windows.Forms.TextBox TXTservicos;
        private System.Windows.Forms.ComboBox CBsituacao;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 BTcancela;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorservico;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private Bunifu.Framework.UI.BunifuThinButton2 BTdel;
        private System.Windows.Forms.Label label6;
    }
}