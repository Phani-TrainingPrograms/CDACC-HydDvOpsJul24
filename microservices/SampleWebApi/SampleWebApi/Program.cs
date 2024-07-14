
using Microsoft.EntityFrameworkCore;
using SampleWebApi.Data;

namespace SampleWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            /**********************Adding DBContext dependencies**************************/
            var dbHost = "localhost, 8001";
            var dbName = Environment.GetEnvironmentVariable("DB_NAME");
            var dbUser = Environment.GetEnvironmentVariable("DB_USER");
            var dbPwd = Environment.GetEnvironmentVariable("DB_PWD");

            var connection = $"Data Source={dbHost}; Initial Catalog={dbName}; User Id={dbUser}; Password={dbPwd}; Encrypt=false";
            builder.Services.AddDbContext<OnlineShoppingDbContext>(options => options.UseSqlServer(connection));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


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
