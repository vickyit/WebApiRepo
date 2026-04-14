
using Microsoft.EntityFrameworkCore;
using WebApiStudent.Data;
using WebApiStudent.Models.Dis;
using WebApiStudent.Models.Repostories.Students;

namespace WebApiStudent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddSwaggerGen();

            var connection = builder.Configuration
                .GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<StudentContext>(option =>
            option.UseSqlServer(connection));

            builder.Services.AddSingleton<ITest1, Test1>();
            builder.Services.AddScoped<ITest2, Test2>();
            builder.Services.AddTransient<ITest3, Test3>();

            builder.Services.AddTransient<IStudentRepository
                , StudentRepository>();

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }


            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
