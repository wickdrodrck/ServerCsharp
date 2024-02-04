using Microsoft.EntityFrameworkCore;
using P3Ejercicio2;
using P3Ejercicio2.Interfaces;
using P3Ejercicio2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BBDContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlBBDDEntitty"))
);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepositorioAlumnos, RepositorioAlumnos>();
builder.Services.AddScoped<IRepositorioCiclos, RepositorioCiclos>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<BBDContext>();
    dataContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ciclos}/{action=Index}/{id?}");

app.Run();
