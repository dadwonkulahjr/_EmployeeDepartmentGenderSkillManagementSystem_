using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public class GenderRepoImplementation : IGenderRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public GenderRepoImplementation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Gender> Create(Gender gender)
        {
            var result = await _dbContext.Genders.AddAsync(gender);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Gender> Delete(int id)
        {
            var findGenderToDelete = await _dbContext.Genders.FindAsync(id);
            if (findGenderToDelete != null)
            {
                _dbContext.Genders.Remove(findGenderToDelete);
                await _dbContext.SaveChangesAsync();
                return findGenderToDelete;
            }
            return null;
        }
        public async Task<Gender> GetGender(int id)
        {
            return await _dbContext.Genders.FirstOrDefaultAsync(g => g.GenderId == id);
        }
        public async Task<IEnumerable<Gender>> GetGenders()
        {
            return await _dbContext.Genders.ToListAsync();
        }
        public async Task<Gender> Update(Gender genderToUpdate)
        {
            var updateGender = _dbContext.Genders.Attach(genderToUpdate);
            updateGender.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return genderToUpdate;
        }

    }
}
