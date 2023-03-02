using Truextend.Rewards.Data;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenserAPI.Configuration;
using Truextend.TicketDispenserAPI.Configuration.Database;
using Truextend.TicketDispenserAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TicketDispenserDBContext>();
//builder.Services.AddSingleton<EventShowManager>();

//builder.Services.AddSingleton<UserManager>();
//builder.Services.AddSingleton<VenueManager>();

//builder.Services.AddSingleton<TicketManager>();
//builder.Services.AddSingleton<CategoryManager>();
//builder.Services.AddSingleton<EventShowManager>();
builder.Services.AddTransient<IApplicationConfiguration, ApplicationConfiguration>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<ZoneManager>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
