
using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        //.3. add using di dbcontext to app
        builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("ImMem"));
        // .6. add di interface and concrate repository to service
        builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();
        // add AutoMapper
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        //add controllers
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        //.8. add db
        PrepDb.PrepPopulation(app);

        app.UseHttpsRedirection();
        app.MapControllers();
        app.Run();
    }
}