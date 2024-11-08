using CleanBlog.App;
using CleanBlog.Infrastructure;
using CleanBlog.Infrastructure.Filters;
using CleanBlog.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Service registrations
builder.Services.AddCleanBlogServiceRegistrationPersistence();
builder.Services.AddCleanBlogServiceRegistrationInfrastructure();
builder.Services.AddCleanBlogServiceRegistrationApp();
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();

}).AddNewtonsoftJson(options =>
{
   
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("corsPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("corsPolicy");

app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

app.Run();
