using HelpDeskAPI.Repository.Schemas;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskAPI.Repository.Extensions.FluentAPI
{
    public static class AddressFluentAPI
    {
        public static ModelBuilder AddressModelBuilder(this ModelBuilder builder)
        {
            builder.Entity<Address>(entity => 
            {
                entity.HasKey(x => x.ID);

                entity.Property(x => x.ID).HasColumnName(nameof(Address) + "ID");
                entity.Property(x => x.AddressName).IsRequired().HasColumnType("VARCHAR(150)").HasMaxLength(150);
                entity.Property(x => x.AddressNubmer).HasColumnType("VARCHAR(20)").HasMaxLength(20); ;
                entity.Property(x => x.Complement).HasColumnType("VARCHAR(50)").HasMaxLength(50); ;
                entity.Property(x => x.Cep).IsRequired().HasColumnType("VARCHAR(150)").HasMaxLength(150);
                entity.Property(x => x.CityID).IsRequired().HasColumnType("VARCHAR(9)").HasMaxLength(9);
                entity.Property(x => x.CreatedDate).IsRequired();
                entity.Property(x => x.Neighborhood).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);

                entity.HasOne(x => x.City).WithOne(x => x.Address).HasForeignKey<Address>(x => x.CityID);
            });
            return builder;
        }
    }
}
