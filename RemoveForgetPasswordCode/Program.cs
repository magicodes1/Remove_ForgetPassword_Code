using Microsoft.EntityFrameworkCore;
using test_event.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

string cn = builder.Configuration.GetConnectionString("dfconnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(cn,ServerVersion.AutoDetect(cn)));


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    DataSeed.Initialize(services);
}
app.MapControllers();
app.Run();
