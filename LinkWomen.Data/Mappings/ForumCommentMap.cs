using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class ForumCommentMap : IEntityTypeConfiguration<ForumComment>
    {
        public void Configure(EntityTypeBuilder<ForumComment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Deleted).HasMaxLength(1000).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);  

            builder.HasOne(x => x.ForumIssue)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.ForumIssueId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
