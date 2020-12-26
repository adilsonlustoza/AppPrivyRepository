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
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using Serilog;
using System.IO;
using System.Reflection;
using AppPrivy.Application.Services.Site;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

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

            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });


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


            services.AddIdentity<IdentityUser, IdentityRole>()
                  .AddEntityFrameworkStores<AppPrivyContext>()
                  .AddDefaultTokenProviders();



            services.AddTransient<IAuthService, AuthService>();

            services.AddScoped<FaultException>();
            services.AddScoped<SendMail>();



            services.AddSwaggerGenNewtonsoftSupport();

            services.AddControllers();

            services
            .AddMvcCore()
            .AddDataAnnotations()
            .AddCors()
            .AddJsonOptions(
                options =>
                {
                    options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                });


            services.AddSwaggerGen(opt =>
            {


                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                  Enter 'Bearer' [space] and then your token in the text input below.
                  \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement()
          {
            {
              new OpenApiSecurityScheme
              {
                    Reference = new OpenApiReference
                      {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                      },
                      Scheme = "oauth2",
                      Name = "Bearer",
                      In = ParameterLocation.Header,

                    },
                    new List<string>()
                  }
            });

                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Doação Mais API",
                    Description = "Aplicatio Doação Mais - ASP.NET Core Web API",
                    TermsOfService = new Uri("https://www.adilsonlustoza.com.br/Android"),
                    Contact = new OpenApiContact
                    {
                        Name = "Adilson Lustoza",
                        Email = string.Empty,
                        Url = new Uri("https://www.adilsonlustoza.com.br/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under police",
                        Url = new Uri("https://www.adilsonlustoza.com.br/Politica"),
                    }
                });


                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                opt.IncludeXmlComments(xmlPath);



            });



            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddCookie(cfg => { cfg.SlidingExpiration = true; })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey
                       (Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

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



            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseDeveloperExceptionPage();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                // c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Doação Mais V1");
            });


        }

    }
}
