using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using iTextSharp.text.pdf.draw;

namespace WFservicos
{
    public partial class Detalhes : Form
    {
        Servicos instancia;

        public Detalhes(Servicos servicos)
        {
            InitializeComponent();

            instancia = servicos;
        }

        Model model = new Model();
        string sql;

        public void carregaInfo()
        {
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    TXTnome.Text = model.resultado["tb01_nome"].ToString();
                    TXTtelefone.Text = model.resultado["tb01_telefone"].ToString();
                    TXTemail.Text = model.resultado["tb01_email"].ToString();

                    TXTsituacao.Text = model.resultado["tb02_situacao"].ToString();
                    TXTstatus.Text = model.resultado["tb02_status"].ToString();
                    TXTvalor.Text = Convert.ToDouble(model.resultado["tb02_valor"]).ToString("C");                    

                    TXTpago.Text = Convert.ToDouble(model.resultado["tb02_valor_pago"]).ToString("C");
                    TXTdata.Text = Convert.ToDateTime(model.resultado["tb02_data_cadastro"]).ToString();
                    try
                    {
                        TXTdataFin.Text = Convert.ToDateTime(model.resultado["tb02_data_finalizacao"]).ToString();
                    }
                    catch (Exception ex)
                    {

                    }
                    

                    TXTservico.Text = model.resultado["tb02_servicos"].ToString();
                    TXTobs.Text = model.resultado["tb02_obs"].ToString();                    
                }
            }
        }

        public void carregaGrid()
        {
            DGmovimento.Rows.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {                 

                    DGmovimento.Rows.Add(
                                      Convert.ToDouble(model.resultado["tb03_valor"]).ToString("C"),
                                      model.resultado["tb03_forma_pagamento"].ToString(),
                                      Convert.ToDateTime(model.resultado["tb03_data_pagamento"])
                                       );
                }
            }
        }   

        private void Detalhes_Load(object sender, EventArgs e)
        {
            int codServico = Convert.ToInt32(instancia.DGservicos.CurrentRow.Cells[8].Value);

            sql = "SELECT * FROM tb01_clientes, tb02_servicos WHERE tb01_cod = tb02_cod_cliente AND tb02_cod = " + codServico;
            model.open();
            model.Execsql(sql);
            carregaInfo();
            model.close();

            sql = "SELECT * FROM tb03_movimentacoes, tb02_servicos WHERE tb02_cod = tb03_cod_servico AND tb02_cod = " + codServico + " order by tb03_data_pagamento desc";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();

            DGmovimento.ClearSelection();
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DGmovimento_MouseClick(object sender, MouseEventArgs e)
        {
            DGmovimento.ClearSelection();
        }

        private void BTgerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Arquivo PDF|*.pdf";
            fileDialog.FilterIndex = 0;
            fileDialog.RestoreDirectory = true;
            fileDialog.FileName = TXTnome.Text + " - relatorio de servico";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    gerarPDF(fileDialog.FileName, "Relatório de serviço");
                }                
            }
        }

        private void gerarPDF(string caminhoArquivo, string header)
        {
            try
            {

                //dados cliente
                string cliente = TXTnome.Text;
                string telefone = TXTtelefone.Text;
                string email = TXTemail.Text;

                //dados servico
                string situacao = TXTsituacao.Text;
                string status = TXTstatus.Text;
                string valor = TXTvalor.Text;
                string valorPago = TXTpago.Text;
                string dataCadastro = TXTdata.Text;
                string dataFinalizacao = TXTdataFin.Text;
                string servico = TXTservico.Text;
                string obs = TXTobs.Text;

                //dados movimentacao

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
                Paragraph pdataCadastro = new Paragraph("Data de cadastro", fontHeader);
                Paragraph pdataFinalizacao = new Paragraph("Data de finalização", fontHeader);
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

                //table servico
                PdfPTable tableServico = new PdfPTable(2);
                PdfPCell cellServico = new PdfPCell(new Phrase("Serviço", fontTitle));
                cellServico.Colspan = 2;
                cellServico.HorizontalAlignment = 1;
                cellServico.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellServico.FixedHeight = 30f;
                tableServico.AddCell(cellServico);
                tableServico.AddCell(psituacao);
                tableServico.AddCell(situacao);
                tableServico.AddCell(pdataCadastro);
                tableServico.AddCell(dataCadastro);
                tableServico.AddCell(pdataFinalizacao);
                tableServico.AddCell(dataFinalizacao);
                tableServico.AddCell(pservicos);
                tableServico.AddCell(servico);
                tableServico.AddCell(pobs);
                tableServico.AddCell(obs);
                tableServico.AddCell(pvalor);
                tableServico.AddCell(valor);
                tableServico.AddCell(pvalorPago);
                tableServico.AddCell(valorPago);
                doc.Add(tableServico);

                doc.Add(new Paragraph(" "));

                if (DGmovimento.Rows.Count > 0)
                {
                    //table movimentacao
                    PdfPTable movimentacoes = new PdfPTable(DGmovimento.Columns.Count);

                    //title
                    PdfPCell cellTitle = new PdfPCell(new Phrase("Movimentações", fontTitle));
                    cellTitle.Colspan = DGmovimento.Columns.Count;
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cellTitle.FixedHeight = 30f;
                    movimentacoes.AddCell(cellTitle);

                    //add header
                    for (int j = 0; j < DGmovimento.Columns.Count; j++)
                    {
                        movimentacoes.AddCell(new PdfPCell(new Phrase(DGmovimento.Columns[j].HeaderText, fontHeader)));
                        //movimentacoes.AddCell(DGmovimento.Columns[j].HeaderText);
                    }

                    //flag row 1 as a header
                    movimentacoes.HeaderRows = 1;

                    for (int i = 0; i < DGmovimento.Rows.Count; i++)
                    {
                        for (int k = 0; k < DGmovimento.Columns.Count; k++)
                        {
                            if (DGmovimento[k, i].Value != null)
                            {
                                movimentacoes.AddCell(new Phrase(DGmovimento[k, i].Value.ToString()));
                            }
                        }
                    }
                    doc.Add(movimentacoes);
                }

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
                MessageBox.Show("Erro:" + ex);
            }
        }
    }
}
