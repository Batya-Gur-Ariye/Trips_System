using Microsoft.EntityFrameworkCore;
using Project_Trips_Core.IServices;
using Project_Trips_Core.Profiles;
using Project_Trips_Core.Services;
using Project_Trips_Data.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<MyDbContext>(option =>
        {
            option.UseSqlServer(builder.Configuration.GetConnectionString("TripSqlConnection"));
        });

        builder.Services.AddScoped(typeof(DbContext), typeof(MyDbContext));

        builder.Services.AddAutoMapper(typeof(UserProfile));
        builder.Services.AddAutoMapper(typeof(TripProfile));
        builder.Services.AddAutoMapper(typeof(OrderProfile));

        builder.Services.AddScoped(serviceType: typeof(ITripService), implementationType: typeof(TripService));
        builder.Services.AddScoped(serviceType: typeof(IUserService), implementationType: typeof(UserService));
        builder.Services.AddScoped(serviceType: typeof(IOrderService), implementationType: typeof(OrderService));

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
    }
}