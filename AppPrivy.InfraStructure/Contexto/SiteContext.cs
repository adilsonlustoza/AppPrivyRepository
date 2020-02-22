using AppPrivy.Data.EntityConfig.Site;
using AppPrivy.Data.Repositories.Site;
using AppPrivy.Domain;
using AppPrivy.InfraStructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AppPrivy.Data.Contexto
{
    public class SiteContext : AppPrivyContext
    {
       
        public SiteContext(DbContextOptions<AppPrivyContext> options) : base(options)
        { 
        //    :base("SiteContext")
        //{
        // //   var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        //    Database.SetInitializer<SiteContext>(new SiteDBInitializer());
        //    this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Pesquisa> Pesquisa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties()
            //    .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //    .Configure(p => p.IsKey());

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasColumnType("varchar"));

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasMaxLength(100));

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
