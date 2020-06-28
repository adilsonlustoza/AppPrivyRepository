using AppPrivy.Application;
using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Fault;
using AppPrivy.CrossCutting.Operations;
using AppPrivy.InfraStructure.Contexto;
using AppPrivy.InfraStructure.Interface;
using AppPrivy.InfraStructure.Repositories;
using AppPrivy.InfraStructure.Repositories.DoacaoMais;
using AppPrivy.Domain;
using AppPrivy.Domain.Interfaces;
using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using AppPrivy.Domain.Services;
using AppPrivy.Domain.Services.DoacaoMais;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using AppPrivy.InfraStructure.Repositories.Site;
using System;
using AppPrivy.InfraStructure.Repositories.Identity;

namespace AppPrivy.WebAppMvc
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

            services.AddDbContext<AppPrivyContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("AppPrivyContext"),
             b => b.MigrationsAssembly("AppPrivy.WebAppMvc"))
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
            });

          

            services.AddMvc(options => options.EnableEndpointRouting = false)
              .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
              .AddRazorPagesOptions(options =>
              {
                  options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                  options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
              });


            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", config => {
                    config.Cookie.Name = "AppPrivy.Cookie";
                    config.LoginPath = new PathString($"/Identity/Account/Login");
                    config.LogoutPath = new PathString($"/Identity/Account/Logout");
                    config.AccessDeniedPath = new PathString($"/Identity/Account/AccessDenied");
                });            

          //  services.AddControllersWithViews();       
            
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
            //services.AddTransient<IPesquisaRepository, PesquisaRepository>();

            services.AddTransient<IContatoService, ContatoService>();
            services.AddTransient<IPesquisaService, PesquisaService>();

            services.AddTransient<IContatoAppService, ContatoAppService>();
            services.AddTransient<IPesquisaAppService, PesquisaAppService>();

            services.AddScoped<FaultException>();
            services.AddScoped<SendMail>();      

            services.AddRazorPages().AddRazorPagesOptions(options =>
         {
             //options.RootDirectory = "/Areas";
             //options.Conventions.AuthorizePage("/Login");
             //options.Conventions.AuthorizeFolder("/Identity");
             //options.Conventions.AllowAnonymousToPage("/Identity/Register");
             //options.Conventions.AllowAnonymousToFolder("/Identity");
             //options.Conventions.AuthorizeAreaFolder("Identity", "/Manage");
             //options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Login");
             
             options.Conventions.AddAreaPageRoute("Identity", "/Login", "Account");
         });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
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

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                try
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<AppPrivyContext>();
                 
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    DoacaoMaisDBInitializer.Seed(context);
                    SiteDBInitializer.Seed(context);
                    IdentityDBInitialize.Seed(context); 

                    context.SaveChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Erro ao criar as tabelas {0}",e.Message ); 
                }
            }


         
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Identity",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "Blog",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "DoacaoMais",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });       


        }

    }
}
