﻿using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class PessoaMap : BaseMapping<Pessoa>
    {
        public override void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.EmpresaId).IsRequired();
            builder.HasMany(c => c.ProjetosPessoas).WithOne(x => x.Pessoa);

        }
    }
}
