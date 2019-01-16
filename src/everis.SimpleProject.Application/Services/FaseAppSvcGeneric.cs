﻿using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class FaseAppSvcGeneric : GenericService<Fase>
    {
        public FaseAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Fase>(context);
        }

        public override IEnumerable<Fase> BuscarPor(Fase filter)
        {
            try
            {
                var nomeToFind = filter?.ProjetoPessoa.Pessoa.Nome;
                var result = repository.BuscarPor(b => b.ProjetoPessoa.Pessoa.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.ProjetoPessoa.Pessoa.Nome : nomeToFind
                    ));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
