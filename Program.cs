var builder = WebApplication.CreateBuilder(args);

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

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
https://dotnet.microsoft.com/en-us/learn/aspnet/microservice-tutorial/docker-image

to finish: 

> docker build -t MicroserviceDOTNET .
> docker images

go to http://localhost:5203/WeatherForecast  or whichever port indicated

> docker run -it --rm -p 3000:80 --name mymicroservicecontainer MicroserviceDOTNET
> docker ps


then deploy to Azure 
https://dotnet.microsoft.com/en-us/learn/aspnet/deploy-microservice-tutorial/intro

*/