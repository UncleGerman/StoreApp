using Store.Infrastructure.Injections;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddMvc();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext(connection);
builder.Services.AddDAL();
builder.Services.AddInfrastructure();
builder.Services.AddBLL();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseCors(builder => builder.WithOrigins("http://localhost:4200"));

app.Run();
