using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class TechSkillMap : IEntityTypeConfiguration<TechSkill>
    {
        public void Configure(EntityTypeBuilder<TechSkill> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.HasData(
                new TechSkill { Id = 1, Name = "C" },
                new TechSkill { Id = 2, Name = "C++" },
                new TechSkill { Id = 3, Name = "C#" },
                new TechSkill { Id = 4, Name = "JavaScript" },
                new TechSkill { Id = 5, Name = "Swift" },
                new TechSkill { Id = 6, Name = "Objective-C" },
                new TechSkill { Id = 7, Name = "Kotlin" },
                new TechSkill { Id = 8, Name = "React" },
                new TechSkill { Id = 9, Name = "Node" },
                new TechSkill { Id = 10, Name = "React Native" },
                new TechSkill { Id = 11, Name = "Java" },
                new TechSkill { Id = 12, Name = "Ruby" },
                new TechSkill { Id = 13, Name = "Go" },
                new TechSkill { Id = 14, Name = "Python" },
                new TechSkill { Id = 15, Name = "SQL" },
                new TechSkill { Id = 16, Name = "MySQL" },
                new TechSkill { Id = 17, Name = "MongoDB" }
            );
        }
    }
}
