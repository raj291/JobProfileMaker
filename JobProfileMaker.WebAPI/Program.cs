using JobProfileMaker.core.Contracts.EntityServices;
using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.Infrastructure.Data;
using JobProfileMaker.Infrastructure.Repository;
using JobProfileMaker.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<JobProfileMakerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProfileMaker"));
});
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<ICandidateRepository, CandidateRepositoryAsync>();
builder.Services.AddScoped<ICandidateService, CandidateServiceAsync>();
builder.Services.AddScoped<IEducationRepository, EducationRepositoryAsync>();
builder.Services.AddScoped<IEducationService, EducationServiceAsync>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepositoryAsync>();
builder.Services.AddScoped<IExperienceService, ExperienceServiceAsync>();
builder.Services.AddScoped<ISkillRepository, SkillRepositoryAsync>();
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