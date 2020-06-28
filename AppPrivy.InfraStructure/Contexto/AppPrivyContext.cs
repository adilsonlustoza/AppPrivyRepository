using AppPrivy.Domain;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.InfraStructure.EntityConfig.DoacaoMais;
using AppPrivy.InfraStructure.EntityConfig.Site;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AppPrivy.InfraStructure.Contexto
{

    public class AppPrivyContext : IdentityDbContext// IdentityDbContext<IdentityUser,IdentityRole,string>
    {
        private readonly IConfiguration _configuration;
        
        public AppPrivyContext(DbContextOptions<AppPrivyContext> options, IConfiguration configuration ) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AppPrivyContext"), builder => builder.EnableRetryOnFailure());
            }
        }

        //-------------------------------Doacao Mais-----------------------
        public virtual DbSet<Bazar> Bazar { get; set; }
        public virtual DbSet<Caccc> Caccc { get; set; }
        public virtual DbSet<Boletim> Campanha { get; set; }
        public virtual DbSet<ContaBancaria> ContaBancaria { get; set; }
        public virtual DbSet<Conteudo> Conteudo { get; set; }
        public virtual DbSet<Noticia> Evento { get; set; }
        public virtual DbSet<Notificacao> Notificacao { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Dispositivo> Dispositivo { get; set; }

        //-------------------------------Site-----------------------
        public virtual DbSet<Pesquisa> Pesquisa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<IdentityUser>(u => {
                u.ToTable("User", "Security");
                u.HasKey("Id").HasName("UserId");
                u.Property("Id").IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IdentityRole>(u => {
                u.ToTable("Role", "Security");
                u.HasKey("Id").HasName("RoleId");
                u.Property("Id").IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(u => {
                u.ToTable("UserClaim", "Security");
                u.HasKey("Id","UserId").HasName("UserClaimPk");
                u.Property("Id").IsRequired().ValueGeneratedOnAdd();
            });


            modelBuilder.Entity<IdentityUserToken<string>>(u => {
                u.ToTable("UserToken", "Security");
                u.HasKey("UserId").HasName("UserTokenPk");
               // u.Property("Id").IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(u => {
                u.ToTable("UserLogin", "Security");
                u.HasKey("UserId").HasName("UserLoginPk");
              //  u.Property("Id").IsRequired().ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(u => {
                u.ToTable("RoleClaim", "Security");
                u.HasKey("Id","RoleId").HasName("RoleClaimPk");
                u.Property("Id").IsRequired().ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<IdentityUserRole<string>>(u => {
                u.ToTable("UserRole", "Security");
                u.HasKey("UserId", "RoleId").HasName("UserRolePk");
             
            });

            modelBuilder.HasDefaultSchema("dbo");
            //-------------------------------Doacao Mais-----------------------
            modelBuilder.ApplyConfiguration(new BazarConfiguration());
            modelBuilder.ApplyConfiguration(new CacccConfiguration());
            modelBuilder.ApplyConfiguration(new BoletimConfiguration());
            modelBuilder.ApplyConfiguration(new ContaBancariaConfiguration());
            modelBuilder.ApplyConfiguration(new ConteudoConfiguration());
            modelBuilder.ApplyConfiguration(new DispositivoConfiguration());
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new NoticiaConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacaoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacaoDispositivoConfiguration());

            //-------------------------------Site-----------------------
            modelBuilder.ApplyConfiguration(new PesquisaConfiguration());

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
                    entry.Property("DataCadastro").IsModified = false;
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
