using Microsoft.EntityFrameworkCore;
using Truextend.TicketDispenser.Core;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TicketDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("TicketContextDb"));
});
builder.Services.AddSingleton<TicketManager>();
builder.Services.AddSingleton<EventShowManager>();
builder.Services.AddSingleton<CategoryManager>();
builder.Services.AddTransient<VenueManager>();
builder.Services.AddSingleton<ZoneManager>();
builder.Services.AddTransient<UserManager>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(name: "v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "TicketsAPI", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Tickets API");
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
