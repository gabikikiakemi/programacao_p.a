
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace progamacaoapp.objeto
{
    public class conexao
    {
        //variaveis de conexao
        static private string servidor = "localhost";
        static private string banco = "gerenciamento";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conexaoProjeto = null;

        static private string conexaobd = "server=" + servidor + ";database=" 
            + banco + ";user id=" + usuario + ";password=" + senha;
  
        //metodo de conexao com o banco de dados

        public MySqlConnection getConexao()
        {
            conexaoProjeto = new MySqlConnection(conexaobd);
            return conexaoProjeto;
        }


        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            conexaoProjeto.Open();
            MySqlCommand cmd=new MySqlCommand(sql, conexaoProjeto);
            MySqlDataAdapter adapter= new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            conexaoProjeto.Close();
            return dt;
        }

        public int cadastrar(string[] campos, object[] valores, string sql)
        {
            int registro;
            try
            {
                conexaoProjeto.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexaoProjeto);
                    //montar as infos passadas
                    for (int i=0;i<valores.Length;i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();   
                conexaoProjeto.Close() ;
                return registro;

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }











    }
}
