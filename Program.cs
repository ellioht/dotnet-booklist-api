using Booklist.Models;
using Booklist.Services;
using Booklist.Settings;

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
