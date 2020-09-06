using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id); 

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(); 
            builder.Property(x => x.UserName).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.CPF).HasMaxLength(11).IsRequired();
            builder.Property(x => x.PasswordHash).HasMaxLength(100).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UserRole).IsRequired();

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Deleted).IsRequired();
            builder.Property(x => x.IsHighlighted).IsRequired();

            builder.Property(x => x.Bio).HasMaxLength(2000);
            builder.Property(x => x.Occupation).HasMaxLength(50);
            builder.Property(x => x.GitHub).HasMaxLength(200);
            builder.Property(x => x.UpdatedAt); 
            builder.Property(x => x.PhotoUrl).HasMaxLength(200); 

            builder.HasOne(x => x.Mentor)
                .WithMany(m => m.Mentorships)
                .HasForeignKey(x => x.MentorId); 
            
        }
    }
}
