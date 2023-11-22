using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.IRepositories;
using RepositoryPattern.EF;
using RepositoryPattern.EF.Repositories;

namespace RepositoryPattern.API
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
            builder.Services.AddSwaggerGen();
            /*Register Connection string*/
            builder.Services.AddDbContext<ApplicationContext>
                (option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            //add transient
            builder.Services.AddTransient(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}