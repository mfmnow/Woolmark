using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Wool.Test.Glossary.Data;
using Wool.Test.Glossary.Data.Contracts;
using Wool.Test.Glossary.Data.Services;
using Wool.Test.Glossary.Domain.Contacts;
using Wool.Test.Glossary.Domain.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace Wool.Test.Glossary.App
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
            var _connectionString = Configuration.GetConnectionString("DefaultConnection").Replace("{AppDir}", Directory.GetCurrentDirectory());
            services.AddDbContext<GlossaryDBContext>(options =>
            options.UseSqlServer(_connectionString));

            services.AddTransient<IGlossaryTermDataManager, GlossaryTermDataManager>();
            services.AddTransient<IGlossaryTermDomainManager, GlossaryTermDomainManager>();

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            //// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
