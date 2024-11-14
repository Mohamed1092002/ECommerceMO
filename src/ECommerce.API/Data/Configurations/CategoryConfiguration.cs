﻿using ECommerce.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.API.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired(false);
            builder.HasIndex(x => x.Name);
        }
    }
}
