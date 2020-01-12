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
    public partial class gerar_historico : Form
    {
        public int codCliente;
        public string nomeCliente;

        Model model = new Model();

        public gerar_historico(int cod, string nome)
        {
            InitializeComponent();

            codCliente = cod;
            nomeCliente = nome;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            if(checkBox1.Checked == true)
            {
                date1.Enabled = false;
                date2.Enabled = false;
            }
            else
            {
                date1.Enabled = true;
                date2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Arquivo PDF|*.pdf";
            fileDialog.FilterIndex = 0;
            fileDialog.RestoreDirectory = true;
            fileDialog.FileName = nomeCliente + " - Histórico do cliente";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    gerarHistorico(fileDialog.FileName, "Histórico do cliente", codCliente);
                }

                this.Hide();
            }            
        }

        private void gerarHistorico(string caminhoArquivo, string header, int codCliente)
        {
            try
            {
                string cliente = "";
                string telefone = "";
                string email = "";

                string data1 = Convert.ToDateTime(date1.Value.ToString()).ToString("yyyy-MM-dd"); 
                string data2 = Convert.ToDateTime(date2.Value.ToString()).ToString("yyyy-MM-dd");

                string sql = "SELECT * FROM tb01_clientes WHERE tb01_cod = " + codCliente;
                model.open();
                model.Execsql(sql);
                if (model.resultado.HasRows)
                {
                    while (model.resultado.Read())
                    {
                        cliente = model.resultado["tb01_nome"].ToString();
                        telefone = model.resultado["tb01_telefone"].ToString();
                        email = model.resultado["tb01_email"].ToString();
                    }
                }
                model.close();
                
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

                if(checkBox1.Checked == true)
                {                    
                    sql = "SELECT tb02_servicos, tb02_valor, tb02_valor_pago, tb02_situacao, tb02_data_cadastro FROM tb02_servicos "
                    + "WHERE tb02_cod_cliente = " + codCliente;
                }
                else
                {
                    sql = "SELECT tb02_servicos, tb02_valor, tb02_valor_pago, tb02_situacao, tb02_data_cadastro FROM tb02_servicos "
                    + "WHERE tb02_cod_cliente = " +codCliente+ " AND "
                    + "tb02_data_cadastro BETWEEN '" +data1+ "' AND '" +data2+ "';";                    
                }                
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void gerar_historico_Load(object sender, EventArgs e)
        {            
        }
    }
}
