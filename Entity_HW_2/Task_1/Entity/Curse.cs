using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Entity
{
    public class Curse
    {
        public int ID { get; set; }
        [NotMapped] public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }

    public class ConfiguringCurse : IEntityTypeConfiguration<Curse>
    {
        void IEntityTypeConfiguration<Curse>.Configure(EntityTypeBuilder<Curse> builder)
        {
            builder.ToTable("CURSES");

            builder.HasKey(x => x.ID);

            builder
                .HasOne(x => x.Author)
                .WithMany(x => x.Curses)
                .HasForeignKey(x => x.AuthorID)
                .HasPrincipalKey(x => x.ID)
                .IsRequired();

            builder
                .Property(p => p.Price)
                .HasColumnType("Money");
        }
    }
}
