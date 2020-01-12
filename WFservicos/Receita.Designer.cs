namespace WFservicos
{
    partial class Receita
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTpago = new System.Windows.Forms.Label();
            this.TXTvalor = new System.Windows.Forms.Label();
            this.TXTservicos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CBano = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBitem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.BackColor = System.Drawing.SystemColors.Control;
            this.grafico.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.grafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            this.grafico.Enabled = false;
            this.grafico.Location = new System.Drawing.Point(372, 80);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(361, 194);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.TXTpago);
            this.panel1.Controls.Add(this.TXTvalor);
            this.panel1.Controls.Add(this.TXTservicos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 232);
            this.panel1.TabIndex = 1;
            // 
            // TXTpago
            // 
            this.TXTpago.AutoSize = true;
            this.TXTpago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTpago.ForeColor = System.Drawing.Color.White;
            this.TXTpago.Location = new System.Drawing.Point(13, 155);
            this.TXTpago.Name = "TXTpago";
            this.TXTpago.Size = new System.Drawing.Size(124, 20);
            this.TXTpago.TabIndex = 3;
            this.TXTpago.Text = "Valor recebido:";
            // 
            // TXTvalor
            // 
            this.TXTvalor.AutoSize = true;
            this.TXTvalor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTvalor.ForeColor = System.Drawing.Color.White;
            this.TXTvalor.Location = new System.Drawing.Point(13, 114);
            this.TXTvalor.Name = "TXTvalor";
            this.TXTvalor.Size = new System.Drawing.Size(146, 20);
            this.TXTvalor.TabIndex = 2;
            this.TXTvalor.Text = "Valor dos serviços:";
            // 
            // TXTservicos
            // 
            this.TXTservicos.AutoSize = true;
            this.TXTservicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTservicos.ForeColor = System.Drawing.Color.White;
            this.TXTservicos.Location = new System.Drawing.Point(13, 73);
            this.TXTservicos.Name = "TXTservicos";
            this.TXTservicos.Size = new System.Drawing.Size(151, 20);
            this.TXTservicos.TabIndex = 1;
            this.TXTservicos.Text = "Serviços realizados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Este mês:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // CBano
            // 
            this.CBano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBano.FormattingEnabled = true;
            this.CBano.Location = new System.Drawing.Point(372, 42);
            this.CBano.Name = "CBano";
            this.CBano.Size = new System.Drawing.Size(121, 21);
            this.CBano.TabIndex = 2;
            this.CBano.SelectedIndexChanged += new System.EventHandler(this.CBano_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item:";
            // 
            // CBitem
            // 
            this.CBitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBitem.FormattingEnabled = true;
            this.CBitem.Items.AddRange(new object[] {
            "Serviços realizados",
            "Valor dos serviços",
            "Valor recebido"});
            this.CBitem.Location = new System.Drawing.Point(499, 42);
            this.CBitem.Name = "CBitem";
            this.CBitem.Size = new System.Drawing.Size(121, 21);
            this.CBitem.TabIndex = 5;
            this.CBitem.SelectedIndexChanged += new System.EventHandler(this.CBitem_SelectedIndexChanged);
            // 
            // Receita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBitem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBano);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grafico);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receita";
            this.Text = "Receita";
            this.Load += new System.EventHandler(this.Receita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label TXTpago;
        private System.Windows.Forms.Label TXTvalor;
        private System.Windows.Forms.Label TXTservicos;
        private System.Windows.Forms.ComboBox CBano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBitem;
    }
}