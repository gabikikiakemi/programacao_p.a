using MySql.Data.MySqlClient;
using progamacaoapp.objeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp;
using PageSize = iTextSharp.text.PageSize;
using Font = System.Drawing.Font;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net.Http.Json;
using System.Diagnostics;
using Document = iTextSharp.text.Document;
using MySqlX.XDevAPI.Relational;
using System.Linq.Expressions;

namespace progamacaoapp
{
    public partial class Forms2 : Form
    {
        public Forms2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endereco = "RelatorioExcel.csv";
            string pastadestino = Path.Combine(Application.StartupPath, "Relatorio");
            if (!Directory.Exists(pastadestino))
            {
                Directory.CreateDirectory(pastadestino);

            }
            string caminhodestino = Path.Combine(pastadestino, endereco);

            using (StreamWriter writer = new(caminhodestino, false, Encoding.GetEncoding("iso-8859-15")))
            {
                conexao com = new();
                MySqlConnection conexao = com.getConexao();

                writer.WriteLine("Relatório Financeiro");
                writer.WriteLine("Data; Valor; Tipo");
                string entrada = @"select data_lancamento, valor, tipo from financeiro";
                MySqlCommand cmd = new(entrada, conexao);

                conexao.Open();


                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        writer.WriteLine(Convert.ToString(reader["data_lancamento"]) + ";"
                            + Convert.ToString(reader["valor"] + ";"
                            + Convert.ToString(reader["tipo"]))
                            );
                    }
                }
                conexao.Close();
                MessageBox.Show("Relatorio gerado com sucesso.", "Atenção");
            }
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            string destinoPDF = Path.Combine(Application.StartupPath, "pdf");
            if (!Directory.Exists(destinoPDF)) ;
            {
                Directory.CreateDirectory(destinoPDF);
            }

            string caminhoPDF = Path.Combine(destinoPDF, "realtorioCliente.pdf");

            Document doc = new Document(PageSize.A4);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminhoPDF, FileMode.Create));
                doc.Open();
                Font fonte = new("microsoft sans serif", 9f);
                Paragraph titulo = new("Relatorio cliente");
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph(" "));
                conexao com = new conexao();
                com.getConexao();
                DataTable cliente = new DataTable();

                /*

                cliente = com.obterdados("select * from financeiro");
                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40F, 15F, 20f, 25f, 15f });
                table.AddCell(new Phrase("descricaoo"));
                table.AddCell(new Phrase("valor"));
                table.AddCell(new Phrase("tipo"));
                table.AddCell(new Phrase("data_lancamento"));
                table.AddCell(new Phrase("pgo"));

                for (int i = 0; i < cliente.Rows.Count; i++)
                {
                    table.AddCell(new Phrase( cliente.Rows[i][1].ToString()));
                table.AddCell(new Phrase( cliente.Rows[i][2].ToString()));
                table.AddCell(new Phrase( cliente.Rows[i][3].ToString()));
                table.AddCell(new Phrase( cliente.Rows[i][4].ToString()));
                table.AddCell(new Phrase( cliente.Rows[i][5].ToString()));
                }


            doc.Add(table);
                */
            doc.Close();
            MessageBox.Show("Relatorio foi gerado com sucesso");
            Process.Start(caminhoPDF);
            }
             catch (Exception ex) 
            {
                 MessageBox.Show("Erro ao gerar o PDF", ex.Message);
            }

        }
     }
}

