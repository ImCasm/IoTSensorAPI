using IoTSensorAPI.Repository;
using IoTSensorAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Sql Server Configuration
// Conf EF with SQL Server
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), opt =>
    {
        opt.MigrationsAssembly(typeof(AppDbContext).Assembly?.FullName?.Split(',')[0]);
    }));
#endregion

#region dependency inyection
// Services
builder.Services.AddScoped<ReportService>();
builder.Services.AddScoped<UserService>();

// Repositories
builder.Services.AddScoped<ReportRepository>();
builder.Services.AddScoped<UserRepository>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
