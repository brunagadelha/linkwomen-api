using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWomen.Services.Services
{
    public class TechSkillService : ITechSkillService
    {
        private readonly IGenericRepository<TechSkill> _techSkillRepository;

        public TechSkillService(IGenericRepository<TechSkill> techSkillRepository)
        {
            _techSkillRepository = techSkillRepository; 
        }

        public IEnumerable<TechSkill> GetAll()
        {
            return _techSkillRepository.GetAll().AsEnumerable(); 
        }
    }
}
