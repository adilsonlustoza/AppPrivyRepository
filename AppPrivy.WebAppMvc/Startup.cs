using AppPrivy.Application;
using AppPrivy.Application.Interfaces;
using AppPrivy.CrossCutting.Fault;
using AppPrivy.CrossCutting.Operations;
using AppPrivy.InfraStructure.Contexto;
using AppPrivy.InfraStructure.Interface;
using AppPrivy.InfraStructure.Repositories;
using AppPrivy.InfraStructure.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Repositories.Site;
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
            services.AddControllersWithViews();

            services.AddMvc(options=>options.EnableEndpointRouting=false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDbContext<DoacaoMaisContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppPrivyContext"), b => b.MigrationsAssembly("AppPrivy.WebAppMvc"));
            });
            
            services.AddDbContext<SiteContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppPrivyContext"), b => b.MigrationsAssembly("AppPrivy.WebAppMvc"));
            });

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<SiteContext>();         



            services.AddTransient<IContextManager, ContextManager>();
            services.AddTransient<DoacaoMaisContext>();
            services.AddTransient<SiteContext>();


            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBaseDoacaoMais<>));
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBaseSite<>));
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


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(Configuration);

           



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DoacaoMaisContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                DoacaoMaisDBInitializer.Seed(context);
            }


            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<SiteContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                SiteDBInitializer.Seed(context);
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

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

     

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");

            //    endpoints.MapControllers();
            //    endpoints.MapRazorPages();
            //});



            app.UseMvc(routes =>
            {


                routes.MapAreaRoute(
               name: "AreaBlog",
               areaName: "Blog",
               template: "Blog/{controller=Home}/{action=Index}/{id?}");

                routes.MapAreaRoute(
                name: "AreaDoacaoMais",
                areaName: "DoacaoMais",
                template: "DoacaoMais/{controller=Home}/{action=Index}/{id?}");

              //  routes.MapRoute(
              //  name: "blog",
              //  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
              //);

              //  routes.MapRoute(
              // name: "doacaomais",
              // template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
              //);

                routes.MapRoute(
                 name: "default",
                 template: "{controller=Home}/{action=Index}/{id?}"
               );

              
            });

        }
    }
}
