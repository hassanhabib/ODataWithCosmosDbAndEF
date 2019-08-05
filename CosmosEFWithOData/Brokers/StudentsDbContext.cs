using CosmosEFWithOData.Models;
using Microsoft.EntityFrameworkCore;

namespace CosmosEFWithOData.Brokers
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
