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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        int selecionado;

        private void BTmov_Click(object sender, EventArgs e)
        {           
            if (selecionado != 1)
            {
                selecionado = 1;
                
                Pconteudo.Controls.Clear();
                Movimentacoes mov = new Movimentacoes();
                mov.TopLevel = false;
                Pconteudo.Controls.Add(mov);
                Pconteudo.Dock = DockStyle.Fill;
                mov.Show();

                BTmov.IdleFillColor = Color.Lime;
                BTmov.IdleForecolor = Color.White;

                BTreceita.IdleFillColor = Color.White;
                BTreceita.IdleForecolor = Color.Lime;
            }
        }

        private void BTreceita_Click(object sender, EventArgs e)
        {
            if (selecionado != 2)
            {
                selecionado = 2;

                Pconteudo.Controls.Clear();
                Receita rec = new Receita();
                rec.TopLevel = false;
                Pconteudo.Controls.Add(rec);
                Pconteudo.Dock = DockStyle.Fill;
                rec.Show();

                BTreceita.IdleFillColor = Color.Lime;
                BTreceita.IdleForecolor = Color.White;

                BTmov.IdleFillColor = Color.White;
                BTmov.IdleForecolor = Color.Lime;
            }
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {            
            selecionado = 1;

            Pconteudo.Controls.Clear();
            Movimentacoes mov = new Movimentacoes();
            mov.TopLevel = false;
            Pconteudo.Controls.Add(mov);
            Pconteudo.Dock = DockStyle.Fill;
            mov.Show();

            BTmov.IdleFillColor = Color.Lime;
            BTmov.IdleForecolor = Color.White;

            BTreceita.IdleFillColor = Color.White;
            BTreceita.IdleForecolor = Color.Lime;            
        }
    }
}
