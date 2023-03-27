using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEOAG.Domain.Entities;

namespace TEOAG.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            
            builder.Property(pr => pr.ProductName)
                .HasColumnType("varchar(50)");

            builder.Property(pr => pr.ProductDescription)
                .HasColumnType("varchar(255)");    

            builder.Property(pr => pr.ProductDescription)
                .HasColumnType("notNullable()");      
        }
    }
}