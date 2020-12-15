using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(100);
            builder.Property(x => x.LastName).HasMaxLength(100);

            builder.HasMany(x => x.Books).WithMany(x => x.Authors);
        }
    }
}