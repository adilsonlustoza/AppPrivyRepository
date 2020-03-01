﻿// <auto-generated />
using System;
using AppPrivy.InfraStructure.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppPrivy.WebAppMvc.Migrations.DoacaoMais
{
    [DbContext(typeof(DoacaoMaisContext))]
    [Migration("20200301214428_IniciandoMigrationsDoacaoMais")]
    partial class IniciandoMigrationsDoacaoMais
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Bazar", b =>
                {
                    b.Property<int>("BazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BazarId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CacccId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Informacao")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("OutrosContatos")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("BazarId");

                    b.HasIndex("CacccId");

                    b.ToTable("Bazar","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Boletim", b =>
                {
                    b.Property<int>("BoletimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BoletimId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<int>("CacccId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFinal")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInicial")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(3500)")
                        .HasMaxLength(3500);

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkWeb")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("tipoCampanha")
                        .HasColumnType("int");

                    b.HasKey("BoletimId");

                    b.HasIndex("CacccId");

                    b.ToTable("Boletim","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Caccc", b =>
                {
                    b.Property<int>("CacccId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CacccId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apelido")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<bool>("Autorizado")
                        .HasColumnType("bit");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFundacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPagSeguro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPayPal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Responsavel")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("TipoDoacao")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("CacccId");

                    b.ToTable("Caccc","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.ContaBancaria", b =>
                {
                    b.Property<int>("ContaBancariaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ContaBancariaId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beneficiario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CacccId")
                        .HasColumnType("int");

                    b.Property<string>("Conta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeBanco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroBanco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContaBancariaId");

                    b.HasIndex("CacccId");

                    b.ToTable("ContaBancaria","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Conteudo", b =>
                {
                    b.Property<int>("ConteudoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ConteudoId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CacccId")
                        .HasColumnType("int");

                    b.Property<string>("Coluna")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitulo")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("ConteudoId");

                    b.HasIndex("CacccId");

                    b.ToTable("Conteudo","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Dispositivo", b =>
                {
                    b.Property<int>("DispositivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DispositivoId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Board")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("FirgirPrint")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Host")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incremental")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Manufacture")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Release")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("VersaoSDK")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("DispositivoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Dispositivo","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Noticia", b =>
                {
                    b.Property<int>("NoticiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NoticiaId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CacccId")
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPublicacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitulo")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("NoticiaId");

                    b.HasIndex("CacccId");

                    b.ToTable("Noticia","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Notificacao", b =>
                {
                    b.Property<int>("NotificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NotificacaoId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<int?>("BoletimId")
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .HasColumnType("nvarchar(3500)")
                        .HasMaxLength(3500);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("NotificacaoId");

                    b.HasIndex("BoletimId");

                    b.ToTable("Notificacao","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.NotificacaoDispositivo", b =>
                {
                    b.Property<int>("NotificacaoId")
                        .HasColumnType("int");

                    b.Property<int>("DispositivoId")
                        .HasColumnType("int");

                    b.HasKey("NotificacaoId", "DispositivoId");

                    b.HasIndex("DispositivoId");

                    b.ToTable("NotificacaoDispositivo","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PacienteId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CacccId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Enfermidade")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<int?>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("PacienteId");

                    b.HasIndex("CacccId");

                    b.ToTable("Paciente","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(350)")
                        .HasMaxLength(350);

                    b.Property<string>("IdentificadorUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario","DoacaoMais");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Bazar", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Caccc", "Caccc")
                        .WithMany("Bazares")
                        .HasForeignKey("CacccId")
                        .IsRequired();

                    b.OwnsOne("AppPrivy.Domain.Entities.ObjectValue.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("BazarId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Bairro")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Cep")
                                .HasColumnType("nvarchar(10)")
                                .HasMaxLength(10);

                            b1.Property<string>("Cidade")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Estado")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<string>("Logradouro")
                                .HasColumnType("nvarchar(150)")
                                .HasMaxLength(150);

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.Property<string>("Numero")
                                .HasColumnType("nvarchar(10)")
                                .HasMaxLength(10);

                            b1.HasKey("BazarId");

                            b1.ToTable("Bazar");

                            b1.WithOwner()
                                .HasForeignKey("BazarId");
                        });
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Boletim", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Caccc", "Caccc")
                        .WithMany("Boletins")
                        .HasForeignKey("CacccId")
                        .IsRequired();
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Caccc", b =>
                {
                    b.OwnsOne("AppPrivy.Domain.Entities.ObjectValue.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("CacccId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Bairro")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Cep")
                                .HasColumnType("nvarchar(10)")
                                .HasMaxLength(10);

                            b1.Property<string>("Cidade")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Estado")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<string>("Logradouro")
                                .HasColumnType("nvarchar(150)")
                                .HasMaxLength(150);

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.Property<string>("Numero")
                                .HasColumnType("nvarchar(10)")
                                .HasMaxLength(10);

                            b1.HasKey("CacccId");

                            b1.ToTable("Caccc");

                            b1.WithOwner()
                                .HasForeignKey("CacccId");
                        });
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.ContaBancaria", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Caccc", "Caccc")
                        .WithMany("ContasBancarias")
                        .HasForeignKey("CacccId")
                        .IsRequired();
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Conteudo", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Caccc", "Caccc")
                        .WithMany("Conteudos")
                        .HasForeignKey("CacccId")
                        .IsRequired();
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Dispositivo", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Usuario", null)
                        .WithMany("Dispositivo")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Noticia", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Caccc", "Caccc")
                        .WithMany("Noticias")
                        .HasForeignKey("CacccId");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Notificacao", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Boletim", null)
                        .WithMany("Notificacoes")
                        .HasForeignKey("BoletimId");
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.NotificacaoDispositivo", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Dispositivo", "Dispositivo")
                        .WithMany("NotificacaoDispositivo")
                        .HasForeignKey("DispositivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Notificacao", "Notificacao")
                        .WithMany("NotificacaoDispositivo")
                        .HasForeignKey("NotificacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppPrivy.Domain.Entities.DoacaoMais.Paciente", b =>
                {
                    b.HasOne("AppPrivy.Domain.Entities.DoacaoMais.Caccc", "Caccc")
                        .WithMany("Pacientes")
                        .HasForeignKey("CacccId");
                });
#pragma warning restore 612, 618
        }
    }
}
