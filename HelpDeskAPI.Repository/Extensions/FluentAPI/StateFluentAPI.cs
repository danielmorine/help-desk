using HelpDeskAPI.Repository.Schemas;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskAPI.Repository.Extensions.FluentAPI
{
    public static class StateFluentAPI
    {
        public static ModelBuilder StateModelBuilder(this ModelBuilder builder)
        {
            builder.Entity<State>(entity => 
            {
                entity.HasKey(x => x.ID);
                entity.Property(x => x.ID).HasColumnName(nameof(State) + "ID").IsRequired();
                entity.Property(x => x.Name).HasColumnType("VARCHAR(100)").HasMaxLength(100).IsRequired();
                entity.Property(x => x.NormalizedName).HasColumnType("VARCHAR(100)").HasMaxLength(100).IsRequired();
                entity.Property(x => x.Abbrev).HasColumnType("VARCHAR(10)").HasMaxLength(10).IsRequired();
            });
            return builder;
        }
    }
}
