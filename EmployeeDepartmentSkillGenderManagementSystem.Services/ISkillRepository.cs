using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skill>> GetListOfSkills();
        Task<Skill> GetSkillId(int id);
        Task<Skill> Create(Skill skill);
        Task<Skill> Update(Skill skillToUpdate);
        Task<Skill> Delete(int id);
    }
}
