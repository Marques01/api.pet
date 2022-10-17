using API.Configuration;

var builder = WebApplication.CreateBuilder(args);


DatabaseConfiguration.ConfigureConnection(builder.Services, builder.Configuration);
DependecyInjection.RegisterDependencyInjection(builder.Services);
IdentityConfiguration.RegisterConfiguretion(builder.Services);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x =>
x.AllowAnyMethod()
.AllowAnyHeader()
.WithExposedHeaders("*")
.SetIsOriginAllowed(x => true)
.AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//
app.Run();
