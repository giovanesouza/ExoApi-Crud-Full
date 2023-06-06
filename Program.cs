using Microsoft.EntityFrameworkCore;
using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

/**/
builder.Services.AddScoped<ExoContext, ExoContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// FAZ A INJEÇÃO DA CONEXÃO COM O CONTEXTO
builder.Services.AddDbContext<ExoContext>(options =>
{
     options.UseSqlServer(builder.Configuration.GetConnectionString("Conexao"));

});


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

