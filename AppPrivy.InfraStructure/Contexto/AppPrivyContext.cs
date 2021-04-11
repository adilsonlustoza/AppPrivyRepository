using AppPrivy.CrossCutting.Commom;
using AppPrivy.Domain;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.InfraStructure.EntityConfig.DoacaoMais;
using AppPrivy.InfraStructure.EntityConfig.Identity;
using AppPrivy.InfraStructure.EntityConfig.Site;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AppPrivy.InfraStructure.Contexto
{

    public class AppPrivyContext : IdentityDbContext
    {
        private readonly IConfiguration _configuration;

        public AppPrivyContext(DbContextOptions<AppPrivyContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString(ConstantHelper.AppPrivyContext), builder => builder.EnableRetryOnFailure());
            }
        }

        //-------------------------------Doacao Mais-----------------------
        public virtual DbSet<Bazar> Bazar { get; set; }
        public virtual DbSet<Caccc> Caccc { get; set; }
        public virtual DbSet<Campanha> Campanha { get; set; }
        public virtual DbSet<ContaBancaria> ContaBancaria { get; set; }
        public virtual DbSet<Conteudo> Conteudo { get; set; }
        public virtual DbSet<Noticia> Evento { get; set; }
        public virtual DbSet<Notificacao> Notificacao { get; set; }    
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Dispositivo> Dispositivo { get; set; }

        //-------------------------------Site-----------------------
        public virtual DbSet<Pesquisa> Pesquisa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //---------------------------Identity-----------------------

            modelBuilder.ApplyConfiguration(new IdentityRoleClaimConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityUserClaimConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityUserConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityUserLoginConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityUserTokenConfiguration());

            //-------------------------------Doacao Mais-----------------------
            modelBuilder.ApplyConfiguration(new BazarConfiguration());
            modelBuilder.ApplyConfiguration(new CacccConfiguration());
            modelBuilder.ApplyConfiguration(new CampanhaConfiguration());
            modelBuilder.ApplyConfiguration(new ContaBancariaConfiguration());
            modelBuilder.ApplyConfiguration(new ConteudoConfiguration());
            modelBuilder.ApplyConfiguration(new DispositivoConfiguration());           
            modelBuilder.ApplyConfiguration(new NoticiaConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacaoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacaoDispositivoConfiguration());

            //-------------------------------Site-----------------------
            modelBuilder.ApplyConfiguration(new PesquisaConfiguration());

            modelBuilder.HasDefaultSchema("dbo");
        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = true;
                }
            }
            return base.SaveChanges();
        }
    }
}
//Generate Migration

//1) dotnet ef --startup-project  ../AppPrivy/AppPrivy.WebAppMvc/AppPrivy.WebAppMvc.csproj migrations add IniciandoMigrations --context AppPrivyContext

//Generate DataBase

//2) dotnet ef --startup-project  ../AppPrivy/AppPrivy.WebAppMvc/AppPrivy.WebAppMvc.csproj database update -c AppPrivyContext --Verbose
