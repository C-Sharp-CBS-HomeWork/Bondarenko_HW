using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_2.Entity
{
    public class SecondEntity
    {
        public int ID { get; set; }
        public ICollection<FirstEntity> Firsts { get; set; }
        public ICollection<ThirdEntity> Thirds { get; set; }
    }

    public class SecondEntityConfiguration : IEntityTypeConfiguration<SecondEntity>
    {
        void IEntityTypeConfiguration<SecondEntity>.Configure(EntityTypeBuilder<SecondEntity> builder)
        {
            builder
                .HasMany(p => p.Firsts)
                .WithMany(p => p.Seconds);

            builder
                .HasMany(p => p.Thirds)
                .WithMany(p => p.Seconds);
        }
    }
}
