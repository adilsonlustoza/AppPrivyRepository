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
            var roles = new List<string>() { "Administrador", "Convidado" };


            roles.ForEach((x) =>
            {

                var grupRole = new IdentityRole
                {
                    Name = x,
                    NormalizedName = x.ToUpper(),
                    Id = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                };
                context.Roles.AddAsync(grupRole);

            });



        }
    }
}
