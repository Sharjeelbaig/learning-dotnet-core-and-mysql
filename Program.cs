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

app.MapGet("/", () => {
    Test test = new Test();
    return test.sayHello();
});

app.Run();

public class Test
{
    public string sayHello()
    {
        return "Hello World! from Test class";
    }
}
