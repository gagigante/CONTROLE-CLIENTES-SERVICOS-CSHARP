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
    public partial class Movimentacoes : Form
    {
        public Movimentacoes()
        {
            InitializeComponent();
        }

        Model model = new Model();
        string sql;

        public void carregaGrid()
        {
            DGmovimentacoes.Rows.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    DGmovimentacoes.Rows.Add(
                                      Convert.ToDouble(model.resultado["tb03_valor"]).ToString("C"),
                                      model.resultado["tb03_data_pagamento"].ToString(),
                                      model.resultado["tb03_cod_servico"].ToString()                                      
                                       );
                }
            }
            DGmovimentacoes.ClearSelection();
        }

        private void Movimentacoes_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tb03_movimentacoes ORDER BY tb03_data_pagamento desc";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();
        }

        private void TXTpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DGmovimentacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {               
            sql = "SELECT * FROM tb02_servicos, tb01_clientes WHERE tb01_cod = tb02_cod_cliente and tb02_cod = " +DGmovimentacoes.CurrentRow.Cells[2].Value.ToString();
            model.open();
            model.Execsql(sql);
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    TXTcliente.Text = model.resultado["tb01_nome"].ToString();
                    TXTservico.Text = model.resultado["tb02_servicos"].ToString();
                    TXTobs.Text = model.resultado["tb02_obs"].ToString();
                    TXTvalor.Text = Convert.ToDouble(model.resultado["tb02_valor"]).ToString("C");
                    TXTpago.Text = Convert.ToDouble(model.resultado["tb02_valor_pago"]).ToString("C");
                }
            }
            model.close();
            
            DGmovimentacoes.ClearSelection();
        }
    }
}
