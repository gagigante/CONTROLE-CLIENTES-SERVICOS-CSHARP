using System;
using System.Collections;
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
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        Model model = new Model();
        string sql;
        public double Vmov = 0;
        public string formaPagamento = "";
        string[] itens = new string[2];        

        public void carregaGrid()
        {
            DGservicos.Rows.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    DGservicos.Rows.Add(
                                      model.resultado["tb01_nome"].ToString(),
                                      model.resultado["tb02_servicos"].ToString(),
                                      model.resultado["tb02_situacao"].ToString(),
                                      model.resultado["tb02_data_cadastro"].ToString(),
                                      model.resultado["tb02_obs"].ToString(),
                                      model.resultado["tb02_valor"].ToString(),
                                      model.resultado["tb02_valor_pago"].ToString(),
                                      model.resultado["tb02_status"].ToString(),
                                      model.resultado["tb02_cod"].ToString()
                                       );
                }
            }
            DGservicos.ClearSelection();
        }

        public void carregaComboBox()
        {
            ComboCliente item = null;
            CBclientes.Items.Clear();
            CBclientes.Items.Add("Todos");
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    item = new ComboCliente();
                    item.cli = model.resultado["tb01_nome"].ToString();
                    item.cod = model.resultado["tb01_cod"].ToString();
                    CBclientes.Items.Add(item);
                }
            }
        }

        public void filtro()
        {
            if (CBsituacao.Text != "Todos")
            {
                if (CBclientes.Text != "Todos")
                {
                    if (CBstatusPagamento.Text != "Todos")
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                            + "tb02_situacao = '" + CBsituacao.Text + "' and tb01_nome = '" + CBclientes.Text + "' and tb02_status = '" + CBstatusPagamento.Text + "' order BY tb02_status ,tb02_data_cadastro desc";
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbsituacao cbclientes e cbstatus");
                    }
                    else
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                            + "tb02_situacao = '" + CBsituacao.Text + "' and tb01_nome = '" + CBclientes.Text + "' order BY tb02_status ,tb02_data_cadastro desc"; ;
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbsituacao cbclientes");
                    }
                }
                else
                {
                    if (CBstatusPagamento.Text != "Todos")
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                            + "tb02_situacao = '" + CBsituacao.Text + "' and tb02_status = '" + CBstatusPagamento.Text + "' order BY tb02_status ,tb02_data_cadastro desc"; ;
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbsituacao e cbstatus");
                    }
                    else
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                       + "tb02_situacao = '" + CBsituacao.Text + "' order BY tb02_status ,tb02_data_cadastro desc"; 
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbsituacao");
                    }
                }
            }
            else
            {
                if(CBclientes.Text != "Todos")
                {
                    if (CBstatusPagamento.Text != "Todos")
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                            + "tb01_nome = '" + CBclientes.Text + "' and tb02_status = '" + CBstatusPagamento.Text + "' order BY tb02_status ,tb02_data_cadastro desc";
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbclientes e cbstatus");
                    }
                    else
                    {                        
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                            + "tb01_nome = '" + CBclientes.Text + "' order BY tb02_status ,tb02_data_cadastro desc";
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbclientes");
                    }
                }
                else
                {
                    if(CBstatusPagamento.Text != "Todos")
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente and "
                            + "tb02_status = '" + CBstatusPagamento.Text + "' order BY tb02_status ,tb02_data_cadastro desc";
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("cbstatus");
                    }
                    else
                    {
                        sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente order BY tb02_status ,tb02_data_cadastro desc";
                        model.open();
                        model.Execsql(sql);
                        carregaGrid();
                        model.close();
                        //MessageBox.Show("sem filtro");
                    }
                }
            }
        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            sql = "select * from tb01_clientes order by tb01_nome";
            model.open();
            model.Execsql(sql);
            carregaComboBox();
            model.close();

            sql = "select * from tb01_clientes, tb02_servicos where tb01_cod = tb02_cod_cliente order BY tb02_status ,tb02_data_cadastro desc";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();

            CBsituacao.SelectedIndex = 0;
            CBclientes.SelectedIndex = 0;
            CBstatusPagamento.SelectedIndex = 0;            
        }

        private void DGservicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            TXTservico.Text = DGservicos.CurrentRow.Cells[1].Value.ToString();
            TXTobs.Text = DGservicos.CurrentRow.Cells[4].Value.ToString();
            combobox.Text = DGservicos.CurrentRow.Cells[2].Value.ToString();
            TXTstatus.Text = DGservicos.CurrentRow.Cells[7].Value.ToString();
            TXTvalor.Text = DGservicos.CurrentRow.Cells[5].Value.ToString();
            TXTpago.Text = DGservicos.CurrentRow.Cells[6].Value.ToString();
            TXTpagar.Text = (Convert.ToDouble(TXTvalor.Text) - Convert.ToDouble(TXTpago.Text)).ToString();

            itens[0] = combobox.Text;            
            itens[1] = TXTpagar.Text;            
            
            if (TXTstatus.Text == "Pendente")
            {
                BTaddValor.Visible = true;
            }

            DGservicos.ClearSelection();
        }

        private void BTaddValor_Click(object sender, EventArgs e)
        {
            Add_valor add = new Add_valor(this);
            add.ShowDialog();

        }

        private void TXTpago_TextChanged(object sender, EventArgs e)
        {
            if (TXTvalor.Text != "" && TXTpago.Text != "")
            {
                TXTpagar.Text = (Convert.ToDouble(TXTvalor.Text) - Convert.ToDouble(TXTpago.Text)).ToString();                
            }
        }

        private void TXTpagar_TextChanged(object sender, EventArgs e)
        {            
            if (TXTpagar.Text == "0")
            {
                TXTstatus.Text = "Quitado";
                BTaddValor.Visible = false;
            }
        }

        private void BTadd_Click(object sender, EventArgs e)
        {
            if (TXTvalor.Text != "")
            {
                if (DGservicos.CurrentRow.Cells[2].Value.ToString() != combobox.Text || Vmov != 0)
                {   
                    if(combobox.Text == "Finalizado")
                    {
                        sql = "UPDATE `bd_servicos`.`tb02_servicos` SET `tb02_situacao`='" + combobox.Text + "', " +
                          "tb02_status = '" + TXTstatus.Text + "', tb02_data_finalizacao = now(), tb02_valor_pago = '" + TXTpago.Text + "' " +
                          "WHERE  `tb02_cod`=" + DGservicos.CurrentRow.Cells[8].Value.ToString() + ";";
                    }
                    else
                    {
                        sql = "UPDATE `bd_servicos`.`tb02_servicos` SET `tb02_situacao`='" + combobox.Text + "', " +
                            "tb02_status = '" + TXTstatus.Text + "', tb02_valor_pago = '" + TXTpago.Text + "' " +
                            "WHERE  `tb02_cod`=" + DGservicos.CurrentRow.Cells[8].Value.ToString() + ";";
                    }

                    
                    model.open();
                    model.Runsql(sql);
                    model.close();

                    if (Vmov != 0)
                    {
                        sql = "INSERT INTO `bd_servicos`.`tb03_movimentacoes` (`tb03_cod_servico`, `tb03_valor`, `tb03_forma_pagamento`)"
                        + "VALUES ('" + DGservicos.CurrentRow.Cells[8].Value.ToString() + "', '" + Vmov + "', '" +formaPagamento+ "');";
                        model.open();
                        model.Runsql(sql);
                        model.close();                        
                    }

                    sql = "select * from tb01_clientes, tb02_servicos where tb01_cod = tb02_cod_cliente order BY tb02_status ,tb02_data_cadastro desc";
                    model.open();
                    model.Execsql(sql);
                    carregaGrid();
                    model.close();

                    //limpa filtro 
                    CBsituacao.SelectedIndex = 0;
                    CBclientes.SelectedIndex = 0;
                    CBstatusPagamento.SelectedIndex = 0;

                    itens[0] = "";
                    itens[1] = "";

                    Vmov = 0;
                    formaPagamento = "";
                    combobox.SelectedIndex = -1;
                    TXTservico.Text = "";
                    TXTobs.Text = "";                    
                    TXTstatus.Text = "";
                    TXTvalor.Text = "";
                    TXTpago.Text = "";
                    TXTpagar.Text = "";

                    BTaddValor.Visible = false;

                    MessageBox.Show("Operação realizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Modifique algum item para concluir");
                }
            }
            else
            {
                MessageBox.Show("Selecione um item");
            }            
        }

        private void BTpesquisa_Click(object sender, EventArgs e)
        {            
            filtro();

            TXTservico.Text = "";
            TXTobs.Text = "";
            combobox.SelectedIndex = -1;
            TXTstatus.Text = "";
            TXTvalor.Text = "";
            TXTpago.Text = "";
            TXTpagar.Text = "";

            itens[0] = "";
            itens[1] = "";
            
            BTaddValor.Visible = false;
            
            DGservicos.ClearSelection();
        }

        private void DGservicos_DoubleClick(object sender, EventArgs e)
        {            
            Detalhes det = new Detalhes(this);
            det.ShowDialog();

            DGservicos.ClearSelection();
        }
    }
}
