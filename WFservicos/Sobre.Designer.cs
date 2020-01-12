namespace WFservicos
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBlogo = new System.Windows.Forms.PictureBox();
            this.BTsair = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(10, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "v1.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(99, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "(11) 96859-5762";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(33, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "gabriel_gigante@outlook.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desenvolvido por Gabriel Gigante";
            // 
            // PBlogo
            // 
            this.PBlogo.Image = ((System.Drawing.Image)(resources.GetObject("PBlogo.Image")));
            this.PBlogo.Location = new System.Drawing.Point(96, 14);
            this.PBlogo.Name = "PBlogo";
            this.PBlogo.Size = new System.Drawing.Size(165, 108);
            this.PBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBlogo.TabIndex = 14;
            this.PBlogo.TabStop = false;
            // 
            // BTsair
            // 
            this.BTsair.BackColor = System.Drawing.SystemColors.Control;
            this.BTsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTsair.Image = ((System.Drawing.Image)(resources.GetObject("BTsair.Image")));
            this.BTsair.ImageActive = null;
            this.BTsair.Location = new System.Drawing.Point(334, 4);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(25, 25);
            this.BTsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTsair.TabIndex = 19;
            this.BTsair.TabStop = false;
            this.BTsair.Zoom = 10;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 278);
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBlogo;
        private Bunifu.Framework.UI.BunifuImageButton BTsair;
    }
}