using Pass;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Konyvtar_Api.Context;

namespace Konyvtar_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<KonyvtarApi2023Context>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("SQLite"));
                options.UseLazyLoadingProxies();
            }
                );
            builder.Services.AddScoped<IPerson, Persons>();
            builder.Services.AddScoped<IBook, Books>();
            builder.Services.AddScoped<IOut,Outs>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(o => o.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}