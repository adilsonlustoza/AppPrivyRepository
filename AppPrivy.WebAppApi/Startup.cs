using AppPrivy.Application;
using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.CrossCutting.Fault;
using AppPrivy.CrossCutting.Operations;
using AppPrivy.Domain;
using AppPrivy.Domain.Interfaces;
using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AppPrivy.Domain.Services;
using AppPrivy.Domain.Services.DoacaoMais;
using AppPrivy.InfraStructure.Contexto;
using AppPrivy.InfraStructure.Interface;
using AppPrivy.InfraStructure.Repositories;
using AppPrivy.InfraStructure.Repositories.DoacaoMais;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;
using System.Security.Claims;

namespace AppPrivy.WebAppApi
{
    public class Startup
    {
      
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(Configuration);

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

            });

            services.Configure<CookieTempDataProviderOptions>(options =>
            {
                options.Cookie.IsEssential = true;
            });

            services.AddDbContext<AppPrivyContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString(ConstantHelper.ConnectionString),
             b => b.MigrationsAssembly(ConstantHelper.AppPrivy_WebAppMvc))
            );

            services.AddTransient<IContextManager, ContextManager>();

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddTransient(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));

            services.AddTransient<IBazarRepository, BazarRepository>();
            services.AddTransient<IBazarService, BazarService>();

            services.AddTransient<IBoletimRepository, BoletimRepository>();
            services.AddTransient<IBoletimService, BoletimService>();

            services.AddTransient<ICacccRepository, CacccRepository>();
            services.AddTransient<ICacccService, CacccService>();

            services.AddTransient<IContaBancariaRepository, ContaBancariaRepository>();
            services.AddTransient<IContaBancariaService, ContaBancariaService>();

            services.AddTransient<IConteudoRepository, ConteudoRepository>();
            services.AddTransient<IConteudoService, ConteudoService>();

            services.AddTransient<IDispositivoRepository, DispositivoRepository>();
            services.AddTransient<IDispositoService, DispositivoService>();

            services.AddTransient<INoticiaRepository, NoticiaRepository>();
            services.AddTransient<INoticiaService, NoticiaService>();

            services.AddTransient<INotificacaoRepository, NotificacaoRepository>();
            services.AddTransient<INotificacaoService, NotificacaoService>();

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            services.AddTransient<IPesquisaRepository, PesquisaRepository>();
            services.AddTransient<IPesquisaService, PesquisaService>();
            services.AddTransient<IPesquisaRepository, PesquisaRepository>();

            services.AddTransient<IContatoService, ContatoService>();
            services.AddTransient<IPesquisaService, PesquisaService>();

            services.AddTransient<IContatoAppService, ContatoAppService>();
            services.AddTransient<IPesquisaAppService, PesquisaAppService>();

            services.AddScoped<FaultException>();
            services.AddScoped<SendMail>();                     

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Api Doação Mais",
                    Description = "API Doação Mais - API Analyzers",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact() { Name = "Adilson Lustoza", Email = "adilsonlustoza@gmail.com" }
                });
            });


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var supportedCultures = new[] { new CultureInfo("pt-BR") };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mac API V1");
            });
        }
    }
}
