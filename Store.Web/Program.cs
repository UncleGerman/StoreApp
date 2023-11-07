using Store.Infrastructure.Injections;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddDAL();
builder.Services.AddInfrastructure();
builder.Services.AddBLL();

builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionHandler("/Error");

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();