using AppPrivy.InfraStructure.Contexto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace AppPrivy.InfraStructure.Repositories.Identity
{
    public static class IdentityDBInitialize
    {
        public static void Seed(AppPrivyContext context)
        {
            var roles = new List<string>() { "Administrador", "Blog", "Sistemas" };


            roles.ForEach((x) =>
            {

                var grupRole = new IdentityRole();
                grupRole.Name = x;
                grupRole.NormalizedName = x.ToUpper();
                grupRole.Id = Guid.NewGuid().ToString();
                grupRole.ConcurrencyStamp = Guid.NewGuid().ToString();
                context.Roles.AddAsync(grupRole);

            });



        }
    }
}
