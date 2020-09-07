using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public interface ITechSkillService
    {
        IEnumerable<TechSkill> GetAll(); 
    }
}
