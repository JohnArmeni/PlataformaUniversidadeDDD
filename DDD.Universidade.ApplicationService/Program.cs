
using DDD.Infra.SqlServer;
using DDD.Infra.SqlServer.Interfaces;
using DDD.Infra.SqlServer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAlunoRepository, AlunoRepositorySqlServer>();
builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepositorySqlServer>();
builder.Services.AddScoped<IMatriculaRepository, MatriculaRepositorySqlServer>();
builder.Services.AddScoped<IPesquisadorRepository, PesquisadorRepositorySqlServer>();
builder.Services.AddScoped<IProjetoRepository, ProjetoRepositorySqlServer>();
builder.Services.AddScoped<IPosGraduacaoRepository, PosGraduacaoRepositorySqlServer>();
builder.Services.AddScoped<BoletimService, BoletimService>();
builder.Services.AddScoped<PosGraduacaoService, PosGraduacaoService>();
builder.Services.AddScoped<ApplicationServiceBoletim, ApplicationServiceBoletim>();
builder.Services.AddScoped<ApplicationServiceProjeto, ApplicationServiceProjeto>();
builder.Services.AddScoped<SqlContext, SqlContext>();


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
