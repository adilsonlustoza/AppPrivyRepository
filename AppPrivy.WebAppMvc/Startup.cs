using AppPrivy.Data.Contexto;
using AppPrivy.Data.Interface;
using AppPrivy.Data.Repositories;
using AppPrivy.Data.Repositories.DoacaoMais;
using AppPrivy.Domain;
using AppPrivy.Domain.Interfaces.Repositories;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

            services.AddDbContext<AppPrivyContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DoacaoMaisContext"));
            });



            services.AddTransient<IContextManager, ContextManager>();

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBaseDoacaoMais<>));
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBaseSite<>));

            services.AddTransient<IBazarRepository, BazarRepository>();
            services.AddTransient<IBoletimRepository, BoletimRepository>();
            services.AddTransient<ICacccRepository, CacccRepository>();
            services.AddTransient<IContaBancariaRepository, ContaBancariaRepository>();
            services.AddTransient<IConteudoRepository, ConteudoRepository>();
            services.AddTransient<IDispositivoRepository, DispositivoRepository>();
            services.AddTransient<INoticiaRepository, NoticiaRepository>();
            services.AddTransient<INotificacaoRepository, NotificacaoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddTransient<IPesquisaRepository, PesquisaRepository>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
