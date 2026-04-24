using EMPLOYEES.Aplicacion.mapeo;

using EMPLOYEES.Aplicacion;
using EMPLOYEES.Dominio.interfaces;
using EMPLOYEES.Infraestructura.Contexto;

using EMPLOYEES.Dominio;
using EMPLOYEES.Infraestructura.Repositorio;
using EMPLOYEES.Infraestructura;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
//database configuracion
builder.Services.AddScoped<EmployeesDbContext>();

//automapper configuration
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//mpeos
builder.Services.AddScoped<IEmpleadoMapping, EmpleadoMapping>();
/*
builder.Services.AddDbContext<EmployeesDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.MigrationsAssembly("Plutus.ProductPricing.DataAccess")<-- esta cambiar por temas de dbfirst
        });
});
*/
//"ConnectionStrings":{"DefaultConnection": "Server=empleado\\SQLEXPRESS;Database=employees; TrustServerCertifcate=True; Trusted_Connection=True;"}






// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
