using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL.Data_base.Repositorio;
using Tcc.DayHappy.DAL.Dominio;

namespace Tcc.DayHappy.DAL.Data_base.Armazenar
{
    public class EnderecoArmazenar
    {


        private readonly  EnderecoRepositorio _funcionarioRepository;

        public EnderecoArmazenar(EnderecoRepositorio enderecoRepository)
        {
            _funcionarioRepository = enderecoRepository;
        }

        public void Armazenar(Endereco endereco)
        {
            var produto = _funcionarioRepository.GetById(endereco.Cod_End);

            if (produto == null)
            {
                produto = new Endereco( endereco);
                _funcionarioRepository.Create(produto);
            }
            else
            {
                produto.Update( endereco);
            }
        }




    }
}
