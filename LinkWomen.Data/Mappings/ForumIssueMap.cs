using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class ForumIssueMap : IEntityTypeConfiguration<ForumIssue>
    {
        public void Configure(EntityTypeBuilder<ForumIssue> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.ForumType).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsPinned).IsRequired();
            builder.Property(x => x.Deleted).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(m => m.Issues)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId);

        }
    }
}
