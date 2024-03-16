using CustomersApp.API.Configurations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Application layer setup
builder.Services.AddApplicationSetup();

// Persistence setup
builder.Services.AddPersistenceSetup();

// Logging setup
builder.Host.UseLoggingSetup(builder.Configuration);

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

// Exception handling
app.SetupErrorHandling();

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
