using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public interface IGenderService
    {
        Task<IEnumerable<Gender>> GetGenders();
        Task<Gender> GetGenderById(int id);
        Task<Gender> CreateGender(Gender gender);
        Task<Gender> UpdateGender(Gender genderToUpdate);
        Task DeleteGender(int id);
    }
}
