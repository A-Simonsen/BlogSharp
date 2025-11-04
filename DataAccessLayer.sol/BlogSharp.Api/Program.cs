using DataAccess.Interface;
using DataAccess.SQL_Server;
using Microsoft.IdentityModel.Tokens;

public class Program
{
    private const string _connectionString = "Data Source=localhost;Initial Catalog=BlogSharp;User ID=sa;Password=Your_password123;TrustServerCertificate=True";
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IAuthorDao>((_) => new AuthorDao(_connectionString));
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