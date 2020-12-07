using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartmentById(int id);
        Task<Department> CreateDepartment(Department department);
        Task<Department> UpdateDepartment(Department departmentToUpdate);
        Task DeleteDepartment(int id);
    }
}
