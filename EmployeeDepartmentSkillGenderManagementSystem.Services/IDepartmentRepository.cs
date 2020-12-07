using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
        Task<Department> Create(Department department);
        Task<Department> Update(Department departmentToUpdate);
        Task<Department> Delete(int id);

    }
}
