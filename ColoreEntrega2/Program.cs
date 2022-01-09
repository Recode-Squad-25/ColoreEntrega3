using ColoreEntrega2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Conex�o banco de dados Patricia
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-DB6AS9Q; Initial Catalog=Colore; Integrated Security = True"));

//Conex�o banco de dados Jo�o Victor
builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-LCPGQT9;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Juliana
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-6V7IQ3S;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Leonardo
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-IGD0CBU\SQLEXPRESS;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Luiz
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Wesley
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-1LSE35M;Initial Catalog=Entrega;Integrated Security=True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
