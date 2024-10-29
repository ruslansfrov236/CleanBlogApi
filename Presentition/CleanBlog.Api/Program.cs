using CleanBlog.App;
using CleanBlog.Infrastructure;
using CleanBlog.Infrastructure.Filters;
using CleanBlog.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCleanBlogServiceRegistrationPersistence();
builder.Services.AddCleanBlogServiceRegistrationInfrastructure();

builder.Services.AddCleanBlogServiceRegistrationApp();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
});
builder.Services.AddCors(policy =>
{
    policy.AddDefaultPolicy(options =>
    {
        options.WithOrigins("").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors();
app.MapControllers();
 
app.Run();
