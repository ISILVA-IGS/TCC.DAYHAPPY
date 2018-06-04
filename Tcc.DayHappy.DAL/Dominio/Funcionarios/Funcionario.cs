using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio.Funcionarios
{
    public class Funcionario
    {
        public int Cod_Func { get; private set; }
        public string Nome_Func { get; private set; }
        public DateTime DataNasc_Func { get; private set; }
        public string Sexo_Func { get; private set; }
        public string Cpf_Func { get; private set; }
        public int Tel1_Func { get; private set; }
        public int Tel2_Func { get; private set; }
        public string Email_Func { get; private set; }
        public string Senha_Func { get; private set; }
        public string NomeCargo_Func { get; private set; }
        public decimal Salario_Func { get; private set; }
        public DateTime DataAdm_Func { get; private set; }
        public Endereco Endereco { get; private set; }

        bool validado;
   public Funcionario(int cod_Func, string nome_Func, DateTime dataNasc_Func, string sexo_Func, string cpf_Func, int tel1_Func, 
            int tel2_Func, string email_Func, string senha_Func, string nomeCargo_Func,decimal salario_Func, DateTime dataAdm_Func, 
            Endereco endereco)
        {
            ValidacaoValoresSetPropriedades(cod_Func,nome_Func, dataNasc_Func,sexo_Func, cpf_Func,tel1_Func,
             tel2_Func,  email_Func,senha_Func,nomeCargo_Func,salario_Func,dataAdm_Func,endereco);
        }



        public Boolean validarUsuario()
        {
            if (Email_Func != "" && Senha_Func != "")
            {
                if (Email_Func != null && Senha_Func != null)
                {
                    this.validado = true;
                }
            }

            return validado;
        }


       



        //Lembrar de rever todos os tratamentos--> data compra
        //(ATENÇÃO) com check list de pecas é obrigatorio ???
        private void ValidacaoValoresSetPropriedades(int cod_Func, string nome_Func, DateTime dataNasc_Func, string sexo_Func, string cpf_Func, int tel1_Func,
            int tel2_Func, string email_Func, string senha_Func, string nomeCargo_Func, decimal salario_Func, DateTime dataAdm_Func,
            Endereco endereco)
        {
            /*
            DomainException.Quando(string.IsNullOrEmpty(), "Nome do Produto é obrigatorio");
           DomainException.Quando(nomeProduto.Length < 1, "Nome do produto Invalido");
            DomainException.Quando(string.IsNullOrEmpty(faixaEtaria), "Faixa Etaria é obrigatoria");
            DomainException.Quando(faixaEtaria.Length < 1, "Faixa Etaria Invalida");
            DomainException.Quando(valorLocacao < 0, "Valor Locação Invalido");
            DomainException.Quando(valorCusto < 0, "Valor Locação Invalido");
            DomainException.Quando(checkListPecas.Length < 0, "Check List das Peças Invalido");
             DomainException.Quando(string.IsNullOrEmpty(checkListPecas),"Check List das Pecas é Obrigatorio")
            */

            Cod_Func = cod_Func;
            Nome_Func = nome_Func;
            DataNasc_Func = dataNasc_Func;
            Sexo_Func = sexo_Func;
            Cpf_Func = cpf_Func;
            Tel1_Func = tel1_Func;
            Tel2_Func = tel2_Func;
            Email_Func = email_Func;
            Senha_Func = senha_Func;
            NomeCargo_Func = nomeCargo_Func;
            Salario_Func = salario_Func;
            DataAdm_Func = dataAdm_Func;
            Endereco = endereco;
        }

        public void Update(int cod_Func, string nome_Func, DateTime dataNasc_Func, string sexo_Func, string cpf_Func, int tel1_Func,
            int tel2_Func, string email_Func, string senha_Func, string nomeCargo_Func, decimal salario_Func, DateTime dataAdm_Func,
            Endereco endereco)
        {
            ValidacaoValoresSetPropriedades(cod_Func, nome_Func, dataNasc_Func, sexo_Func, cpf_Func, tel1_Func,
             tel2_Func, email_Func, senha_Func, nomeCargo_Func, salario_Func, dataAdm_Func, endereco);
        }
    }








}
