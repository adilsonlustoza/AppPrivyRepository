using AppPrivy.Application;
using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.CrossCutting.Fault;
using AppPrivy.CrossCutting.Operations;
using AppPrivy.Domain;
using AppPrivy.Domain.Interfaces;
using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.Domain.Interfaces.Services;
using AppPrivy.Domain.Services;
using AppPrivy.InfraStructure.Contexto;
using AppPrivy.InfraStructure.Interface;
using AppPrivy.InfraStructure.Repositories;
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
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace AppPrivy.WebAppSiteBlog
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
                options.ConsentCookie.IsEssential = true;
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
               

            });

            services.Configure<CookieTempDataProviderOptions>(options =>
            {
                options.Cookie.IsEssential = true;
            });

            services.AddDbContext<AppPrivyContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString(ConstantHelper.ConnectionString),
             b => b.MigrationsAssembly(ConstantHelper.AppPrivy_WebAppMvc))
            );

            services.AddDefaultIdentity<IdentityUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AppPrivyContext>()
                    .AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 1;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
            });


            services
                .AddAuthentication(options =>
               {
                   options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                   options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                   options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
               })
               .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
                               options =>
                               {
                                   options.Cookie.IsEssential = true;
                                   options.Cookie.HttpOnly = true;
                                   options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                                   options.Cookie.SameSite = SameSiteMode.Lax;
                                   options.Cookie.Name = "AppPrivyCookie";
                                   options.LoginPath = "/Identity/Account/Login";
                                   options.LogoutPath = "/Identity/Account/Logout";
                               }



               );


          
            services.AddMvc(options => options.EnableEndpointRouting = false)
           .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
           .AddRazorPagesOptions(options =>
           {
               options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
               options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
           });

            services.AddTransient<IContextManager, ContextManager>();

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddTransient(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));



            services.AddTransient<IPesquisaRepository, PesquisaRepository>();
            services.AddTransient<IPesquisaService, PesquisaService>();
            services.AddTransient<IPesquisaRepository, PesquisaRepository>();

            services.AddTransient<IContatoService, ContatoService>();
            services.AddTransient<IPesquisaService, PesquisaService>();

            services.AddTransient<IContatoAppService, ContatoAppService>();
            services.AddTransient<IPesquisaAppService, PesquisaAppService>();

            services.AddScoped<FaultException>();
            services.AddScoped<SendMail>();


            services.AddAuthorization(options =>
            {
                options.AddPolicy(ConstantHelper.GrupoAdministrador, new AuthorizationPolicyBuilder()
               .RequireAuthenticatedUser()
               .RequireClaim(ClaimTypes.Role, ConstantHelper.GrupoAdministrador)
               .Build());
            });
           
            services.AddSession(p=>p.Cookie.IsEssential=true);
            services.AddMemoryCache();
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

            //using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            //{
            //    try
            //    {
            //        var context = serviceScope.ServiceProvider.GetRequiredService<AppPrivyContext>();

            //        context.Database.EnsureDeleted();
            //        context.Database.EnsureCreated();

            //        DoacaoMaisDBInitializer.Seed(context);
            //        SiteDBInitializer.Seed(context);
            //        IdentityDBInitialize.Seed(context);

            //        context.SaveChanges();
            //    }
            //    catch (Exception e)
            //    {
            //        Debug.WriteLine($"Erro ao criar as tabelas {0}", e.Message);
            //    }
            //}



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

          


            app.UseAuthentication();
            app.UseAuthorization();


            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();

          

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "Identity",
                template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                               
                //routes.MapRoute(
                //    name: "DoacaoMais",
                //    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

            });          


        }

    }
}
