using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_2.Entity
{
    public class ThirdEntity
    {
        public int ID { get; set; }
        public ICollection<FirstEntity> Firsts { get; set; }
        public ICollection<SecondEntity> Seconds { get; set; }
    }

    public class ThirdEntityConfiguration : IEntityTypeConfiguration<ThirdEntity>
    {
        void IEntityTypeConfiguration<ThirdEntity>.Configure(EntityTypeBuilder<ThirdEntity> builder)
        {
            builder
                .HasMany(p => p.Firsts)
                .WithMany(p => p.Thirds);

            builder
                .HasMany(p => p.Seconds)
                .WithMany(p => p.Thirds);
        }
    }

}
