using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços para controllers com views.
builder.Services.AddControllersWithViews();

// Adiciona o serviço CORS com uma política personalizada.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Adiciona a geração de documentação com Swagger.
builder.Services.AddSwaggerGen(c =>
{
    // Configura as informações do Swagger para a documentação da API.
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Crud Pessoas",
        Version = "v1",
        Description = "Minha api foi criada para fazer um crud de pessoas",
        Contact = new OpenApiContact
        {
            Name = "Eduardo Araújo dos Santos",
            Email = "Eduardoeko7@gmail.com"
        }
    });

    // Inclui comentários XML para os controllers.
    var xmlFile = $"{AppDomain.CurrentDomain.BaseDirectory}CrudPessoas.xml";
    c.IncludeXmlComments(xmlFile);
});

var app = builder.Build();

// Configura o pipeline de requisições HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // O valor padrão do HSTS é 30 dias. Considere alterá-lo para produção.
    app.UseHsts();
}

// Middleware para redirecionamento HTTP para HTTPS.
app.UseHttpsRedirection();

// Middleware para servir arquivos estáticos.
app.UseStaticFiles();

// Configura o roteamento.
app.UseRouting();

// Ativa a política CORS definida anteriormente.
app.UseCors("AllowAll");

// Middleware para autorização.
app.UseAuthorization();

// Adiciona o middleware para o Swagger e a UI do Swagger.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    // Configura o endpoint do Swagger e define a rota base da UI do Swagger.
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1");
    c.RoutePrefix = string.Empty; // Define a rota base para a UI do Swagger
});

// Configura a rota padrão para controllers MVC.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
