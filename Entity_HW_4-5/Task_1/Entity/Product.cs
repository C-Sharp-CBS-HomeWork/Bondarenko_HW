using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_1.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }

    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        void IEntityTypeConfiguration<Product>.Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ID).IsClustered();
            builder.HasAlternateKey(p => p.ProductName);

            builder.Property(p => p.ID)
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(p => p.ProductName)
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnType("money")
                .IsRequired();
        }
    }

}
