using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayHappy.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Tcc.DayHappy.DAL.Data_base.Armazenar;
using Tcc.DayHappy.DAL.Data_base.Repositorio;

namespace DayHappy.Web.Controllers
{
    public class FuncionarioController : Controller
    {


        private readonly FuncionarioRepositorio _produtoRepository;
        private readonly FuncionarioArmazenar _produtoArmazenar;
        private readonly EnderecoRepositorio _enderecoRepository;
        private readonly EnderecoArmazenar _enderecoArmazenar;

        public FuncionarioController(FuncionarioArmazenar produtoArmazenar, FuncionarioRepositorio produtoRepository,EnderecoArmazenar enderecoArmazenar,EnderecoRepositorio enderecoRepositorio)
        {
            _produtoRepository = produtoRepository;
            _produtoArmazenar = produtoArmazenar;
            _enderecoArmazenar = enderecoArmazenar;
            _enderecoRepository = enderecoRepositorio;

        }

        public IActionResult CadastrarFuncionario(int id)
        {
            var viewModel = new FuncionarioViewModel();


            if (id > 0)
            { /*
                var p = _produtoRepository.GetById(id);
                viewModel.Cod_Prod = p.Cod_Prod;
                viewModel.Tipo_Prod = p.Tipo_Prod;
                viewModel.Tamanho_Prod = p.Tamanho_Prod;
                viewModel.Faixa_Etaria_Prod = p.Faixa_Etaria_Prod;
                viewModel.Valor_Locacao_Prod = p.Valor_Locacao_Prod;
                viewModel.Valor_Custo_Prod = p.Valor_Custo_Prod;
                viewModel.Descricao_Pro = p.Descricao_Prod;
                viewModel.Quantidae_Prod = p.Quantidade_Prod;
                return View(viewModel);

                */
            }

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult CadastrarFuncionario(FuncionarioViewModel model)
        {
           _enderecoArmazenar.Armazenar(model.endereco);
            return RedirectToAction("SelecionarProduto");
        }



    }
}