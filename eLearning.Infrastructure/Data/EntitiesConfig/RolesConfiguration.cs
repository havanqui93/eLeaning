using System;
using eLearning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eLearning.Infrastructure.Data.EntitiesConfig
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RoleName).IsRequired().HasMaxLength(100);

            builder.Property(_ => _.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}

