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
            services.AddTransient<IGenericService<Usuario>, UsuarioAppSvcGeneric>();
            services.AddTransient<IUserService, UsuarioAppSvcGeneric>();
            services.AddTransient<IProjetoService, ProjetoAppSvcGeneric>();
            services.AddTransient<IGenericService<Projeto>, ProjetoAppSvcGeneric>();

            services.AddTransient<IGenericService<Anexo>, AnexoAppSvcGeneric>();
        }
    }
}