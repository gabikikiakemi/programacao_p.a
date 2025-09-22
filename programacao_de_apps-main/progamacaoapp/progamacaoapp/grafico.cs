using MySql.Data.MySqlClient;
using progamacaoapp.objeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progamacaoapp
{
    public partial class grafico : Form
    {
        public grafico()
        {
            InitializeComponent();
        }
        private void GerarRelatorio()
        {
            DataTable dtMovimentacao = new DataTable();
            conexao com = new conexao();
            try
            {

                com.getConexao();
                string query = "Select data_lancamento, valor, tipo from financeiro";

                mysqldataAdapter adapter = new MySqlDataAdapter(query, com);
                adapter.fill(dtMovimentacao);

                ProcessarDadosGraficos(dtMovimentacao);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar re");
            }
        }
        private void ProcessarDadosGraficos(DataTable dados)
        {
            foreach (var series in fluxocaixa.Series)
            {
                series.Points.Clear();
            }
            var grupos = dados.AsEnumerable().GroupBy(row =>
            {


                DateTime data = row.Field<DateTime>("data_lancamento");
            }).OrderBy(global => global.Key);

            fluxocaixa.ChartAreas["MainArea"].AxisX.LabelStyle.Formar = "dd/mm"
        decimal entradas = grupos.Where(ref=> ref.Field<string>("Tipo") == "Entrada").Sum(r => r.fiel<deciaml>("valor"));
            fluxocaixa.Series["Entradas"].Points.AddXY(Label, entrada);
        }

        private void grafico_Load(object sender, EventArgs e)
        {

        }
    }
}
