using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL.Data_base.Armazenar;
using Tcc.DayHappy.DAL.Data_base.Repositorio;
using Tcc.DayHappy.DAL.Dominio;
using Tcc.DayHappy.DAL.Dominio.Funcionarios;
using Tcc.DayHappy.DAL.Repositorio.Armazenar;

namespace Tcc.DayHappy.DAL
{
    public class Bootsrap
    {


        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddScoped(typeof(ProdutoArmazenar));
            services.AddScoped(typeof(IRepositorio<Produto>), typeof(ProdutoRepositorio));
            services.AddScoped(typeof(Produto));
            services.AddScoped(typeof(ProdutoRepositorio));
            //
            services.AddScoped(typeof(FuncionarioArmazenar));
            services.AddScoped(typeof(IRepositorio<Funcionario>), typeof(FuncionarioRepositorio));
            services.AddScoped(typeof(Funcionario));
            services.AddScoped(typeof(FuncionarioRepositorio));
            //
            services.AddScoped(typeof(EnderecoArmazenar));
            services.AddScoped(typeof(IRepositorio<Endereco>), typeof(EnderecoRepositorio));
            services.AddScoped(typeof(Endereco));
            services.AddScoped(typeof(EnderecoRepositorio));
        }

     }
}
