using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tcc.DayHappy.DAL.Dominio.Funcionarios;
using Dapper;

namespace Tcc.DayHappy.DAL.Data_base.Repositorio
{
    public class FuncionarioRepositorio : IRepositorio<Funcionario>
    {

        public const String TableName = "TB_FUNCIONARIO";
        private const String COMANDO_BASE = " SELECT * from " + TableName;
        protected readonly string ConnectionString;

        public FuncionarioRepositorio()
        {
            Conexao conexao = new Conexao();
            ConnectionString = conexao.GetConexao();
        }

        protected virtual IDbConnection Connection => new SqlConnection(ConnectionString);
        // private const String CONDICIONAL_WHERE = "WHERE";
        // private const String COLUNA_ID = "id";

        //Instancia de conexao com banco de dados
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();


        public void Create(Funcionario funcionario)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"INSERT INTO {TableName} VALUES(@Tipo_Prod,@Tamanho_Prod, @Faixa_Etaria_Prod," +
                    $"@Valor_Locacao_Prod,@Valor_Custo_Prod,@Descricao_Prod,@Quantidade_Prod)",
                    funcionario);
            }
        }


        public void Create (Funcionario funcionario)
        {

            comando.CommandText = "INSERT INTO " + TableName +
                " values(' " + funcionario.Cod_Func + "','" + funcionario.Nome_Func + "','" + funcionario.Cpf_Func + "');";


            //Desconectar para garantir e depois Conectar Novamente
            comando.Connection = conexao.DesconectarBD();
            comando.Connection = conexao.ConectarBD();

            //Controle de Exceção
            try
            {
                comando.ExecuteNonQuery();
                //return true;
            }
            catch (Exception e)
            {

                //Desconectar pela ultima vez
                conexao.DesconectarBD();
               // return false;
            }




        }
        public void Delete(Funcionario funcionario)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<Funcionario> GetAll()
        {


            using (var connection = Connection)
            {
                var r = connection.Query<Funcionario>($" select ID_PROD as [Cod_Prod] FROM {TableName}");
                connection.Close();
                return r;

            }
        }

        public Funcionario GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<Funcionario>($"SELECT * FROM {TableName} WHERE Id_Prod=@Id",
                    new { Id = id });
            }
        }

        public void Update(Funcionario produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday, Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber, Education=@Education WHERE Id=@Id",
                    produto);
            }
        }





        public bool AutenticarUsuario(Funcionario funcionario)
        {
            bool resultado = false;
            String sql = "SELECT * FROM " + TableName + " WHERE usuario = '" + funcionario.Email_Func + "'AND " + " senha ='" + funcionario.Senha_Func + "';";

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
