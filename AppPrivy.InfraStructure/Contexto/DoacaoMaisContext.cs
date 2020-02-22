using System;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Data.EntityConfig.DoacaoMais;
using AppPrivy.Data.Repositories.DoacaoMais;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppPrivy.InfraStructure;
using AppPrivy.InfraStructure.EntityConfig.DoacaoMais;

namespace AppPrivy.Data.Contexto
{


    public partial class DoacaoMaisContext : AppPrivyContext
    {
        public DoacaoMaisContext(DbContextOptions<AppPrivyContext> options):base(options)           
        {
          
            //Database.SetInitializer(new DoacaoMaisDBInitializer());
            //this.Configuration.LazyLoadingEnabled = true;
            //this.Configuration.ProxyCreationEnabled = false;
        }

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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("dbo");


            //modelBuilder.()
            //    .Configure(et => et.SetTableName(et.DisplayName()));


            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties()
            //   .Where(p => p.Name == p.ReflectedType.Name + "Id" )
            //   .Configure(p => p.IsKey());

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
       

            //modelBuilder.Entity<NotificacaoDispositivo>()
            //  .HasKey(p => new { p.NotificacaoId, p.DispositivoId });

        }

        public override int SaveChanges()
        {
            try
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
            catch (Exception e)
            {
                //foreach (var eve in e.EntityValidationErrors)
                //{
                //    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //    foreach (var ve in eve.ValidationErrors)
                //    {
                //        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                //            ve.PropertyName, ve.ErrorMessage);
                //    }
                //}
                //throw;
            }
            return 0;
        }

    }
}

