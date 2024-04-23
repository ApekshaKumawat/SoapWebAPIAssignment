using SoapCore;
using SOAPWebApiAssignment.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IOperations, OperationsImpl>();
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
app.UseSoapEndpoint<IOperations>("/Operations.asmx", new SoapEncoderOptions());
//app.UseSoapEndpoint<IOperations>("/Operations1.asmx", new SoapEncoderOptions());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
