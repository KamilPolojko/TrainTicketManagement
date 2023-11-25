using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
    options.AddPolicy(name: "MyAllowSpecificOrigins",
        builder =>
        {
            //builder.AllowAnyOrigin(); Tylko jak tworzymy Api do publicznego u¿ytku
            builder.WithOrigins("https://locallhost:7253");

        }));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen( c=>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "WebApplication",
        Version = "v1",
        Description = "A simple web application",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact()
        {
            Name = "Kamil",
            Email = string.Empty,
            Url = new Uri("https://facebook.com/szkoladotneta")
        },
        License = new OpenApiLicense()
        {
            Name = "Used License",
            Url = new Uri("https://example.com/license")
        }
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "TrainTicketManagement.xml");
    c.IncludeXmlComments(filePath);
});

builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c=>c.SwaggerEndpoint("/swagger/v1/swagger.json","WebApplication"));
    app.UseDeveloperExceptionPage();
}

//Dla publicznego wykorzystania naszego Api
//app.UseSwagger();
//app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplication"));

app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
