using ColoreEntrega2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ColoreEntrega2.Data;
using ColoreEntrega2.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ColoreEntrega2ContextConnection"); builder.Services.AddDbContext<ColoreEntrega2Context>(options =>
 options.UseSqlServer(connectionString)); builder.Services.AddDefaultIdentity<ColoreEntrega2User>(options => options.SignIn.RequireConfirmedAccount = false)
  .AddEntityFrameworkStores<ColoreEntrega2Context>();

//Conex�o banco de dados Patricia
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-DB6AS9Q; Initial Catalog=Colore; Integrated Security = True"));

//Conex�o banco de dados Jo�o Victor
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-LCPGQT9;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Juliana
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-6V7IQ3S;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Leonardo
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-IGD0CBU\SQLEXPRESS;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Luiz
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-;Initial Catalog=Colore;Integrated Security=True"));

//Conex�o banco de dados Wesley
//builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Data Source=DESKTOP-1LSE35M;Initial Catalog=Entrega;Integrated Security=True"));

//Conexão online
builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(@"Server=tcp:coloreentrega2dbserver.database.windows.net,1433;Initial Catalog=ColoreEntrega2_db;Persist Security Info=False;User ID=colore;Password=124578Co;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
