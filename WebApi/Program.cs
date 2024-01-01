using MongoDB.Driver;
using WebApiProjectEdTech.Configurator;
using WebApiProjectEdTech.GlobalConstants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configure MongoDB
builder.Services.AddSingleton<IMongoClient>(serviceProvider =>
{
    // Replace with your MongoDB connection string
    string connectionString = GlobalConstants.DBConnectionString;
    return new MongoClient(connectionString);
});
builder.Services.RegisterServices();
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
