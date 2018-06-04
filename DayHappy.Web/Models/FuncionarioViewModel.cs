using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tcc.DayHappy.DAL.Dominio;

namespace DayHappy.Web.Models
{
    public class FuncionarioViewModel
    {

        public int Cod_Func { get;  set; }
        public string Nome_Func { get;  set; }
        public DateTime DataNasc_Func { get;  set; }
        public string Sexo_Func { get;  set; }
        public string Cpf_Func { get;  set; }
        public int Tel1_Func { get;  set; }
        public int Tel2_Func { get;  set; }
        public string Email_Func { get;  set; }
        public string Senha_Func { get;  set; }
        public string NomeCargo_Func { get;  set; }
        public decimal Salario_Func { get;  set; }
        public DateTime DataAdm_Func { get;  set; }
        public int Cod_End { get;  set; }
        public string Cep { get;  set; }
        public string Logradouro { get;  set; }
        public string Numero_Logradouro { get;  set; }
        public string Complemento { get;  set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Ponto_Referencia { get;  set; }
        public Endereco endereco { get; set; }

   




    }
}
