﻿using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using Microsoft.Extensions.DependencyInjection;


namespace everis.SimpleProject.API.Config
{
    public static class ServicesConfig
    {
        public static void Configure(this IServiceCollection services)
        {
            services.AddTransient<IGenericService<Anexo>, AnexoAppSvcGeneric>();
            services.AddTransient<IGenericService<Change>, ChangeAppSvcGeneric>();
            services.AddTransient<IGenericService<Colaborador>, ColaboradorAppSvcGeneric>();
            services.AddTransient<IGenericService<Empresa>, EmpresaAppSvcGeneric>();
            services.AddTransient<IGenericService<EsforcoProjeto>, EsforcoProjetoAppSvcGeneric>();
            services.AddTransient<IGenericService<Pessoa>, PessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<Projeto>, ProjetoAppSvcGeneric>();
            services.AddTransient<IGenericService<ProjetoPessoa>, ProjetoPessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<Telefone>, TelefoneAppSvcGeneric>();
            services.AddTransient<IGenericService<Usuario>, UsuarioAppSvcGeneric>();
        }
    }
}
