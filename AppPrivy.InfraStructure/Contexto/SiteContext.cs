using AppPrivy.InfraStructure.EntityConfig.DoacaoMais;
using AppPrivy.InfraStructure.EntityConfig.Site;
using AppPrivy.InfraStructure.Repositories.Site;
using AppPrivy.Domain;
using AppPrivy.Domain.Entities.Identity;
using AppPrivy.InfraStructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AppPrivy.InfraStructure.Contexto
{
    //public class SiteContext : IdentityDbContext<User, Role, int,
    //                                                IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
    //                                                IdentityRoleClaim<int>, IdentityUserToken<int>>

    public class SiteContext: IdentityDbContext
    {
       
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        { 
        
        }

        public virtual DbSet<Pesquisa> Pesquisa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //modelBuilder.ApplyConfiguration(new UserRoleConfiguration());           
            modelBuilder.ApplyConfiguration(new PesquisaConfiguration());
            base.OnModelCreating(modelBuilder);
          
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
