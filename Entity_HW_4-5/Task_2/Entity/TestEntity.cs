using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_2.Entity
{
    public class TestEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class ProductConfig : IEntityTypeConfiguration<TestEntity>
    {
        void IEntityTypeConfiguration<TestEntity>.Configure(EntityTypeBuilder<TestEntity> builder)
        {
            builder.HasKey(p => p.ID).IsClustered();

            builder.Property(p => p.ID)
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(p => p.Name)
                .IsRequired();
        }
    }

}
