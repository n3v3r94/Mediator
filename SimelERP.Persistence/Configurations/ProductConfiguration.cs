using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimelERP.Domain.Entities;

namespace SimelERP.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(s => s.CategoryId);
        }
    }
}
