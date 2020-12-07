using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> Create(Employee employee);
        Task<Employee> Update(Employee employeeToUpdate);
        Task<Employee> Delete(int id);
    }
}
