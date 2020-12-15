using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.PublishedYear).IsRequired();
            builder.Property(x => x.Price).HasPrecision(18, 2).IsRequired();
            builder.Property(x => x.DiscountPrice).HasPrecision(18, 2);
            builder.Property(x => x.ViewsCount);
            builder.Property(x => x.LeftInStock).IsRequired();

            builder.HasMany(x => x.Genres).WithMany(x => x.Books);
            builder.HasMany(x => x.Authors).WithMany(x => x.Books);
            builder.HasMany(x => x.Comments).WithOne(x => x.Book).OnDelete(DeleteBehavior.Cascade);
        }
    }
}