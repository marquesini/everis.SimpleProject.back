﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using everis.SimpleProject.Data.EF;

namespace everis.SimpleProject.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Anexo", b =>
                {
                    b.Property<int>("IdAnexo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("Id");

                    b.Property<int>("IdProjeto");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<int>("Tipo");

                    b.HasKey("IdAnexo");

                    b.HasIndex("IdProjeto");

                    b.ToTable("Anexos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Change", b =>
                {
                    b.Property<int>("IdChange")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataHoraCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<short>("HorasImpacto");

                    b.Property<int>("Id");

                    b.HasKey("IdChange");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Colaborador", b =>
                {
                    b.Property<int>("IdColaborador")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<bool>("Disponivel");

                    b.Property<string>("EmailCorp")
                        .IsRequired();

                    b.Property<int>("Funcao");

                    b.Property<int>("Funcional");

                    b.Property<int>("Id");

                    b.Property<int>("IdPessoa");

                    b.Property<string>("NomeMaquina");

                    b.Property<int>("Perfil");

                    b.Property<string>("Racf");

                    b.HasKey("IdColaborador");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Colaboradors");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Empresa", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("Id");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<short>("Segmento");

                    b.HasKey("IdEmpresa");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.EsforcoProjeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime>("DataRegistro");

                    b.Property<int>("IdProjetoPessoa");

                    b.Property<int>("ProjetoPessoaIdProjetoPessoa");

                    b.Property<short>("QtdHorasDia");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoPessoaIdProjetoPessoa");

                    b.ToTable("EsforcoProjetos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<long>("CPF");

                    b.Property<string>("Documento");

                    b.Property<string>("Email");

                    b.Property<string>("FotoPath");

                    b.Property<int>("IdEmpresa");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Tipo");

                    b.HasKey("IdPessoa");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Projeto", b =>
                {
                    b.Property<int>("IdProjeto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("BeneficioEntregue");

                    b.Property<string>("BeneficioResidual");

                    b.Property<string>("CentroCusto")
                        .IsRequired();

                    b.Property<DateTime>("DataEntrega");

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime>("DataPrevista");

                    b.Property<string>("EscopoProjeto")
                        .IsRequired();

                    b.Property<string>("ForaEscopoProjeto");

                    b.Property<int>("Id");

                    b.Property<int>("IdEmpresa");

                    b.Property<string>("LicoesAprendidas");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Premissas");

                    b.Property<string>("ProblemasExecucao");

                    b.Property<int>("QtdHorasServico1");

                    b.Property<int>("QtdHorasServico2");

                    b.Property<int>("QtdHorasServico3");

                    b.Property<string>("Riscos");

                    b.Property<short>("Status");

                    b.HasKey("IdProjeto");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoPessoa", b =>
                {
                    b.Property<int>("IdProjetoPessoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("Id");

                    b.Property<int>("IdPessoa");

                    b.Property<int>("IdProjeto");

                    b.HasKey("IdProjetoPessoa");

                    b.HasIndex("IdPessoa");

                    b.HasIndex("IdProjeto");

                    b.ToTable("ProjetoPessoas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoPessoaAtribuicao", b =>
                {
                    b.Property<int>("IdProjetoPessoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("Atribuicao");

                    b.Property<int>("Id");

                    b.HasKey("IdProjetoPessoa");

                    b.ToTable("ProjetoPessoaAtribuicoes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Telefone", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("Id");

                    b.Property<int>("IdPessoa");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired();

                    b.Property<short>("Tipo");

                    b.HasKey("IdTelefone");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdUsuario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime?>("DataDesativacao");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("NomeUsuario")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<bool>("SenhaTemporaria");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Anexo", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("IdProjeto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Colaborador", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.EsforcoProjeto", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.ProjetoPessoa", "ProjetoPessoa")
                        .WithMany()
                        .HasForeignKey("ProjetoPessoaIdProjetoPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Pessoa", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Projeto", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoPessoa", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("IdProjeto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Telefone", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
