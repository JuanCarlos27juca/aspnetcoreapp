using aspnetcoreapp;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(/*options =>
{
    options.Conventions.AuthorizeFolder("/Empleado", "admin");
}*/);
builder.Services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth",
    options =>
    {
        options.Cookie.Name = "MycookieAuth";
        options.LoginPath = "/Index";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });
builder.Services.AddAuthorization(
    options =>
    {
        options.AddPolicy("DebeSerAdministrador", policy => policy.RequireClaim("Usuario", "Administrador"));
    });
builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name =DefaultConnection"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
