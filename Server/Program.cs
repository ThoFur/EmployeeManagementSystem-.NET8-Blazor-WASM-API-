using Microsoft.EntityFrameworkCore;
using ServerLibrary.Data;
using ServerLibrary.Helpers;
using ServerLibrary.Repositories.Contracts;
using ServerLibrary.Repositories.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagement") ??
        throw new InvalidOperationException("Sorry, your connection failed"));
});

builder.Services.Configure<JwtSection>(builder.Configuration.GetSection("JwtSection"));

builder.Services.AddScoped<IUserAccount, UserAccountRepository>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
