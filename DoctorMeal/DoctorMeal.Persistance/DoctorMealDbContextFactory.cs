using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DoctorMeal.Persistence
{
    public class DoctorMealDbContextFactory : IDesignTimeDbContextFactory<DoctorMealDbContext>
    {
        private readonly string _connectionString;

        public DoctorMealDbContextFactory() 
        {
            var basePath = Directory.GetCurrentDirectory() + string.Format("{0}..{0}DoctorMeal.API", Path.DirectorySeparatorChar);
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();

            _connectionString = configuration["ConnectionStrings:DoctorMealConnection"];
        }

        public DoctorMealDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DoctorMealDbContext>();
            optionBuilder.UseSqlServer(_connectionString);

            return new DoctorMealDbContext(optionBuilder.Options);
        }

        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
}
