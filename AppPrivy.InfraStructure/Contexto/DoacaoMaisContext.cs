using System;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.InfraStructure.EntityConfig.DoacaoMais;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AppPrivy.InfraStructure.Contexto
{

    public partial class DoacaoMaisContext : DbContext
    {
        public DoacaoMaisContext(DbContextOptions<DoacaoMaisContext> options):base(options)           
        {          
           
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
                throw e;
            }
        }

    }
}

