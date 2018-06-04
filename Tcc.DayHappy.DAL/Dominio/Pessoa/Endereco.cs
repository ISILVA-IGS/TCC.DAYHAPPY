using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    public class Endereco
    {
        public Endereco(Endereco endereco)
        {
            ValidacaoValoresSetPropriedades(endereco.Cod_End, endereco.Cep, endereco.Logradouro, endereco.Numero_Logradouro,
            endereco.Complemento, endereco.Bairro, endereco.Cidade, endereco.Ponto_Referencia);
        }

        public int Cod_End { get;  set; }
        public string Cep { get;  set; }
        public string Logradouro { get;  set; }
        public string Numero_Logradouro { get;  set; }
        public string Complemento { get;  set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Ponto_Referencia { get;  set; }


        public Endereco()
        {

        }

        //Lembrar de rever todos os tratamentos--> data compra
        //(ATENÇÃO) com check list de pecas é obrigatorio ???
        private void ValidacaoValoresSetPropriedades(int cod_End, string cep, string logradouro, string numero_Logradouro,
            string complemento, string bairro, string cidade, string ponto_Referencia)
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

            Cod_End = cod_End;
            Cep = cep;
            Logradouro = logradouro;
            Numero_Logradouro = numero_Logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Ponto_Referencia = ponto_Referencia;
        }

        public void Update(Endereco endereco)
        {
            ValidacaoValoresSetPropriedades(endereco.Cod_End, endereco.Cep, endereco.Logradouro, endereco.Numero_Logradouro,
               endereco.Complemento, endereco.Bairro, endereco.Cidade, endereco.Ponto_Referencia);
        }


    }
}

