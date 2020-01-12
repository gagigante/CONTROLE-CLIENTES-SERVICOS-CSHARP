namespace WFservicos
{
    partial class Movimentacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimentacoes));
            this.DGmovimentacoes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTservico = new System.Windows.Forms.TextBox();
            this.TXTobs = new System.Windows.Forms.TextBox();
            this.TXTpago = new System.Windows.Forms.TextBox();
            this.TXTvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGmovimentacoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGmovimentacoes
            // 
            this.DGmovimentacoes.AllowUserToAddRows = false;
            this.DGmovimentacoes.AllowUserToDeleteRows = false;
            this.DGmovimentacoes.AllowUserToResizeColumns = false;
            this.DGmovimentacoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGmovimentacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGmovimentacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DGmovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGmovimentacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGmovimentacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGmovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGmovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.data,
            this.cod});
            this.DGmovimentacoes.DoubleBuffered = true;
            this.DGmovimentacoes.EnableHeadersVisualStyles = false;
            this.DGmovimentacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGmovimentacoes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.DGmovimentacoes.HeaderForeColor = System.Drawing.Color.White;
            this.DGmovimentacoes.Location = new System.Drawing.Point(108, 38);
            this.DGmovimentacoes.Name = "DGmovimentacoes";
            this.DGmovimentacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGmovimentacoes.RowHeadersWidth = 25;
            this.DGmovimentacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGmovimentacoes.Size = new System.Drawing.Size(248, 245);
            this.DGmovimentacoes.TabIndex = 42;
            this.DGmovimentacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGmovimentacoes_CellClick);
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 70;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 130;
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.DGmovimentacoes;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Serviços:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "OBS:";
            // 
            // TXTservico
            // 
            this.TXTservico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.TXTservico.Location = new System.Drawing.Point(14, 112);
            this.TXTservico.Multiline = true;
            this.TXTservico.Name = "TXTservico";
            this.TXTservico.ReadOnly = true;
            this.TXTservico.Size = new System.Drawing.Size(121, 58);
            this.TXTservico.TabIndex = 67;
            // 
            // TXTobs
            // 
            this.TXTobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.TXTobs.Location = new System.Drawing.Point(140, 112);
            this.TXTobs.Multiline = true;
            this.TXTobs.Name = "TXTobs";
            this.TXTobs.ReadOnly = true;
            this.TXTobs.Size = new System.Drawing.Size(121, 58);
            this.TXTobs.TabIndex = 66;
            // 
            // TXTpago
            // 
            this.TXTpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.TXTpago.Location = new System.Drawing.Point(140, 198);
            this.TXTpago.Name = "TXTpago";
            this.TXTpago.ReadOnly = true;
            this.TXTpago.Size = new System.Drawing.Size(100, 20);
            this.TXTpago.TabIndex = 75;
            this.TXTpago.TextChanged += new System.EventHandler(this.TXTpago_TextChanged);
            // 
            // TXTvalor
            // 
            this.TXTvalor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.TXTvalor.Location = new System.Drawing.Point(14, 198);
            this.TXTvalor.Name = "TXTvalor";
            this.TXTvalor.ReadOnly = true;
            this.TXTvalor.Size = new System.Drawing.Size(100, 20);
            this.TXTvalor.TabIndex = 74;
            this.TXTvalor.TextChanged += new System.EventHandler(this.TXTvalor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Total pago:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Total dos serviços:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.TXTcliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXTpago);
            this.panel1.Controls.Add(this.TXTobs);
            this.panel1.Controls.Add(this.TXTvalor);
            this.panel1.Controls.Add(this.TXTservico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(373, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 245);
            this.panel1.TabIndex = 76;
            // 
            // TXTcliente
            // 
            this.TXTcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.TXTcliente.Location = new System.Drawing.Point(14, 69);
            this.TXTcliente.Name = "TXTcliente";
            this.TXTcliente.ReadOnly = true;
            this.TXTcliente.Size = new System.Drawing.Size(175, 20);
            this.TXTcliente.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Serviço referente:";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Ultimas movimentações:";
            // 
            // Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGmovimentacoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Movimentacoes";
            this.Text = "Movimentacoes";
            this.Load += new System.EventHandler(this.Movimentacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGmovimentacoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DGmovimentacoes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTservico;
        private System.Windows.Forms.TextBox TXTobs;
        public System.Windows.Forms.TextBox TXTpago;
        private System.Windows.Forms.TextBox TXTvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox TXTcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}