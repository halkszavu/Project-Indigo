using Bll.Services;
using DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ServiceProvider = Bll.Services.Impl;

namespace WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			builder.Services.AddOpenApiDocument(configure =>
			{
				configure.Title = "Indigo API";
				configure.Version = "v1";
				configure.Description = "An ASP.NET Web API for the Indigo Project";
			});

			builder.Services.AddTransient<IItineraryService, ServiceProvider.ItineraryService>();
			builder.Services.AddTransient<IRecordingService, ServiceProvider.RecordingService>();
			builder.Services.AddTransient<IRouteService, ServiceProvider.RouteService>();
			builder.Services.AddTransient<IUserService, ServiceProvider.UserService>();

			builder.Services.AddDbContext<TransportationContext>(o =>
				o.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseOpenApi();
				app.UseSwaggerUi3();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}