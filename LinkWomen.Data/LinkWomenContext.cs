using LinkWomen.Data.Mappings;
using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace LinkWomen.Data
{
    public class LinkWomenContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserTechSkill> UserTechSkills { get; set; }
        public DbSet<UserConnection> UserConnections { get; set; }
        public DbSet<TechSkill> TechSkills { get; set; }
        public DbSet<ForumIssue> ForumIssues { get; set; }
        public DbSet<ForumComment> ForumComments { get; set; }
        public DbSet<ForumCategory> ForumCategories { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("connectionStrings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TechSkillMap());
            modelBuilder.ApplyConfiguration(new UserTechSkillMap());

            modelBuilder.ApplyConfiguration(new ForumIssueMap());
            modelBuilder.ApplyConfiguration(new ForumCommentMap());
            modelBuilder.ApplyConfiguration(new ForumCategoryMap());

            modelBuilder.ApplyConfiguration(new EventMap());
            modelBuilder.ApplyConfiguration(new UserConnectionMap());

        }
    }
}
