using System;
using eLearning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eLearning.Infrastructure.Data.EntitiesConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

           // Add more config...


        }
    }
}

