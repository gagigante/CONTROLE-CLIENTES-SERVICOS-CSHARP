namespace WFservicos
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Pconteudo = new System.Windows.Forms.Panel();
            this.Pheader = new System.Windows.Forms.Panel();
            this.Ptitulo = new System.Windows.Forms.Panel();
            this.LBnomeForm = new System.Windows.Forms.Label();
            this.LBsobre = new System.Windows.Forms.Label();
            this.LBusers = new System.Windows.Forms.Label();
            this.BTsair = new Bunifu.Framework.UI.BunifuImageButton();
            this.Plateral = new System.Windows.Forms.Panel();
            this.BT4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Plogo = new System.Windows.Forms.Panel();
            this.PBlogo = new System.Windows.Forms.PictureBox();
            this.Pmenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Pheader.SuspendLayout();
            this.Ptitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).BeginInit();
            this.Plateral.SuspendLayout();
            this.Plogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).BeginInit();
            this.Pmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pconteudo
            // 
            this.Pconteudo.BackColor = System.Drawing.Color.White;
            this.Pconteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pconteudo.Location = new System.Drawing.Point(189, 123);
            this.Pconteudo.Name = "Pconteudo";
            this.Pconteudo.Size = new System.Drawing.Size(761, 377);
            this.Pconteudo.TabIndex = 5;
            // 
            // Pheader
            // 
            this.Pheader.BackColor = System.Drawing.Color.White;
            this.Pheader.Controls.Add(this.Ptitulo);
            this.Pheader.Controls.Add(this.LBsobre);
            this.Pheader.Controls.Add(this.LBusers);
            this.Pheader.Controls.Add(this.BTsair);
            this.Pheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pheader.Location = new System.Drawing.Point(189, 0);
            this.Pheader.Name = "Pheader";
            this.Pheader.Size = new System.Drawing.Size(761, 123);
            this.Pheader.TabIndex = 4;
            // 
            // Ptitulo
            // 
            this.Ptitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.Ptitulo.Controls.Add(this.LBnomeForm);
            this.Ptitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ptitulo.Location = new System.Drawing.Point(0, 68);
            this.Ptitulo.Name = "Ptitulo";
            this.Ptitulo.Size = new System.Drawing.Size(761, 55);
            this.Ptitulo.TabIndex = 0;
            // 
            // LBnomeForm
            // 
            this.LBnomeForm.AutoSize = true;
            this.LBnomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnomeForm.ForeColor = System.Drawing.Color.White;
            this.LBnomeForm.Location = new System.Drawing.Point(19, 16);
            this.LBnomeForm.Name = "LBnomeForm";
            this.LBnomeForm.Size = new System.Drawing.Size(230, 24);
            this.LBnomeForm.TabIndex = 1;
            this.LBnomeForm.Text = "NOME DO FORMULARIO";
            // 
            // LBsobre
            // 
            this.LBsobre.AutoSize = true;
            this.LBsobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBsobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.LBsobre.Location = new System.Drawing.Point(223, 24);
            this.LBsobre.Name = "LBsobre";
            this.LBsobre.Size = new System.Drawing.Size(52, 20);
            this.LBsobre.TabIndex = 3;
            this.LBsobre.Text = "Sobre";
            this.LBsobre.Click += new System.EventHandler(this.LBsobre_Click);
            // 
            // LBusers
            // 
            this.LBusers.AutoSize = true;
            this.LBusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBusers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.LBusers.Location = new System.Drawing.Point(42, 24);
            this.LBusers.Name = "LBusers";
            this.LBusers.Size = new System.Drawing.Size(143, 20);
            this.LBusers.TabIndex = 2;
            this.LBusers.Text = "Gerenciar usuários";
            this.LBusers.Click += new System.EventHandler(this.LBusers_Click);
            // 
            // BTsair
            // 
            this.BTsair.BackColor = System.Drawing.Color.White;
            this.BTsair.Image = ((System.Drawing.Image)(resources.GetObject("BTsair.Image")));
            this.BTsair.ImageActive = null;
            this.BTsair.Location = new System.Drawing.Point(730, 5);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(25, 25);
            this.BTsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTsair.TabIndex = 1;
            this.BTsair.TabStop = false;
            this.BTsair.Zoom = 10;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // Plateral
            // 
            this.Plateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(253)))));
            this.Plateral.Controls.Add(this.BT4);
            this.Plateral.Controls.Add(this.BT3);
            this.Plateral.Controls.Add(this.BT2);
            this.Plateral.Controls.Add(this.BT1);
            this.Plateral.Controls.Add(this.Plogo);
            this.Plateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Plateral.Location = new System.Drawing.Point(0, 0);
            this.Plateral.Name = "Plateral";
            this.Plateral.Size = new System.Drawing.Size(189, 500);
            this.Plateral.TabIndex = 3;
            // 
            // BT4
            // 
            this.BT4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(204)))));
            this.BT4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT4.BorderRadius = 0;
            this.BT4.ButtonText = "Relatórios";
            this.BT4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT4.DisabledColor = System.Drawing.Color.Gray;
            this.BT4.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(172)))), ((int)(((byte)(212)))));
            this.BT4.Iconimage = ((System.Drawing.Image)(resources.GetObject("BT4.Iconimage")));
            this.BT4.Iconimage_right = null;
            this.BT4.Iconimage_right_Selected = null;
            this.BT4.Iconimage_Selected = null;
            this.BT4.IconMarginLeft = 0;
            this.BT4.IconMarginRight = 0;
            this.BT4.IconRightVisible = true;
            this.BT4.IconRightZoom = 0D;
            this.BT4.IconVisible = true;
            this.BT4.IconZoom = 80D;
            this.BT4.IsTab = false;
            this.BT4.Location = new System.Drawing.Point(-2, 286);
            this.BT4.Name = "BT4";
            this.BT4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.BT4.OnHoverTextColor = System.Drawing.Color.White;
            this.BT4.selected = false;
            this.BT4.Size = new System.Drawing.Size(196, 48);
            this.BT4.TabIndex = 4;
            this.BT4.Text = "Relatórios";
            this.BT4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT4.Textcolor = System.Drawing.Color.White;
            this.BT4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT4.Click += new System.EventHandler(this.BT4_Click);
            // 
            // BT3
            // 
            this.BT3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(204)))));
            this.BT3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT3.BorderRadius = 0;
            this.BT3.ButtonText = "Serviços";
            this.BT3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT3.DisabledColor = System.Drawing.Color.Gray;
            this.BT3.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(172)))), ((int)(((byte)(212)))));
            this.BT3.Iconimage = ((System.Drawing.Image)(resources.GetObject("BT3.Iconimage")));
            this.BT3.Iconimage_right = null;
            this.BT3.Iconimage_right_Selected = null;
            this.BT3.Iconimage_Selected = null;
            this.BT3.IconMarginLeft = 0;
            this.BT3.IconMarginRight = 0;
            this.BT3.IconRightVisible = true;
            this.BT3.IconRightZoom = 0D;
            this.BT3.IconVisible = true;
            this.BT3.IconZoom = 80D;
            this.BT3.IsTab = false;
            this.BT3.Location = new System.Drawing.Point(-2, 236);
            this.BT3.Name = "BT3";
            this.BT3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.BT3.OnHoverTextColor = System.Drawing.Color.White;
            this.BT3.selected = false;
            this.BT3.Size = new System.Drawing.Size(196, 48);
            this.BT3.TabIndex = 3;
            this.BT3.Text = "Serviços";
            this.BT3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT3.Textcolor = System.Drawing.Color.White;
            this.BT3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT3.Click += new System.EventHandler(this.BT3_Click);
            // 
            // BT2
            // 
            this.BT2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(204)))));
            this.BT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT2.BorderRadius = 0;
            this.BT2.ButtonText = "Adicionar serviço";
            this.BT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT2.DisabledColor = System.Drawing.Color.Gray;
            this.BT2.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(172)))), ((int)(((byte)(212)))));
            this.BT2.Iconimage = ((System.Drawing.Image)(resources.GetObject("BT2.Iconimage")));
            this.BT2.Iconimage_right = null;
            this.BT2.Iconimage_right_Selected = null;
            this.BT2.Iconimage_Selected = null;
            this.BT2.IconMarginLeft = 0;
            this.BT2.IconMarginRight = 0;
            this.BT2.IconRightVisible = true;
            this.BT2.IconRightZoom = 0D;
            this.BT2.IconVisible = true;
            this.BT2.IconZoom = 80D;
            this.BT2.IsTab = false;
            this.BT2.Location = new System.Drawing.Point(-2, 186);
            this.BT2.Name = "BT2";
            this.BT2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.BT2.OnHoverTextColor = System.Drawing.Color.White;
            this.BT2.selected = false;
            this.BT2.Size = new System.Drawing.Size(196, 48);
            this.BT2.TabIndex = 2;
            this.BT2.Text = "Adicionar serviço";
            this.BT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT2.Textcolor = System.Drawing.Color.White;
            this.BT2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT2.Click += new System.EventHandler(this.BT2_Click);
            // 
            // BT1
            // 
            this.BT1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(204)))));
            this.BT1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT1.BorderRadius = 0;
            this.BT1.ButtonText = "Clientes";
            this.BT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT1.DisabledColor = System.Drawing.Color.Gray;
            this.BT1.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(172)))), ((int)(((byte)(212)))));
            this.BT1.Iconimage = ((System.Drawing.Image)(resources.GetObject("BT1.Iconimage")));
            this.BT1.Iconimage_right = null;
            this.BT1.Iconimage_right_Selected = null;
            this.BT1.Iconimage_Selected = null;
            this.BT1.IconMarginLeft = 0;
            this.BT1.IconMarginRight = 0;
            this.BT1.IconRightVisible = true;
            this.BT1.IconRightZoom = 0D;
            this.BT1.IconVisible = true;
            this.BT1.IconZoom = 80D;
            this.BT1.IsTab = false;
            this.BT1.Location = new System.Drawing.Point(-2, 136);
            this.BT1.Name = "BT1";
            this.BT1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.BT1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.BT1.OnHoverTextColor = System.Drawing.Color.White;
            this.BT1.selected = false;
            this.BT1.Size = new System.Drawing.Size(196, 48);
            this.BT1.TabIndex = 1;
            this.BT1.Text = "Clientes";
            this.BT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT1.Textcolor = System.Drawing.Color.White;
            this.BT1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // Plogo
            // 
            this.Plogo.Controls.Add(this.PBlogo);
            this.Plogo.Controls.Add(this.Pmenu);
            this.Plogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plogo.Location = new System.Drawing.Point(0, 0);
            this.Plogo.Name = "Plogo";
            this.Plogo.Size = new System.Drawing.Size(189, 123);
            this.Plogo.TabIndex = 0;
            // 
            // PBlogo
            // 
            this.PBlogo.Image = ((System.Drawing.Image)(resources.GetObject("PBlogo.Image")));
            this.PBlogo.Location = new System.Drawing.Point(39, 3);
            this.PBlogo.Name = "PBlogo";
            this.PBlogo.Size = new System.Drawing.Size(120, 63);
            this.PBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBlogo.TabIndex = 1;
            this.PBlogo.TabStop = false;
            // 
            // Pmenu
            // 
            this.Pmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.Pmenu.Controls.Add(this.label1);
            this.Pmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pmenu.Location = new System.Drawing.Point(0, 68);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Size = new System.Drawing.Size(189, 55);
            this.Pmenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PBlogo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.Pheader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.Plogo;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.Pconteudo);
            this.Controls.Add(this.Pheader);
            this.Controls.Add(this.Plateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WFhome";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Pheader.ResumeLayout(false);
            this.Pheader.PerformLayout();
            this.Ptitulo.ResumeLayout(false);
            this.Ptitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTsair)).EndInit();
            this.Plateral.ResumeLayout(false);
            this.Plogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).EndInit();
            this.Pmenu.ResumeLayout(false);
            this.Pmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pconteudo;
        private System.Windows.Forms.Panel Pheader;
        private System.Windows.Forms.Panel Ptitulo;
        private System.Windows.Forms.Label LBnomeForm;
        private System.Windows.Forms.Label LBsobre;
        private System.Windows.Forms.Label LBusers;
        private Bunifu.Framework.UI.BunifuImageButton BTsair;
        private System.Windows.Forms.Panel Plateral;
        private Bunifu.Framework.UI.BunifuFlatButton BT4;
        private Bunifu.Framework.UI.BunifuFlatButton BT3;
        private Bunifu.Framework.UI.BunifuFlatButton BT2;
        private Bunifu.Framework.UI.BunifuFlatButton BT1;
        private System.Windows.Forms.Panel Plogo;
        private System.Windows.Forms.PictureBox PBlogo;
        private System.Windows.Forms.Panel Pmenu;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}