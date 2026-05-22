using Microsoft.EntityFrameworkCore;
using MinmalApi.Model;

namespace MinmalApi.Data
{
    public class ApplecationDbContext : DbContext
    {
        public ApplecationDbContext(DbContextOptions<ApplecationDbContext> options) : base(options) { }


        public DbSet<Employee> Employees { get; set; }




    }
}
