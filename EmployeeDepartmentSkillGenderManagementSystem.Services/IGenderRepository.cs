using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public interface IGenderRepository
    {
        Task<IEnumerable<Gender>> GetGenders();
        Task<Gender> GetGender(int id);
        Task<Gender> Create(Gender gender);
        Task<Gender> Update(Gender genderToUpdate);
        Task<Gender> Delete(int id);
    }
}
