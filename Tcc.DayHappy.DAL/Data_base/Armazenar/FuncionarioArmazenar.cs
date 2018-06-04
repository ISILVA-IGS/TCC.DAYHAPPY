using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL.Data_base.Repositorio;
using Tcc.DayHappy.DAL.Dominio;
using Tcc.DayHappy.DAL.Dominio.Funcionarios;

namespace Tcc.DayHappy.DAL.Data_base.Armazenar
{
   public class FuncionarioArmazenar
    {


        private readonly FuncionarioRepositorio _funcionarioRepository;

        public FuncionarioArmazenar(FuncionarioRepositorio funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void Armazenar(int cod_Func, string nome_Func, DateTime dataNasc_Func, string sexo_Func, string cpf_Func, int tel1_Func,
            int tel2_Func, string email_Func, string senha_Func, string nomeCargo_Func, decimal salario_Func, DateTime dataAdm_Func,
            Endereco endereco)
        {
            var produto = _funcionarioRepository.GetById(cod_Func);

            if (produto == null)
            {
                produto = new Funcionario (cod_Func, nome_Func, dataNasc_Func, sexo_Func, cpf_Func, tel1_Func,
             tel2_Func, email_Func, senha_Func, nomeCargo_Func, salario_Func, dataAdm_Func, endereco);
                _funcionarioRepository.Create(produto);
            }
            else
            {
                produto.Update(cod_Func, nome_Func, dataNasc_Func, sexo_Func, cpf_Func, tel1_Func,
             tel2_Func, email_Func, senha_Func, nomeCargo_Func, salario_Func, dataAdm_Func, endereco);
            }
        }













    }
}
