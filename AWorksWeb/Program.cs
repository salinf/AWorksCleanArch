using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("AWConnection");
builder.Services.AddDbContext<AdventureWorksContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use CORS
app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod());

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/ErrorRoute");
}
else
{

}

app.UseAuthorization();

app.MapControllers();

app.Run();



