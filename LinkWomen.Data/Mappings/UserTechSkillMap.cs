using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class UserTechSkillMap : IEntityTypeConfiguration<UserTechSkill>
    {
        public void Configure(EntityTypeBuilder<UserTechSkill> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(m => m.TechSkills)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.TechSkill)
                .WithMany()
                .HasForeignKey(x => x.TechSkillId);
        }
    }
}
