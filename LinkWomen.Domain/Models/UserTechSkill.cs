using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.Models
{
    public class UserTechSkill : Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int TechSkillId { get; set; }
        public TechSkill TechSkill { get; set; }
    }
}
