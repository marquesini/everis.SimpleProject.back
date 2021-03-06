﻿using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class AnexoMap : BaseMapping<Anexo>
    {
        public override void Configure(EntityTypeBuilder<Anexo> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.Path).IsRequired();
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.ProjetoId).IsRequired();
            builder.Property(c => c.DataInativacao);
            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey(f => f.ProjetoId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
