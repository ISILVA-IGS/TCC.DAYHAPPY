using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Tcc.DayHappy.DAL.Dominio.Funcionarios;

namespace Tcc.DayHappy.DAL.Data_base.Repositorio
{
    class RepositorioFuncionario
    {

        public const String NOME_TABELA = "TB_FUNCIONARIO";
        private const String COMANDO_BASE = " SELECT * from " + NOME_TABELA;
        // private const String CONDICIONAL_WHERE = "WHERE";
        // private const String COLUNA_ID = "id";

        //Instancia de conexao com banco de dados
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();
        public bool incluir(Funcionario funcionario)
        {

            comando.CommandText = "INSERT INTO " + NOME_TABELA +
                " values(' " + funcionario.Cod_Func + "','" + funcionario.Nome_Func + "','" + funcionario.Cpf_Func + "');";


            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexao.DesconectarBD();
            comando.Connection = conexao.ConectarBD();

            //Controle de Exceção
            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                //Desconectar pela ultima vez
                conexao.DesconectarBD();
                return false;
            }




        }
        public bool autenticarUsuario(Funcionario funcionario )
        {
            bool resultado = false;
            String sql = "SELECT * FROM " + NOME_TABELA + " WHERE usuario = '" + funcionario.Email_Func + "'AND " + " senha ='" + funcionario.Senha_Func + "';";

            SqlCommand cmd = new SqlCommand(sql, conexao.ConectarBD());

            if (funcionario.validarUsuario())
            {
                try
                {
                    SqlDataReader dados = cmd.ExecuteReader();
                    resultado = dados.HasRows;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
            conexao.DesconectarBD();
            return resultado;
        }
    }
}
