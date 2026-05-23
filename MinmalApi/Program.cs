using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinmalApi.Data;
using MinmalApi.Model;
using System.Reflection.Metadata.Ecma335;

namespace MinmalApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
          /*  builder.Services.AddAuthorization();
            builder.Services.AddDbContext<ApplecationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
*/

            var app = builder.Build();

            // Configure the HTTP request pipeline.


            app.MapGet("/", () =>
            {
                return "CI CD Success";
            });


            app.Run();
        }
    }
}
