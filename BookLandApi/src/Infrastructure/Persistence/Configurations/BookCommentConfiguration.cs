using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class BookCommentConfiguration : IEntityTypeConfiguration<BookComment>
    {
        public void Configure(EntityTypeBuilder<BookComment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Body).IsRequired();
            builder.Property(x => x.Rating).HasPrecision(2, 1);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.Comments).OnDelete(DeleteBehavior.Cascade);
        }
    }
}