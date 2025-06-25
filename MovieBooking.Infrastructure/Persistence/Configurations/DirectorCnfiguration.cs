using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class DirectorCnfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasConversion(
                id => id.value,
                value => new DirectorId(value))
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(x => x.Movies)
                .WithOne()
                .HasForeignKey(x => x.DirectorId)
                .IsRequired();
        }
    }
}
