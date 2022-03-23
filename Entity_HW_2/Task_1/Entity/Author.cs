using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Task_1.Entity
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Curse> Curses { get; set; }
    }

    public class ConfiguringAuthor : IEntityTypeConfiguration<Author>
    {
        void IEntityTypeConfiguration<Author>.Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("AUTHOR");

            builder.HasKey(x => x.ID); ;

            builder.Property(x => x.FirstName)
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired();

            builder
                .HasMany(x => x.Curses)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorID)
                .HasPrincipalKey(x => x.ID)
                .IsRequired();
        }
    }
}
