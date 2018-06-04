using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tcc.DayHappy.DAL.Dominio;
using Dapper;

namespace Tcc.DayHappy.DAL.Data_base.Repositorio
{
    public class EnderecoRepositorio : IRepositorio<Endereco>
    {
        public const String TableName = "TB_ENDERECO";
        private const String COMANDO_BASE = " SELECT * from " + TableName;
        protected readonly string ConnectionString;

        public EnderecoRepositorio()
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
        public void Create(Endereco endereco)
        {

            comando.CommandText = "INSERT INTO " + TableName +
               " values(' " + endereco.Logradouro  + "','" + endereco.Numero_Logradouro + "','" + endereco.Complemento + 
               endereco.Bairro + "','" + endereco.Cidade + "','" + endereco.Ponto_Referencia + "');";


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
        public void Delete(Endereco funcionario)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<Endereco> GetAll()
        {


            using (var connection = Connection)
            {
                var r = connection.Query<Endereco>($" select ID_PROD as [Cod_Prod] FROM {TableName}");
                connection.Close();
                return r;

            }
        }

        public Endereco GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<Endereco>($"SELECT * FROM {TableName} WHERE ID_ENDERECO=@Id",
                    new { Id = id });
            }
        }

        public void Update(Endereco produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday, Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber, Education=@Education WHERE Id=@Id",
                    produto);
            }
        }







    }
}
