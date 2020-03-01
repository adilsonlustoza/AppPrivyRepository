﻿using AppPrivy.InfraStructure.Contexto;
using AppPrivy.Domain;
using System.Collections.Generic;

namespace AppPrivy.InfraStructure.Repositories.Site
{
    public class SiteDBInitializer 
    {

        public static void Seed(SiteContext context)
        {

            var lstPesquisa = new List<Pesquisa>()
            {
                    new Pesquisa() { Titulo = "Android", Descricao = "O Android é um software para celulares, tablets e uma gama crescente de dispositivos abrangendo tudo, desde computação portátil até entretenimento para carros. Foi lançado em 2003 e é o sistema operacional móvel (SO) mais popular do mundo.", Url = "/Analista/Programador/Android", PesquisaId = 1 },

                    new Pesquisa() { Titulo = "Engenharia de Software", Descricao = "Engenharia de Software é uma área da computação voltada à especificação, relações humanas, metodologias, liderança, boas práticas, mantenabilidade, gestão de projetos e arquitetura.", Url = "/Analista/Programador/EngenhariaDeSoftware", PesquisaId = 2 },

                    new Pesquisa() { Titulo = "Sistema Web", Descricao = "Também conhecido como aplicação web, um sistema web provê funcionalidades para a manutenção do negócio da empresa, e deve ser considerado na automatização de processos.", Url = "/Analista/Programador/SistemasWeb", PesquisaId = 3 }
            };

            lstPesquisa.ForEach(p =>
               context.Pesquisa.Add(p)
            );

            context.SaveChanges();
                      
        }

    }
}
