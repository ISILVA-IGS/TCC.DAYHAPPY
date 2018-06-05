using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Tcc.DayHappy.DAL.Data_base
{
    public class Conexao
    {

        public string GetConexao()
        {
            return "Data Source=LAB3-PC17;Database=DAYHAPPY;User ID=sa;Password=1234567;";
            // return "Data Source=LAB3-PC16;Database=DB_DAYHAPPY;User ID=sa;Password=1234567;";
            // return "Server=(local);Database=DB_DAYHAPPY;User ID=sa;Password=1234567;";

        }

        //String de conexão
        SqlConnection conexao = new SqlConnection("Data Source=LAB3-PC17;Database=DAYHAPPY;User ID=sa;Password=1234567;");
        //SqlConnection con = new SqlConnection("User ID=sa;Initial Catalog=master;Data Source=(local);");
        //Método de conexão com bd
        public SqlConnection ConectarBD()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                
            }
            return conexao;
        }
        public SqlConnection DesconectarBD()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception e)
            {
               
            }
            return conexao;
        }
        public void ChecarConexao()
        {
            if (conexao != null && conexao.State != System.Data.ConnectionState.Closed)
            {
              
            }
            else
            {
               
            }
        }


    }
}
