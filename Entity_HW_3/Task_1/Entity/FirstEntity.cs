using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_2.Entity
{
    public class FirstEntity
    {
        public int ID { get; set; }
        public ICollection<ThirdEntity> Thirds { get; set; }
        public ICollection<SecondEntity> Seconds { get; set; }
    }

    public class FirstEntityConfiguratin : IEntityTypeConfiguration<FirstEntity>
    {
        void IEntityTypeConfiguration<FirstEntity>.Configure(EntityTypeBuilder<FirstEntity> builder)
        {
            builder
                .HasMany(t => t.Thirds)
                .WithMany(f => f.Firsts);

            builder
                .HasMany(p => p.Seconds)
                .WithMany(p => p.Firsts);
        }
    }
}
