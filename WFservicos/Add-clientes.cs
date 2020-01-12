using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFservicos
{
    public partial class Add_clientes : Form
    {
        public Add_clientes()
        {
            InitializeComponent();
        }

        Model model = new Model();

        string sql;

        public void carregaGrid()
        {
            DGclientes.Rows.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    DGclientes.Rows.Add(
                                      model.resultado["tb01_nome"].ToString(),
                                      model.resultado["tb01_email"].ToString(),
                                      model.resultado["tb01_telefone"].ToString(),
                                      model.resultado["tb01_cod"].ToString()
                                       );
                }
            }
        }

        //carrega o grid ao abrir o form
        private void Add_clientes_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `bd_servicos`.`tb01_clientes` order by tb01_nome;";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();

            DGclientes.ClearSelection();
        }

        //adicina novo cliente
        private void BTadd_Click(object sender, EventArgs e)
        {
            if(TXTnome.Text != "" && TXTtelefone.Text != "")
            {
                if (BTadd.ButtonText == "Adicionar cliente")
                {
                    sql = "INSERT INTO `bd_servicos`.`tb01_clientes` (`tb01_nome`, `tb01_email`, `tb01_telefone`) VALUES ('" + TXTnome.Text + "', '" + TXTemail.Text + "', '" + TXTtelefone.Text + "');";
                    model.open();
                    model.Runsql(sql);
                    model.close();

                    MessageBox.Show("Item adicionado com sucesso");
                }
                else
                {
                    sql = "update tb01_clientes set tb01_nome = '" +TXTnome.Text+ "', tb01_telefone = '" +TXTtelefone.Text+ "', tb01_email = '" +TXTemail.Text+ "'"
                        + "where tb01_cod = " +DGclientes.CurrentRow.Cells[3].Value.ToString();
                    model.open();
                    model.Runsql(sql);
                    model.close();

                    MessageBox.Show("Item atualizado com sucesso");

                    BTcancela.Visible = false;
                }

                TXTnome.Text = "";
                TXTemail.Text = "";
                TXTtelefone.Text = "";

                TXTnome.Focus();

                sql = "SELECT * FROM `bd_servicos`.`tb01_clientes` order by tb01_nome;";
                model.open();
                model.Execsql(sql);
                carregaGrid();
                model.close();
            }
            else
            {
                MessageBox.Show("Preencha os campos necessários");
            }

            DGclientes.ClearSelection();
        }

        private void DGclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTnome.Text = DGclientes.CurrentRow.Cells[0].Value.ToString();
            TXTemail.Text = DGclientes.CurrentRow.Cells[1].Value.ToString();
            TXTtelefone.Text = DGclientes.CurrentRow.Cells[2].Value.ToString();

            BTadd.ButtonText = "Salvar edição";
            BTcancela.Visible = true;

            DGclientes.ClearSelection();
        }

        private void BTcancela_Click(object sender, EventArgs e)
        {
            TXTnome.Text = "";
            TXTemail.Text = "";
            TXTtelefone.Text = "";

            BTadd.ButtonText = "Adicionar cliente";
            BTcancela.Visible = false;
        }

        private void TXTtelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;               
            }

            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void TXTnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void TXTemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void BTdel_Click(object sender, EventArgs e)
        {
            if(TXTnome.Text == "")
            {
                MessageBox.Show("Selecione um item");
            }
            else
            {
                int codCliente = Convert.ToInt32(DGclientes.CurrentRow.Cells[3].Value);
                string nomeCliente = DGclientes.CurrentRow.Cells[0].Value.ToString();
                gerar_historico ger = new gerar_historico(codCliente, nomeCliente);
                ger.ShowDialog();
            }
            
            //if(TXTnome.Text == "")
            //{
            //    MessageBox.Show("Selecione um item");
            //}
            //else
            //{ 
            //    SaveFileDialog fileDialog = new SaveFileDialog();
            //    fileDialog.Filter = "Arquivo PDF|*.pdf";
            //    fileDialog.FilterIndex = 0;
            //    fileDialog.RestoreDirectory = true;
            //    fileDialog.FileName = TXTnome.Text + " - Histórico do cliente";

            //    if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        if (fileDialog.FileName != "")
            //        {
            //            gerarHistorico(fileDialog.FileName, "Histórico do cliente");
            //        }
            //    }
            //}
        }

        private void gerarHistorico(string caminhoArquivo, string header)
        {
            try
            {
                //dados cliente
                string codCliente = "";
                try { codCliente = DGclientes.CurrentRow.Cells[3].Value.ToString(); } catch { }

                string cliente = TXTnome.Text;
                string telefone = TXTtelefone.Text;
                string email = TXTemail.Text;

                Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
                FileStream fs = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                var fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                var fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                //doc title
                doc.Add(new Paragraph(" "));
                Paragraph ptitle = new Paragraph(header, fontTitle);
                ptitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(ptitle);

                Paragraph pnome = new Paragraph("Nome", fontHeader);
                Paragraph pemail = new Paragraph("E-mail", fontHeader);
                Paragraph ptelefone = new Paragraph("Telefone", fontHeader);

                Paragraph psituacao = new Paragraph("Situação", fontHeader);
                Paragraph pdataCadastro = new Paragraph("Data cadastro", fontHeader);
                Paragraph pservicos = new Paragraph("Serviços", fontHeader);
                Paragraph pobs = new Paragraph("OBS", fontHeader);
                Paragraph pvalor = new Paragraph("Valor", fontHeader);
                Paragraph pvalorPago = new Paragraph("Valor pago", fontHeader);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));

                //table cliente
                PdfPTable tableCliente = new PdfPTable(2);
                PdfPCell cellCliente = new PdfPCell(new Phrase("Cliente", fontTitle));
                cellCliente.Colspan = 2;
                cellCliente.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                cellCliente.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellCliente.FixedHeight = 30f;
                tableCliente.AddCell(cellCliente);
                tableCliente.AddCell(pnome);
                tableCliente.AddCell(cliente);
                tableCliente.AddCell(pemail);
                tableCliente.AddCell(email);
                tableCliente.AddCell(ptelefone);
                tableCliente.AddCell(telefone);
                doc.Add(tableCliente);

                doc.Add(new Paragraph(" "));

                //table servicos
                PdfPTable tableServicos = new PdfPTable(5);
                PdfPCell cellServicos = new PdfPCell(new Phrase("Serviços", fontTitle));
                cellServicos.Colspan = 5;
                cellServicos.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                cellServicos.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellServicos.FixedHeight = 30f;
                tableServicos.AddCell(cellServicos);

                tableServicos.AddCell(new PdfPCell(new Phrase("Serviços", fontHeader)));
                tableServicos.AddCell(new PdfPCell(new Phrase("Situação", fontHeader)));
                tableServicos.AddCell(new PdfPCell(new Phrase("Valor", fontHeader)));
                tableServicos.AddCell(new PdfPCell(new Phrase("Valor pago", fontHeader)));
                tableServicos.AddCell(new PdfPCell(new Phrase("Data cadastro", fontHeader)));

                sql = "SELECT tb02_servicos, tb02_valor, tb02_valor_pago, tb02_situacao, tb02_data_cadastro FROM tb02_servicos "
                    + "WHERE tb02_cod_cliente = " + codCliente;
                model.open();
                model.Execsql(sql);
                if (model.resultado.HasRows)
                {
                    while (model.resultado.Read())
                    {
                        tableServicos.AddCell(new PdfPCell(new Phrase(model.resultado["tb02_servicos"].ToString())));
                        tableServicos.AddCell(new PdfPCell(new Phrase(model.resultado["tb02_situacao"].ToString())));
                        tableServicos.AddCell(new PdfPCell(new Phrase(Convert.ToDecimal(model.resultado["tb02_valor"]).ToString("C"))));
                        tableServicos.AddCell(new PdfPCell(new Phrase(Convert.ToDecimal(model.resultado["tb02_valor_pago"]).ToString("C"))));
                        tableServicos.AddCell(new PdfPCell(new Phrase(model.resultado["tb02_data_cadastro"].ToString())));
                    }
                }
                model.close();

                doc.Add(tableServicos);

                doc.Add(new Paragraph(" "));

                //linha de assinatura
                Paragraph line = new Paragraph();
                line.Add("\n");
                //line.Add("Description:");
                //line.Add("\n");
                LineSeparator lineSeparator = new LineSeparator();
                lineSeparator.Offset = -2;
                line.Add(lineSeparator);
                line.Add("\n");
                //line.Add("put the signature line below ");
                //line.Add("\n");
                //add the signature line here 
                doc.Add(line);

                doc.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

    }
}
