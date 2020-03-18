using System;
using System.ComponentModel.DataAnnotations.Schema;
using DoctorMeal.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorMeal.Persistence.Configuration
{
    [Table("Restaurant")]
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurant");
            builder.HasKey(x => x.Id);
        }
    }
}
