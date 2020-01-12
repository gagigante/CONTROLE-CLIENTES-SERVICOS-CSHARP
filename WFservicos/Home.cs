using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFservicos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LBsobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        int selecionado;

        private void Home_Load(object sender, EventArgs e)
        {
            selecionado = 1;
            LBnomeForm.Text = "CLIENTES";
            Pconteudo.Controls.Clear();

            Add_clientes add = new Add_clientes();
            add.TopLevel = false;
            Pconteudo.Controls.Add(add);
            Pconteudo.Dock = DockStyle.Fill;
            add.Show();
        }

        //botoes menu
        private void BT1_Click(object sender, EventArgs e)
        {
            if (selecionado != 1)
            {
                selecionado = 1;
                LBnomeForm.Text = "CLIENTES";
                Pconteudo.Controls.Clear();

                Add_clientes add = new Add_clientes();
                add.TopLevel = false;
                Pconteudo.Controls.Add(add);
                Pconteudo.Dock = DockStyle.Fill;
                add.Show();
            }
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            if (selecionado != 2)
            {
                selecionado = 2;
                LBnomeForm.Text = "ADICIONAR SERVIÇO";
                Pconteudo.Controls.Clear();

                Add_servicos add = new Add_servicos();
                add.TopLevel = false;
                Pconteudo.Controls.Add(add);
                Pconteudo.Dock = DockStyle.Fill;
                add.Show();
            }
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            if (selecionado != 3)
            {
                selecionado = 3;
                LBnomeForm.Text = "SERVIÇOS";
                Pconteudo.Controls.Clear();

                Servicos ser = new Servicos();
                ser.TopLevel = false;
                Pconteudo.Controls.Add(ser);
                Pconteudo.Dock = DockStyle.Fill;
                ser.Show();
            }
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            if (selecionado != 4)
            {
                selecionado = 4;
                LBnomeForm.Text = "RELATÓRIOS";
                Pconteudo.Controls.Clear();

                Relatorios rel = new Relatorios();
                rel.TopLevel = false;
                Pconteudo.Controls.Add(rel);
                Pconteudo.Dock = DockStyle.Fill;
                rel.Show();
            }
        }

        private void LBusers_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.ShowDialog();
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
