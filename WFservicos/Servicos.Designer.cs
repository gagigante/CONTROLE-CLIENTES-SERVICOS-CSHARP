namespace WFservicos
{
    partial class Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            this.DGservicos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBsituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBclientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTaddValor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TXTservico = new System.Windows.Forms.TextBox();
            this.TXTobs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TXTvalor = new System.Windows.Forms.TextBox();
            this.TXTpagar = new System.Windows.Forms.TextBox();
            this.TXTpago = new System.Windows.Forms.TextBox();
            this.TXTstatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBstatusPagamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTpesquisa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGservicos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.servico,
            this.situacao,
            this.data,
            this.obs,
            this.valor,
            this.Vpago,
            this.status,
            this.cod});
            this.DGservicos.DoubleBuffered = true;
            this.DGservicos.EnableHeadersVisualStyles = false;
            this.DGservicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGservicos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGservicos.HeaderForeColor = System.Drawing.Color.White;
            this.DGservicos.Location = new System.Drawing.Point(12, 61);
            this.DGservicos.Name = "DGservicos";
            this.DGservicos.ReadOnly = true;
            this.DGservicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGservicos.RowHeadersWidth = 25;
            this.DGservicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGservicos.Size = new System.Drawing.Size(450, 304);
            this.DGservicos.TabIndex = 34;
            this.DGservicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGservicos_CellClick);
            this.DGservicos.DoubleClick += new System.EventHandler(this.DGservicos_DoubleClick);
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // servico
            // 
            this.servico.HeaderText = "Serviços";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            this.servico.Width = 130;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 80;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 75;
            // 
            // obs
            // 
            this.obs.HeaderText = "obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Visible = false;
            // 
            // valor
            // 
            this.valor.HeaderText = "valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Visible = false;
            // 
            // Vpago
            // 
            this.Vpago.HeaderText = "Vpago";
            this.Vpago.Name = "Vpago";
            this.Vpago.ReadOnly = true;
            this.Vpago.Visible = false;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // CBsituacao
            // 
            this.CBsituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBsituacao.FormattingEnabled = true;
            this.CBsituacao.Items.AddRange(new object[] {
            "Todos",
            "A fazer",
            "Pendente ",
            "Finalizado"});
            this.CBsituacao.Location = new System.Drawing.Point(20, 25);
            this.CBsituacao.Name = "CBsituacao";
            this.CBsituacao.Size = new System.Drawing.Size(121, 21);
            this.CBsituacao.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Situação:";
            // 
            // CBclientes
            // 
            this.CBclientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBclientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBclientes.FormattingEnabled = true;
            this.CBclientes.Location = new System.Drawing.Point(147, 25);
            this.CBclientes.Name = "CBclientes";
            this.CBclientes.Size = new System.Drawing.Size(121, 21);
            this.CBclientes.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Total dos serviços:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Total pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Total a pagar:";
            // 
            // BTaddValor
            // 
            this.BTaddValor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTaddValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTaddValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTaddValor.BorderRadius = 0;
            this.BTaddValor.ButtonText = "";
            this.BTaddValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTaddValor.DisabledColor = System.Drawing.Color.Gray;
            this.BTaddValor.Iconcolor = System.Drawing.Color.Transparent;
            this.BTaddValor.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTaddValor.Iconimage")));
            this.BTaddValor.Iconimage_right = null;
            this.BTaddValor.Iconimage_right_Selected = null;
            this.BTaddValor.Iconimage_Selected = null;
            this.BTaddValor.IconMarginLeft = 0;
            this.BTaddValor.IconMarginRight = 0;
            this.BTaddValor.IconRightVisible = true;
            this.BTaddValor.IconRightZoom = 0D;
            this.BTaddValor.IconVisible = true;
            this.BTaddValor.IconZoom = 50D;
            this.BTaddValor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BTaddValor.IsTab = false;
            this.BTaddValor.Location = new System.Drawing.Point(589, 240);
            this.BTaddValor.Name = "BTaddValor";
            this.BTaddValor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTaddValor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(234)))));
            this.BTaddValor.OnHoverTextColor = System.Drawing.Color.White;
            this.BTaddValor.selected = false;
            this.BTaddValor.Size = new System.Drawing.Size(30, 30);
            this.BTaddValor.TabIndex = 59;
            this.BTaddValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTaddValor.Textcolor = System.Drawing.Color.White;
            this.BTaddValor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTaddValor.Visible = false;
            this.BTaddValor.Click += new System.EventHandler(this.BTaddValor_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.DGservicos;
            // 
            // TXTservico
            // 
            this.TXTservico.Location = new System.Drawing.Point(483, 78);
            this.TXTservico.Multiline = true;
            this.TXTservico.Name = "TXTservico";
            this.TXTservico.ReadOnly = true;
            this.TXTservico.Size = new System.Drawing.Size(121, 58);
            this.TXTservico.TabIndex = 61;
            // 
            // TXTobs
            // 
            this.TXTobs.Location = new System.Drawing.Point(609, 78);
            this.TXTobs.Multiline = true;
            this.TXTobs.Name = "TXTobs";
            this.TXTobs.ReadOnly = true;
            this.TXTobs.Size = new System.Drawing.Size(121, 58);
            this.TXTobs.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "OBS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Serviços:";
            // 
            // combobox
            // 
            this.combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "A fazer",
            "Pendente",
            "Finalizado"});
            this.combobox.Location = new System.Drawing.Point(483, 160);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(121, 21);
            this.combobox.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Situação:";
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
            this.BTadd.ButtonText = "Salvar alterações";
            this.BTadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.IdleBorderThickness = 1;
            this.BTadd.IdleCornerRadius = 1;
            this.BTadd.IdleFillColor = System.Drawing.Color.White;
            this.BTadd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.BTadd.Location = new System.Drawing.Point(483, 318);
            this.BTadd.Margin = new System.Windows.Forms.Padding(5);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(181, 41);
            this.BTadd.TabIndex = 66;
            this.BTadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // TXTvalor
            // 
            this.TXTvalor.Location = new System.Drawing.Point(483, 204);
            this.TXTvalor.Name = "TXTvalor";
            this.TXTvalor.ReadOnly = true;
            this.TXTvalor.Size = new System.Drawing.Size(100, 20);
            this.TXTvalor.TabIndex = 67;
            // 
            // TXTpagar
            // 
            this.TXTpagar.Location = new System.Drawing.Point(483, 290);
            this.TXTpagar.Name = "TXTpagar";
            this.TXTpagar.ReadOnly = true;
            this.TXTpagar.Size = new System.Drawing.Size(100, 20);
            this.TXTpagar.TabIndex = 68;
            this.TXTpagar.TextChanged += new System.EventHandler(this.TXTpagar_TextChanged);
            // 
            // TXTpago
            // 
            this.TXTpago.Location = new System.Drawing.Point(483, 246);
            this.TXTpago.Name = "TXTpago";
            this.TXTpago.ReadOnly = true;
            this.TXTpago.Size = new System.Drawing.Size(100, 20);
            this.TXTpago.TabIndex = 69;
            this.TXTpago.TextChanged += new System.EventHandler(this.TXTpago_TextChanged);
            // 
            // TXTstatus
            // 
            this.TXTstatus.Location = new System.Drawing.Point(609, 160);
            this.TXTstatus.Name = "TXTstatus";
            this.TXTstatus.ReadOnly = true;
            this.TXTstatus.Size = new System.Drawing.Size(100, 20);
            this.TXTstatus.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(606, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Status pagamento:";
            // 
            // CBstatusPagamento
            // 
            this.CBstatusPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBstatusPagamento.FormattingEnabled = true;
            this.CBstatusPagamento.Items.AddRange(new object[] {
            "Todos",
            "Pendente",
            "Quitado"});
            this.CBstatusPagamento.Location = new System.Drawing.Point(274, 25);
            this.CBstatusPagamento.Name = "CBstatusPagamento";
            this.CBstatusPagamento.Size = new System.Drawing.Size(121, 21);
            this.CBstatusPagamento.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 72;
            this.label10.Text = "Status pagamento:";
            // 
            // BTpesquisa
            // 
            this.BTpesquisa.ActiveBorderThickness = 1;
            this.BTpesquisa.ActiveCornerRadius = 1;
            this.BTpesquisa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTpesquisa.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.BTpesquisa.ActiveLineColor = System.Drawing.Color.Lime;
            this.BTpesquisa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTpesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTpesquisa.BackgroundImage")));
            this.BTpesquisa.ButtonText = "Pesquisar";
            this.BTpesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTpesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTpesquisa.ForeColor = System.Drawing.Color.Lime;
            this.BTpesquisa.IdleBorderThickness = 1;
            this.BTpesquisa.IdleCornerRadius = 1;
            this.BTpesquisa.IdleFillColor = System.Drawing.Color.White;
            this.BTpesquisa.IdleForecolor = System.Drawing.Color.Lime;
            this.BTpesquisa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTpesquisa.Location = new System.Drawing.Point(412, 10);
            this.BTpesquisa.Margin = new System.Windows.Forms.Padding(5);
            this.BTpesquisa.Name = "BTpesquisa";
            this.BTpesquisa.Size = new System.Drawing.Size(96, 41);
            this.BTpesquisa.TabIndex = 74;
            this.BTpesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTpesquisa.Click += new System.EventHandler(this.BTpesquisa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTpesquisa);
            this.panel1.Controls.Add(this.CBsituacao);
            this.panel1.Controls.Add(this.CBstatusPagamento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBclientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 55);
            this.panel1.TabIndex = 75;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TXTstatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXTpago);
            this.Controls.Add(this.TXTpagar);
            this.Controls.Add(this.TXTvalor);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTservico);
            this.Controls.Add(this.TXTobs);
            this.Controls.Add(this.BTaddValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGservicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicos";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGservicos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBsituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBclientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton BTaddValor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox TXTservico;
        private System.Windows.Forms.TextBox TXTobs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 BTadd;
        private System.Windows.Forms.TextBox TXTvalor;
        private System.Windows.Forms.TextBox TXTstatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBstatusPagamento;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TXTpago;
        public System.Windows.Forms.TextBox TXTpagar;
        private Bunifu.Framework.UI.BunifuThinButton2 BTpesquisa;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DGservicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
    }
}