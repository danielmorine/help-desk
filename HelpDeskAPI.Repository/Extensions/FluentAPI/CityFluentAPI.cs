using HelpDeskAPI.Repository.Schemas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskAPI.Repository.Extensions.FluentAPI
{
    public static class CityFluentAPI
    {
        public static ModelBuilder CityModelBuilder(this ModelBuilder builder)
        {
            builder.Entity<City>(entity => 
            {
                entity.HasKey(x => x.ID);
                entity.Property(x => x.ID).HasColumnName(nameof(City) + "ID").IsRequired();

                entity.Property(x => x.Name).HasColumnType("VARCHAR(100)").HasMaxLength(100).IsRequired();
                entity.Property(x => x.NormalizedName).HasColumnType("VARCHAR(100)").HasMaxLength(100).IsRequired();
                entity.Property(x => x.StateID).IsRequired();

                entity.HasOne(x => x.State).WithOne(x => x.City)
                        .HasForeignKey<City>(x => x.StateID)
                        .OnDelete(DeleteBehavior.Restrict);
            });
            return builder;
        }
    }
}
