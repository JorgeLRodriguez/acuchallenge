using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var dbConnectionInfo = builder.Build().GetSection("ConnectionStrings:cnn").Value;
            optionsBuilder.UseSqlServer(dbConnectionInfo);
        }
        public DbSet<People> People { get; set; }
    }
}
