﻿using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.Extensions.DependencyInjection;


namespace everis.SimpleProject.API.Config
{
    public static class ServicesConfig
    {
        public static void Configure(this IServiceCollection services)
        {
            services.AddTransient<IGenericService<Anexo>, AnexoAppSvcGeneric>();
            services.AddTransient<IGenericService<SolicitacaoMudanca>, SolicitacaoMudancaAppSvcGeneric>();
            services.AddTransient<ISolicitacaoMudancaService, SolicitacaoMudancaAppSvcGeneric>();
            services.AddTransient<IGenericService<Colaborador>, ColaboradorAppSvcGeneric>();
            services.AddTransient<IColaboradorService, ColaboradorAppSvcGeneric>();
            services.AddTransient<IGenericService<Empresa>, EmpresaAppSvcGeneric>();
            services.AddTransient<IGenericService<EsforcoProjeto>, EsforcoProjetoAppSvcGeneric>();
            services.AddTransient<IGenericService<Pessoa>, PessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<Projeto>, ProjetoAppSvcGeneric>();
            services.AddTransient<IProjetoService, ProjetoAppSvcGeneric>();
            services.AddTransient<IGenericService<ProjetoPessoa>, ProjetoPessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<Telefone>, TelefoneAppSvcGeneric>();
            services.AddTransient<IGenericService<Usuario>, UsuarioAppSvcGeneric>();
            services.AddTransient<IGenericService<AcessoFerramenta>, AcessoFerramentaAppSvcGeneric>();
            services.AddTransient<IGenericService<Ferramenta>, FerramentaAppSvcGeneric>();
            
        }
    }
}
