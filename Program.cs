using Microsoft.EntityFrameworkCore;
using OrderManagementAPI.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();
app.UseSwagger();
app.UseStaticFiles();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();
app.Run();