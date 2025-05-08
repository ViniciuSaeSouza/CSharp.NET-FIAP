
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using TDSPK.Infrastructure.Context;

namespace TDSPK
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API para cadastro de Photo",
                    Version = "v1",
                    Description = "API da Turma PK 2025 - 1° semestre",
                    Contact = new OpenApiContact
                    {
                        Name = "Vinicius",
                        Email = "vinicius@fiap.com"
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";  //TDSPK.API.xml
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile); /*C:/dev/tdspk/TDSPK.API.xml*/

                swagger.IncludeXmlComments(xmlPath);
            });

            builder.Services.AddDbContext<PhotosContext>(options =>
            options.UseOracle(builder.Configuration.GetConnectionString("Oracle"))
            );


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
