namespace WFservicos
{
    partial class Detalhes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalhes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BTsair = new Bunifu.Framework.UI.BunifuImageButton();
            this.DGmovimento = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fpag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcliente = new System.Windows.Forms.Panel();
            this.TXTtelefone = new System.Windows.Forms.MaskedTextBox();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBnomeForm = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTdata = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTpago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTvalor = new System.Windows.Forms.TextBox();
            this.TXTstatus = new System.Windows.Forms.TextBox();
            this.TXTsituacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTgerarPDF = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXTservico = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TXTobs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TXTdataFin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGmovimento)).BeginInit();
            this.Pcliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BTsair
            // 
            this.BTsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.BTsair.Image = ((System.Drawing.Image)(resources.GetObject("BTsair.Image")));
            this.BTsair.ImageActive = null;
            this.BTsair.Location = new System.Drawing.Point(766, 7);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(25, 25);
            this.BTsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTsair.TabIndex = 2;
            this.BTsair.TabStop = false;
            this.BTsair.Zoom = 10;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // DGmovimento
            // 
            this.DGmovimento.AllowUserToAddRows = false;
            this.DGmovimento.AllowUserToDeleteRows = false;
            this.DGmovimento.AllowUserToResizeColumns = false;
            this.DGmovimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGmovimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGmovimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DGmovimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGmovimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGmovimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGmovimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGmovimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.Fpag,
            this.data});
            this.DGmovimento.DoubleBuffered = true;
            this.DGmovimento.EnableHeadersVisualStyles = false;
            this.DGmovimento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGmovimento.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGmovimento.HeaderForeColor = System.Drawing.Color.White;
            this.DGmovimento.Location = new System.Drawing.Point(396, 196);
            this.DGmovimento.Name = "DGmovimento";
            this.DGmovimento.ReadOnly = true;
            this.DGmovimento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGmovimento.RowHeadersWidth = 25;
            this.DGmovimento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGmovimento.Size = new System.Drawing.Size(369, 205);
            this.DGmovimento.TabIndex = 35;
            this.DGmovimento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGmovimento_MouseClick);
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 70;
            // 
            // Fpag
            // 
            this.Fpag.HeaderText = "Forma de pagamento";
            this.Fpag.Name = "Fpag";
            this.Fpag.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data de pagamento";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 150;
            // 
            // Pcliente
            // 
            this.Pcliente.BackColor = System.Drawing.SystemColors.Control;
            this.Pcliente.Controls.Add(this.TXTtelefone);
            this.Pcliente.Controls.Add(this.TXTemail);
            this.Pcliente.Controls.Add(this.TXTnome);
            this.Pcliente.Controls.Add(this.label4);
            this.Pcliente.Controls.Add(this.label3);
            this.Pcliente.Controls.Add(this.label2);
            this.Pcliente.Controls.Add(this.label1);
            this.Pcliente.Location = new System.Drawing.Point(46, 65);
            this.Pcliente.Name = "Pcliente";
            this.Pcliente.Size = new System.Drawing.Size(327, 142);
            this.Pcliente.TabIndex = 36;
            // 
            // TXTtelefone
            // 
            this.TXTtelefone.Location = new System.Drawing.Point(133, 73);
            this.TXTtelefone.Mask = "(99) 00000-0000";
            this.TXTtelefone.Name = "TXTtelefone";
            this.TXTtelefone.ReadOnly = true;
            this.TXTtelefone.Size = new System.Drawing.Size(100, 20);
            this.TXTtelefone.TabIndex = 71;
            // 
            // TXTemail
            // 
            this.TXTemail.Location = new System.Drawing.Point(133, 100);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.ReadOnly = true;
            this.TXTemail.Size = new System.Drawing.Size(165, 20);
            this.TXTemail.TabIndex = 70;
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(133, 48);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.ReadOnly = true;
            this.TXTnome.Size = new System.Drawing.Size(165, 20);
            this.TXTnome.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.LBnomeForm);
            this.panel2.Controls.Add(this.BTsair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 39;
            // 
            // LBnomeForm
            // 
            this.LBnomeForm.AutoSize = true;
            this.LBnomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnomeForm.ForeColor = System.Drawing.Color.White;
            this.LBnomeForm.Location = new System.Drawing.Point(12, 14);
            this.LBnomeForm.Name = "LBnomeForm";
            this.LBnomeForm.Size = new System.Drawing.Size(110, 24);
            this.LBnomeForm.TabIndex = 3;
            this.LBnomeForm.Text = "DETALHES";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TXTdataFin);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TXTdata);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TXTpago);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TXTvalor);
            this.panel1.Controls.Add(this.TXTstatus);
            this.panel1.Controls.Add(this.TXTsituacao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(46, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 204);
            this.panel1.TabIndex = 71;
            // 
            // TXTdata
            // 
            this.TXTdata.Location = new System.Drawing.Point(175, 146);
            this.TXTdata.MaxLength = 100;
            this.TXTdata.Name = "TXTdata";
            this.TXTdata.ReadOnly = true;
            this.TXTdata.Size = new System.Drawing.Size(100, 20);
            this.TXTdata.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 73;
            this.label8.Text = "Serviço:";
            // 
            // TXTpago
            // 
            this.TXTpago.Location = new System.Drawing.Point(175, 120);
            this.TXTpago.Name = "TXTpago";
            this.TXTpago.ReadOnly = true;
            this.TXTpago.Size = new System.Drawing.Size(100, 20);
            this.TXTpago.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 21);
            this.label11.TabIndex = 73;
            this.label11.Text = "Data cadastro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 71;
            this.label9.Text = "Situação:";
            // 
            // TXTvalor
            // 
            this.TXTvalor.Location = new System.Drawing.Point(175, 94);
            this.TXTvalor.Name = "TXTvalor";
            this.TXTvalor.ReadOnly = true;
            this.TXTvalor.Size = new System.Drawing.Size(100, 20);
            this.TXTvalor.TabIndex = 70;
            // 
            // TXTstatus
            // 
            this.TXTstatus.Location = new System.Drawing.Point(175, 68);
            this.TXTstatus.Name = "TXTstatus";
            this.TXTstatus.ReadOnly = true;
            this.TXTstatus.Size = new System.Drawing.Size(100, 20);
            this.TXTstatus.TabIndex = 69;
            // 
            // TXTsituacao
            // 
            this.TXTsituacao.Location = new System.Drawing.Point(175, 42);
            this.TXTsituacao.Name = "TXTsituacao";
            this.TXTsituacao.ReadOnly = true;
            this.TXTsituacao.Size = new System.Drawing.Size(100, 20);
            this.TXTsituacao.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Status:";
            // 
            // BTgerarPDF
            // 
            this.BTgerarPDF.Location = new System.Drawing.Point(396, 407);
            this.BTgerarPDF.Name = "BTgerarPDF";
            this.BTgerarPDF.Size = new System.Drawing.Size(152, 23);
            this.BTgerarPDF.TabIndex = 76;
            this.BTgerarPDF.Text = "Gerar relatório de serviço";
            this.BTgerarPDF.UseVisualStyleBackColor = true;
            this.BTgerarPDF.Click += new System.EventHandler(this.BTgerarPDF_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.TXTservico);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(396, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 110);
            this.panel3.TabIndex = 71;
            // 
            // TXTservico
            // 
            this.TXTservico.Location = new System.Drawing.Point(18, 33);
            this.TXTservico.Multiline = true;
            this.TXTservico.Name = "TXTservico";
            this.TXTservico.ReadOnly = true;
            this.TXTservico.Size = new System.Drawing.Size(121, 58);
            this.TXTservico.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Serviço:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.TXTobs);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(591, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 110);
            this.panel4.TabIndex = 72;
            // 
            // TXTobs
            // 
            this.TXTobs.Location = new System.Drawing.Point(18, 33);
            this.TXTobs.Multiline = true;
            this.TXTobs.Name = "TXTobs";
            this.TXTobs.ReadOnly = true;
            this.TXTobs.Size = new System.Drawing.Size(121, 58);
            this.TXTobs.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "OBS:";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.Pcliente;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.panel3;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.panel4;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.DGmovimento;
            // 
            // TXTdataFin
            // 
            this.TXTdataFin.Location = new System.Drawing.Point(175, 172);
            this.TXTdataFin.MaxLength = 100;
            this.TXTdataFin.Name = "TXTdataFin";
            this.TXTdataFin.ReadOnly = true;
            this.TXTdataFin.Size = new System.Drawing.Size(100, 20);
            this.TXTdataFin.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 76;
            this.label10.Text = "Data finalização:";
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTgerarPDF);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pcliente);
            this.Controls.Add(this.DGmovimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Detalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGmovimento)).EndInit();
            this.Pcliente.ResumeLayout(false);
            this.Pcliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton BTsair;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGmovimento;
        private System.Windows.Forms.Panel Pcliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.TextBox TXTnome;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label LBnomeForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTdata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTpago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTvalor;
        private System.Windows.Forms.TextBox TXTstatus;
        private System.Windows.Forms.TextBox TXTsituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTobs;
        private System.Windows.Forms.TextBox TXTservico;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.MaskedTextBox TXTtelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fpag;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button BTgerarPDF;
        private System.Windows.Forms.TextBox TXTdataFin;
        private System.Windows.Forms.Label label10;
    }
}