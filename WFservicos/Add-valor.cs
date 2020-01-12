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
    public partial class Add_valor : Form
    {
        Servicos instancia;

        public Add_valor(Servicos servicos)
        {
            InitializeComponent();

            instancia = servicos;

            //TXTadd.Text = instancia.TXTpago.Text.ToString();
        }

        private void Add_valor_Load(object sender, EventArgs e)
        {

        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (TXTadd.Text != "" && TXTadd.Text != "0" && TXTpagamento.Text != "")
            {
                if (Convert.ToDouble(instancia.TXTpagar.Text) >= Convert.ToDouble(TXTadd.Text) && TXTadd.Text != "")
                {
                    instancia.TXTpago.Text = ((Convert.ToDouble(instancia.TXTpago.Text) + Convert.ToDouble(TXTadd.Text.ToString())).ToString());
                    instancia.TXTpago.Refresh();
                    instancia.Vmov = Convert.ToDouble(TXTadd.Text);
                    instancia.formaPagamento = TXTpagamento.Text;

                    TXTadd.Text = "";
                    TXTpagamento.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("O valor descrito é maior que o valor a ser pago");
                }
            }
            else
            {
                MessageBox.Show("Certifique-se de que os valores foram preenchidos");
            }
        }

        private void TXTadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void TXTpagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }
    }
}
