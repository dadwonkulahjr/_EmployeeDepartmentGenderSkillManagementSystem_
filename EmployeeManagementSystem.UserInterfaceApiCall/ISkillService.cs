using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public interface ISkillService
    {
        Task<IEnumerable<Skill>> GetListOfSkills();
        Task<Skill> GetSkillById(int id);
        Task<Skill> CreateSkill(Skill skill);
        Task<Skill> UpdateSkill(Skill skillToUpdate);
        Task DeleteSkill(int id);
    }
}
