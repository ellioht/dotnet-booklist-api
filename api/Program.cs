using Booklist.Models;
using Booklist.Services;
using Booklist.Settings;
using Microsoft.AspNetCore.Cors;

var builder = WebApplication.CreateBuilder(args);

// Link the MongoDBSettings class to the MongoDB section in appsettings.json
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));

// Add the BooklistService to the services collection so that it can be used in other parts of the application
builder.Services.AddSingleton<BooklistService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
  options.AddPolicy("CorsPolicy", builder =>
  {
    builder.WithOrigins("http://localhost:5173").AllowAnyMethod().AllowAnyHeader();
  });
});

var app = builder.Build();

// Log a message to the console when the API starts
app.Run(async context =>
{
  Console.WriteLine("API started");
  await Task.CompletedTask;
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

