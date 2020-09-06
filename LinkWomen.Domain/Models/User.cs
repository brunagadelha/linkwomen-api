using LinkWomen.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace LinkWomen.Domain.Models
{
    public class User : Entity
    {
        public User()
        {
        }

        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
        public string UserName { get; set; }
        public string GitHub { get; set; }
        public UserRoleEnum UserRole { get; set; }
        public string PasswordHash { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsHighlighted { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public int? MentorId { get; set; }
        public User Mentor { get; set; }

        public IEnumerable<ForumIssue> Issues { get; set; }
        public IEnumerable<User> Mentorships { get; set; }
        public IEnumerable<UserTechSkill> TechSkills { get; set; }
        public List<UserConnection> Connections { get; set; }
    }
}
