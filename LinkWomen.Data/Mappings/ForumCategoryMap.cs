using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class ForumCategoryMap : IEntityTypeConfiguration<ForumCategory>
    {
        public void Configure(EntityTypeBuilder<ForumCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.HasData(
                new ForumCategory() { Id = 1, Name = "Representatividade" },
                new ForumCategory() { Id = 2, Name = "LGBT+" },
                new ForumCategory() { Id = 3, Name = "Vagas" },
                new ForumCategory() { Id = 4, Name = "Tech" }
                );
        }
    }
}
