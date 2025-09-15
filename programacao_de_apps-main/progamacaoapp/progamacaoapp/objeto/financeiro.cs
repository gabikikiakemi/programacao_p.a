using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progamacaoapp.objeto
{
    public class financeiro
    {
        public int id;
        public string name;
        public decimal valor;
        public string descricao;
        public string tipo;
        public string servico;
        public DateTime data_lancamento;
        public Boolean pgto;


        public bool cadastrar(conexao conexao)
        {
            bool resultado = false;
            string sql = "insert into financeiro(descricao,valor,tipo,servico,data_lacamento,pgto)" +
                " values(@descricao, @valor, @tipo, @servico, @data, @pgto)";
            string[] campos = { "@descricao", "@valor", "@tipo", "@servico", "@data", "@pgto" };
            object[] valores = { descricao, valor, tipo, servico, data_lancamento, pgto };
            if (conexao.cadastrar(campos, valores, sql) >= 1)
            {
                resultado = true;
            }
            return resultado;
        }


        public bool editar(conexao conexao)
        {
            bool resultado = false;
            string sql = "Update financeiro set descricao= @descricao,valor=@valor,tipo=@tipo, servico=@servico,data_lancamento=@data,pgto=@pgto);"+
                "where codigo_lancamento=@codigo";
            string[] campos = { "@descricao", "@valor", "@tipo", "@servico", "@data", "@pgto", "@codigo" };
            object[] valores = { descricao, valor, tipo, servico, data_lancamento, pgto, id };
            if (conexao.cadastrar(campos, valores, sql) >= 1)
            {
                resultado = true;
            }
            return resultado;
        }
    }

}
