using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public class SkillRepoImplementation : ISkillRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SkillRepoImplementation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Skill> Create(Skill skill)
        {
            var result = await _dbContext.Skills.AddAsync(skill);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Skill> Delete(int id)
        {
            var findSkillToDelete = await _dbContext.Skills.FindAsync(id);
            if (findSkillToDelete != null)
            {
                _dbContext.Skills.Remove(findSkillToDelete);
                await _dbContext.SaveChangesAsync();
                return findSkillToDelete;
            }
            return null;
        }
        public async Task<IEnumerable<Skill>> GetListOfSkills()
        {
            return await _dbContext.Skills.ToListAsync();
        }
        public async Task<Skill> GetSkillId(int id)
        {
            return await _dbContext.Skills.FirstOrDefaultAsync(s => s.SkillId == id);
        }
        public async Task<Skill> Update(Skill skillToUpdate)
        {
            var result = _dbContext.Skills.Attach(skillToUpdate);
            result.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return skillToUpdate;
        }
    }
}
