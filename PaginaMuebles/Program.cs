var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Habilitar CORS para permitir que el frontend acceda a la API
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll",
		policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();
app.UseDefaultFiles();  // Busca index.html por defecto
app.UseStaticFiles();   // Sirve archivos desde wwwroot

  // Opcional si usas Web API



app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();

app.Run();
