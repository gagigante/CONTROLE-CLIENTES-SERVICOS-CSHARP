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
    public partial class Receita : Form
    {
        public Receita()
        {
            InitializeComponent();
        }

        public void carregaComboBox()
        {
            ComboCliente item = null;
            CBano.Items.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    item = new ComboCliente();
                    item.cli = model.resultado["year(tb03_data_pagamento)"].ToString();                    
                    CBano.Items.Add(item);
                }
            }
        }

        public void stats()
        {
            grafico.Series.Clear();
            grafico.ResetAutoValues();
            grafico.Series.Add("Series1");

            grafico.Series["Series1"].LabelBackColor = Color.FromArgb(0, 203, 253);
            grafico.Series["Series1"].LabelForeColor = Color.White;

            if (CBitem.Text == "Serviços realizados")
            {
                sql = "SELECT "
                        + "(select count(tb02_cod) FROM tb02_servicos where month(tb02_data_cadastro) = 1 and year(tb02_data_cadastro) = " + CBano.Text + ") as janeiro, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 2 and year(tb02_data_cadastro) = " + CBano.Text + ") as fevereiro, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 3 and year(tb02_data_cadastro) = " + CBano.Text + ")as marco, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 4 and year(tb02_data_cadastro) = " + CBano.Text + ")as abril, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 5 and year(tb02_data_cadastro) = " + CBano.Text + ")as maio, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 6 and year(tb02_data_cadastro) = " + CBano.Text + ")as junho, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 7 and year(tb02_data_cadastro) = " + CBano.Text + ")as julho, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 8 and year(tb02_data_cadastro) = " + CBano.Text + ")as agosto, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 9 and year(tb02_data_cadastro) = " + CBano.Text + ")as setembro, "
                        + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 10 and year(tb02_data_cadastro) = " + CBano.Text + ")as outubro, "
  	                    + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 11 and year(tb02_data_cadastro) = " + CBano.Text + ")as novembro, "
	                    + "(select count(tb02_cod) from tb02_servicos where month(tb02_data_cadastro) = 12 and year(tb02_data_cadastro) = " + CBano.Text + ")as dezembro";

                model.open();
                model.Execsql(sql);

                while (model.resultado.Read())
                {
                    grafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    //label13.Visible = true;

                    if (model.resultado["janeiro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["janeiro"]));
                        grafico.Series["Series1"].Points[0].Label = model.resultado["janeiro"].ToString();
                    }

                    if (model.resultado["fevereiro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["fevereiro"]));
                        grafico.Series["Series1"].Points[1].Label = model.resultado["fevereiro"].ToString();
                    }

                    if (model.resultado["marco"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["marco"]));
                        grafico.Series["Series1"].Points[2].Label = model.resultado["marco"].ToString();
                    }

                    if (model.resultado["abril"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["abril"]));
                        grafico.Series["Series1"].Points[3].Label = model.resultado["abril"].ToString();
                    }

                    if (model.resultado["maio"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["maio"]));
                        grafico.Series["Series1"].Points[4].Label = model.resultado["maio"].ToString();
                    }

                    if (model.resultado["junho"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["junho"]));
                        grafico.Series["Series1"].Points[5].Label = model.resultado["junho"].ToString();
                    }

                    if (model.resultado["julho"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["julho"]));
                        grafico.Series["Series1"].Points[6].Label = model.resultado["julho"].ToString();
                    }

                    if (model.resultado["agosto"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["agosto"]));
                        grafico.Series["Series1"].Points[7].Label = model.resultado["agosto"].ToString();
                    }

                    if (model.resultado["setembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["setembro"]));
                        grafico.Series["Series1"].Points[8].Label = model.resultado["setembro"].ToString();
                    }

                    if (model.resultado["outubro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["outubro"]));
                        grafico.Series["Series1"].Points[9].Label = model.resultado["outubro"].ToString();
                    }

                    if (model.resultado["novembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["novembro"]));
                        grafico.Series["Series1"].Points[10].Label = model.resultado["novembro"].ToString();
                    }

                    if (model.resultado["dezembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["dezembro"]));
                        grafico.Series["Series1"].Points[11].Label = model.resultado["dezembro"].ToString();

                    }
                    
                    grafico.Series["Series1"].Points[0].AxisLabel = "Janeiro";
                    grafico.Series["Series1"].Points[1].AxisLabel = "Fevereiro";
                    grafico.Series["Series1"].Points[2].AxisLabel = "Março";
                    grafico.Series["Series1"].Points[3].AxisLabel = "Abril";
                    grafico.Series["Series1"].Points[4].AxisLabel = "Maio";
                    grafico.Series["Series1"].Points[5].AxisLabel = "Junho";
                    grafico.Series["Series1"].Points[6].AxisLabel = "Julho";
                    grafico.Series["Series1"].Points[7].AxisLabel = "Agosto";
                    grafico.Series["Series1"].Points[8].AxisLabel = "Setembro";
                    grafico.Series["Series1"].Points[9].AxisLabel = "Outubro";
                    grafico.Series["Series1"].Points[10].AxisLabel = "Novembro";
                    grafico.Series["Series1"].Points[11].AxisLabel = "Dezembro";
                }
                model.close();
            }

            if(CBitem.Text == "Valor dos serviços")
            {
                sql = "SELECT "
                      + "(select sum(tb02_valor) FROM tb02_servicos where month(tb02_data_cadastro) = 1 and year(tb02_data_cadastro) = " + CBano.Text + ") as janeiro, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 2 and year(tb02_data_cadastro) = " + CBano.Text + ") as fevereiro, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 3 and year(tb02_data_cadastro) = " + CBano.Text + ")as marco, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 4 and year(tb02_data_cadastro) = " + CBano.Text + ")as abril, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 5 and year(tb02_data_cadastro) = " + CBano.Text + ")as maio, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 6 and year(tb02_data_cadastro) = " + CBano.Text + ")as junho, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 7 and year(tb02_data_cadastro) = " + CBano.Text + ")as julho, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 8 and year(tb02_data_cadastro) = " + CBano.Text + ")as agosto, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 9 and year(tb02_data_cadastro) = " + CBano.Text + ")as setembro, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 10 and year(tb02_data_cadastro) = " + CBano.Text + ")as outubro, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 11 and year(tb02_data_cadastro) = " + CBano.Text + ")as novembro, "
                      + "(select sum(tb02_valor) from tb02_servicos where month(tb02_data_cadastro) = 12 and year(tb02_data_cadastro) = " + CBano.Text + ")as dezembro";

                model.open();
                model.Execsql(sql);

                while (model.resultado.Read())
                {
                    grafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    //label13.Visible = true;

                    if (model.resultado["janeiro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["janeiro"]));
                        grafico.Series["Series1"].Points[0].Label = Convert.ToDouble(model.resultado["janeiro"]).ToString("C");
                    }

                    if (model.resultado["fevereiro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["fevereiro"]));
                        grafico.Series["Series1"].Points[1].Label = Convert.ToDouble(model.resultado["fevereiro"]).ToString("C");
                    }

                    if (model.resultado["marco"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["marco"]));
                        grafico.Series["Series1"].Points[2].Label = Convert.ToDouble(model.resultado["marco"]).ToString("C");
                    }

                    if (model.resultado["abril"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["abril"]));
                        grafico.Series["Series1"].Points[3].Label = Convert.ToDouble(model.resultado["abril"]).ToString("C");
                    }

                    if (model.resultado["maio"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["maio"]));
                        grafico.Series["Series1"].Points[4].Label = Convert.ToDouble(model.resultado["maio"]).ToString("C");
                    }

                    if (model.resultado["junho"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["junho"]));
                        grafico.Series["Series1"].Points[5].Label = Convert.ToDouble(model.resultado["junho"]).ToString("C");
                    }

                    if (model.resultado["julho"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["julho"]));
                        grafico.Series["Series1"].Points[6].Label = Convert.ToDouble(model.resultado["julho"]).ToString("C");
                    }

                    if (model.resultado["agosto"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["agosto"]));
                        grafico.Series["Series1"].Points[7].Label = Convert.ToDouble(model.resultado["agosto"]).ToString("C");
                    }

                    if (model.resultado["setembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["setembro"]));
                        grafico.Series["Series1"].Points[8].Label = Convert.ToDouble(model.resultado["setembro"]).ToString("C");
                    }

                    if (model.resultado["outubro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["outubro"]));
                        grafico.Series["Series1"].Points[9].Label = Convert.ToDouble(model.resultado["outubro"]).ToString("C");
                    }

                    if (model.resultado["novembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["novembro"]));
                        grafico.Series["Series1"].Points[10].Label = Convert.ToDouble(model.resultado["novembro"]).ToString("C");
                    }

                    if (model.resultado["dezembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["dezembro"]));
                        grafico.Series["Series1"].Points[11].Label = Convert.ToDouble(model.resultado["dezembro"]).ToString("C");

                    }

                    grafico.Series["Series1"].Points[0].AxisLabel = "Janeiro";
                    grafico.Series["Series1"].Points[1].AxisLabel = "Fevereiro";
                    grafico.Series["Series1"].Points[2].AxisLabel = "Março";
                    grafico.Series["Series1"].Points[3].AxisLabel = "Abril";
                    grafico.Series["Series1"].Points[4].AxisLabel = "Maio";
                    grafico.Series["Series1"].Points[5].AxisLabel = "Junho";
                    grafico.Series["Series1"].Points[6].AxisLabel = "Julho";
                    grafico.Series["Series1"].Points[7].AxisLabel = "Agosto";
                    grafico.Series["Series1"].Points[8].AxisLabel = "Setembro";
                    grafico.Series["Series1"].Points[9].AxisLabel = "Outubro";
                    grafico.Series["Series1"].Points[10].AxisLabel = "Novembro";
                    grafico.Series["Series1"].Points[11].AxisLabel = "Dezembro";
                }
                model.close();
            }

            if(CBitem.Text == "Valor recebido")
            {                
                sql = "SELECT "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 1 and year(tb03_data_pagamento) = " + CBano.Text + ") as janeiro, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 2 and year(tb03_data_pagamento) = " + CBano.Text + ") as fevereiro, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 3 and year(tb03_data_pagamento) = " + CBano.Text + ")as marco, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 4 and year(tb03_data_pagamento) = " + CBano.Text + ")as abril, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 5 and year(tb03_data_pagamento) = " + CBano.Text + ")as maio, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 6 and year(tb03_data_pagamento) = " + CBano.Text + ")as junho, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 7 and year(tb03_data_pagamento) = " + CBano.Text + ")as julho, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 8 and year(tb03_data_pagamento) = " + CBano.Text + ")as agosto, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 9 and year(tb03_data_pagamento) = " + CBano.Text + ")as setembro, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 10 and year(tb03_data_pagamento) = " + CBano.Text + ")as outubro, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 11 and year(tb03_data_pagamento) = " + CBano.Text + ")as novembro, "
                      + "(select sum(tb03_valor) FROM tb03_movimentacoes where month(tb03_data_pagamento) = 12 and year(tb03_data_pagamento) = " + CBano.Text + ")as dezembro";

                model.open();
                model.Execsql(sql);

                while (model.resultado.Read())
                {
                    grafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;                    

                    if (model.resultado["janeiro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["janeiro"]));
                        grafico.Series["Series1"].Points[0].Label = Convert.ToDouble(model.resultado["janeiro"]).ToString("C");
                    }

                    if (model.resultado["fevereiro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["fevereiro"]));
                        grafico.Series["Series1"].Points[1].Label = Convert.ToDouble(model.resultado["fevereiro"]).ToString("C");
                    }

                    if (model.resultado["marco"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["marco"]));
                        grafico.Series["Series1"].Points[2].Label = Convert.ToDouble(model.resultado["marco"]).ToString("C");
                    }

                    if (model.resultado["abril"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["abril"]));
                        grafico.Series["Series1"].Points[3].Label = Convert.ToDouble(model.resultado["abril"]).ToString("C");
                    }

                    if (model.resultado["maio"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["maio"]));
                        grafico.Series["Series1"].Points[4].Label = Convert.ToDouble(model.resultado["maio"]).ToString("C");
                    }

                    if (model.resultado["junho"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["junho"]));
                        grafico.Series["Series1"].Points[5].Label = Convert.ToDouble(model.resultado["junho"]).ToString("C");
                    }

                    if (model.resultado["julho"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["julho"]));
                        grafico.Series["Series1"].Points[6].Label = Convert.ToDouble(model.resultado["julho"]).ToString("C");
                    }

                    if (model.resultado["agosto"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["agosto"]));
                        grafico.Series["Series1"].Points[7].Label = Convert.ToDouble(model.resultado["agosto"]).ToString("C");
                    }

                    if (model.resultado["setembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["setembro"]));
                        grafico.Series["Series1"].Points[8].Label = Convert.ToDouble(model.resultado["setembro"]).ToString("C");
                    }

                    if (model.resultado["outubro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["outubro"]));
                        grafico.Series["Series1"].Points[9].Label = Convert.ToDouble(model.resultado["outubro"]).ToString("C");
                    }

                    if (model.resultado["novembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["novembro"]));
                        grafico.Series["Series1"].Points[10].Label = Convert.ToDouble(model.resultado["novembro"]).ToString("C");
                    }

                    if (model.resultado["dezembro"] == DBNull.Value)
                    {
                        grafico.Series["Series1"].Points.AddY(0);
                    }
                    else
                    {
                        grafico.Series["Series1"].Points.AddY(Convert.ToDouble(model.resultado["dezembro"]));
                        grafico.Series["Series1"].Points[11].Label = Convert.ToDouble(model.resultado["dezembro"]).ToString("C");

                    }

                    grafico.Series["Series1"].Points[0].AxisLabel = "Janeiro";
                    grafico.Series["Series1"].Points[1].AxisLabel = "Fevereiro";
                    grafico.Series["Series1"].Points[2].AxisLabel = "Março";
                    grafico.Series["Series1"].Points[3].AxisLabel = "Abril";
                    grafico.Series["Series1"].Points[4].AxisLabel = "Maio";
                    grafico.Series["Series1"].Points[5].AxisLabel = "Junho";
                    grafico.Series["Series1"].Points[6].AxisLabel = "Julho";
                    grafico.Series["Series1"].Points[7].AxisLabel = "Agosto";
                    grafico.Series["Series1"].Points[8].AxisLabel = "Setembro";
                    grafico.Series["Series1"].Points[9].AxisLabel = "Outubro";
                    grafico.Series["Series1"].Points[10].AxisLabel = "Novembro";
                    grafico.Series["Series1"].Points[11].AxisLabel = "Dezembro";
                }
                model.close();
            }
        }

        Model model = new Model();
        string sql = "";

        private void Receita_Load(object sender, EventArgs e)
        {
            sql = "select year(tb03_data_pagamento) from tb03_movimentacoes group by year(tb03_data_pagamento) order by year(tb03_data_pagamento) desc";
            model.open();
            model.Execsql(sql);
            carregaComboBox();
            model.close();

            try { CBano.SelectedIndex = 0; } catch { }                        
            CBitem.SelectedIndex = 0;

            sql = "SELECT"
                    + " (SELECT sum(tb03_valor) FROM tb03_movimentacoes WHERE MONTH(tb03_data_pagamento) = MONTH(NOW())) AS valorPago,"
                    + " (SELECT sum(tb02_valor) FROM tb02_servicos WHERE MONTH(tb02_data_cadastro) = MONTH(NOW())) AS valorServicos,"
                    + " (SELECT count(tb02_valor) FROM tb02_servicos WHERE MONTH(tb02_data_cadastro) = MONTH(NOW())) AS QtdServicos";
            model.open();
            model.Execsql(sql);

            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    if (model.resultado["QtdServicos"] == DBNull.Value) { TXTservicos.Text += " 0"; }
                    else { TXTservicos.Text += " " + model.resultado["QtdServicos"].ToString(); }

                    if (model.resultado["valorServicos"] == DBNull.Value) { TXTvalor.Text += " 0"; }
                    else { TXTvalor.Text += " " + Convert.ToDouble(model.resultado["valorServicos"]).ToString("C"); }

                    if(model.resultado["valorPago"] == DBNull.Value) { TXTpago.Text += " 0"; }
                    else { TXTpago.Text += " " + Convert.ToDouble(model.resultado["valorPago"]).ToString("C"); }                                        
                }
            }

            model.close();
        }

        private void CBano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBano.Text != "" && CBitem.Text != "")
            {
                stats();
            }
        }

        private void CBitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBano.Text != "" && CBitem.Text != "")
            {
                stats();
            }
        }
    }
}
