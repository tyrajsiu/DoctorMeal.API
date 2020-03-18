using Microsoft.EntityFrameworkCore;

namespace DoctorMeal.Persistence
{
    public class DoctorMealDbContext : DbContext
    {
        public DoctorMealDbContext(DbContextOptions options)
            : base(options) { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }

            //modelBuilder.ApplyConfiguration()
        }
    }
}
