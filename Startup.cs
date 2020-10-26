using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Loja.Data;
using Loja.Repositories;
using Microsoft.OpenApi.Models;

namespace Loja
{
    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddResponseCompression();
            services.AddScoped<StoreDataContext, StoreDataContext>();
            services.AddTransient<BicicletaRepository, BicicletaRepository>();

            services.AddSwaggerGen(x=>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Version = "v1", Title = "Minha API"});
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();


            app.UseResponseCompression();
            app.UseMvc();
            app.UseSwagger();

            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Meu API - v1");
            });
        }
    }
}
