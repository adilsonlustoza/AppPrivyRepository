using AppPrivy.InfraStructure.Contexto;
using Microsoft.AspNetCore.Identity;
using NuGet.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrivy.WebAppMvc.Areas.Identity.Repository
{
    public class IdentityDBInitialize
    {

       
        public static void Seed(AppPrivyContext context)
        {
            var roles = new List<string>() { "Administrador", "Blog", "Sistemas" };
     

            roles.ForEach((x) => {

                var grupRole = new IdentityRole();
                grupRole.Name = x;
                grupRole.NormalizedName = x.ToUpper();
                grupRole.Id = Guid.NewGuid().ToString();
                grupRole.ConcurrencyStamp = Guid.NewGuid().ToString();
                context.Roles.Add (grupRole);

            });
                     
           


        }
    }
}
