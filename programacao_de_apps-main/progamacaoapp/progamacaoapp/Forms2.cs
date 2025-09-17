using MySql.Data.MySqlClient;
using progamacaoapp.objeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string caminhodestino=Path.Combine(pastadestino, endereco);
           
            using (StreamWriter writer = new StreamWriter(caminhodestino, false, Encoding.GetEncoding("iso-8859-15")))
            {
                conexao com = new conexao();
                MySqlConnection conexao = com.getConexao();
                writer.WriteLine("Relatório Financeiro");
                writer.WriteLine("Data; Valor; Tipo");
                string entrada = @"select data_lancamento, valor, tipo from financeiro";
                MySqlCommand cmd = new MySqlCommand(entrada,conexao);
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
    }
}
