using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        "Server=localhost;Database=testdb;User=root;Password=password;",
        ServerVersion.AutoDetect(
            "Server=localhost;Database=testdb;User=root;Password=password;"
        )
    ));

WebApplication app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();

