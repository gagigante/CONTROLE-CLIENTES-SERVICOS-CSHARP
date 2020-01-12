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
    public partial class Add_servicos : Form
    {
        Model model = new Model();
        string sql;

        public void carregaComboBox()
        {            
            ComboCliente item = null;
            CBcliente.Items.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    item = new ComboCliente();
                    item.cli = model.resultado["tb01_nome"].ToString();
                    item.cod = model.resultado["tb01_cod"].ToString();
                    CBcliente.Items.Add(item);
                }
            }
        }

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
                                      Convert.ToDouble(model.resultado["tb02_valor"]).ToString("C"),
                                      model.resultado["tb02_data_cadastro"].ToString(),
                                      model.resultado["tb02_valor"].ToString(),
                                      model.resultado["tb02_obs"].ToString(),
                                      model.resultado["tb02_cod"].ToString()
                                       );
                }
            }
        }

        public Add_servicos()
        {
            InitializeComponent();
        }

        private void Add_servicos_Load(object sender, EventArgs e)
        {
            sql = "select * from tb01_clientes order by tb01_nome";
            model.open();
            model.Execsql(sql);
            carregaComboBox();
            model.close();

            sql = "select * from tb01_clientes, tb02_servicos where tb01_cod = tb02_cod_cliente order by tb02_data_cadastro desc";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();

            DGservicos.ClearSelection();
        }

        private void CBcliente_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboCliente dados = (ComboCliente)CBcliente.SelectedItem;            
        }

        private void BTadd_Click(object sender, EventArgs e)
        {            
            if (CBcliente.Text != "" && TXTservicos.Text != "" && CBsituacao.Text != "" && TXTvalor.Text != "")
            {
                ComboCliente dados = (ComboCliente)CBcliente.SelectedItem;
                string cod = "";
                try { cod = DGservicos.CurrentRow.Cells[7].Value.ToString(); } catch { }
                
                

                if (BTadd.ButtonText == "Adicionar serviço")
                {                    
                    sql = "INSERT INTO `bd_servicos`.`tb02_servicos` (`tb02_cod_cliente`, `tb02_valor`, `tb02_servicos`, `tb02_situacao`, `tb02_obs`)"
                        + "VALUES ('" + dados.cod + "','" + TXTvalor.Text + "', '" + TXTservicos.Text + "', '" + CBsituacao.Text + "', '" + TXTobs.Text + "');";
                    model.open();
                    model.Execsql(sql);
                    model.close();

                    MessageBox.Show("Item adicionado com sucesso");
                }
                else
                {
                    sql = "UPDATE tb02_servicos SET tb02_cod_cliente =" + dados.cod + ", tb02_valor='" + TXTvalor.Text + "', tb02_servicos ='" + TXTservicos.Text + "',"
                        + "tb02_situacao = '" + CBsituacao.Text + "', tb02_obs ='" + TXTobs.Text + "' WHERE tb02_cod=" + cod;
                    model.open();
                    model.Runsql(sql);
                    model.close();

                    MessageBox.Show("Item atualizado com sucesso");

                    BTadd.ButtonText = "Adicionar serviço";
                    BTcancela.Visible = false;
                }

                sql = "select * from tb01_clientes, tb02_servicos where tb01_cod = tb02_cod_cliente order by tb02_data_cadastro desc";
                model.open();
                model.Execsql(sql);
                carregaGrid();
                model.close();

                CBcliente.SelectedIndex = -1;
                CBsituacao.SelectedIndex = -1;
                TXTservicos.Text = "";          
                TXTobs.Text = "";                
                TXTvalor.Text = "";
                BTdel.Visible = false;
                label6.Visible = false;
            }
            else
            {
                MessageBox.Show("Preencha os campos necessários");
            }
        }

        private void BTaddCliente_Click(object sender, EventArgs e)
        {
            Add_clientes add = new Add_clientes();
            add.Show();

            this.Hide();
        }

        private void TXTservicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void TXTobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void TXTvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void DGservicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CBcliente.SelectedIndex = CBcliente.FindString(DGservicos.CurrentRow.Cells[0].Value.ToString());
            CBsituacao.SelectedIndex = CBsituacao.FindString(DGservicos.CurrentRow.Cells[2].Value.ToString());
            TXTservicos.Text = DGservicos.CurrentRow.Cells[1].Value.ToString();
            TXTobs.Text = DGservicos.CurrentRow.Cells[6].Value.ToString(); ;
            TXTvalor.Text = DGservicos.CurrentRow.Cells[5].Value.ToString(); ;

            sql = "select * from tb03_movimentacoes where tb03_cod_servico = " + DGservicos.CurrentRow.Cells[7].Value.ToString();
            model.open();
            model.Execsql(sql);
            if (model.resultado.HasRows)
            {
                TXTvalor.Enabled = false;
                BTdel.Visible = false;
                label6.Visible = false;
            }
            else
            {
                BTdel.Visible = true;
                label6.Visible = true;
            }
            model.close();
            
            BTadd.ButtonText = "Salvar edição";
            BTcancela.Visible = true;

            DGservicos.ClearSelection();
        }

        private void BTcancela_Click(object sender, EventArgs e)
        {
            CBcliente.SelectedIndex = -1;
            CBsituacao.SelectedIndex = -1;
            TXTservicos.Text = "";
            TXTobs.Text = "";
            TXTvalor.Text = "";
            TXTvalor.Enabled = true;
            BTdel.Visible = false;
            label6.Visible = false;

            BTadd.ButtonText = "Adicionar serviço";
            BTcancela.Visible = false;
        }

        private void BTdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja apagar este item?"), "Apagar item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM tb02_servicos WHERE tb02_cod = " + DGservicos.CurrentRow.Cells[7].Value.ToString();
                model.open();
                model.Runsql(sql);
                model.close();

                MessageBox.Show("Item removido com sucesso");
            }            

            CBcliente.SelectedIndex = -1;
            CBsituacao.SelectedIndex = -1;
            TXTservicos.Text = "";
            TXTobs.Text = "";
            TXTvalor.Text = "";
            TXTvalor.Enabled = true;
            BTdel.Visible = false;
            label6.Visible = false;
            BTcancela.Visible = false;

            sql = "select * from tb01_clientes, tb02_servicos where tb01_cod = tb02_cod_cliente order by tb02_data_cadastro desc";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();
        }
    }
}
