using progamacaoapp.objeto;

namespace progamacaoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btncadastrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();

            financeiro fin = new financeiro();
            fin.data_lancamento = data_lancamento.Value;
            fin.descricao = txtdescricao.Text;
            fin.servico = cboservico.Text;
            fin.valor = Convert.ToDecimal(txtvalor.Text);
            fin.tipo = cbotipo.Text;
            fin.pgto = chkpagamento.Checked;
            if (fin.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            conexao com = new conexao();
            com.getConexao();
            financeiro financeiro = new financeiro();
            financeiro.id = Convert.ToInt32(txtcodigo.Text);
            financeiro.descricao = txtdescricao.Text;
            financeiro.servico = cboservico.Text;
            financeiro.tipo = cbotipo.Text;
            financeiro.valor = decimal.Parse(txtvalor.Text);
            financeiro.pgto = chkpagamento.Checked;
            financeiro.data_lancamento = data_lancamento.Value;
            if (financeiro.editar(com) == true)
            {
                MessageBox.Show("Editado com sucesso!");
            }


        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao com = new conexao();
            com.getConexao();
            dataGridView1.DataSource = com.obterdados("select *from financeiro");
            cboservico.Items.Add("salario");
            cboservico.Items.Add("despesas");
            cbotipo.Items.Add("entrada");
            cbotipo.Items.Add("saida");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int codigo = 0;
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtcodigo.Text = codigo.ToString();
            txtdescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtvalor.Text = dataGridView1.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            cboservico.Text = dataGridView1.Rows[e.RowIndex].Cells["servico"].Value.ToString();
            cbotipo.Text = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            data_lancamento.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["data_lancamento"].Value;
            bool pago = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["pgto"].Value.ToString());
            if (pago == true)
            {
                chkpagamento.Checked = true;
            }
            else
            {
                chkpagamento.Checked = false;
            }
        }
    }
}
