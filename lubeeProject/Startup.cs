using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Interfaces.Servicios;
using lubeeProject.Repositorio;
using lubeeProject.Servicio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lubeeProject
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
			{
				builder.AllowAnyOrigin()
					   .AllowAnyMethod()
					   .AllowAnyHeader();
			}));

			services.AddScoped<IProductosService, ProductosService>();
			services.AddScoped<IProductosRepositorio, ProductosRepositorio>();
			services.AddScoped<ICursoRepositorio, CursoRepositorio>();
			services.AddScoped<ICursoService, CursoService>();
			services.AddScoped<IContratoRepositorio, ContratoRepositorio>();
			services.AddScoped<IContratoService, ContratoService>();

			services.AddDbContext<AppDbContext>(options =>
				options.UseMySQL(Configuration.GetConnectionString("Default")));
			services.AddControllers()
				.AddNewtonsoftJson(options =>
					options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
				);
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "lubeeProject", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "lubeeProject v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseCors("MyPolicy");

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
