using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public class EmployeeRepoImplementation : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepoImplementation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Employee> Create(Employee employee)
        {
            var result = await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Employee> Delete(int id)
        {
            var findEmployeeFirst = await _dbContext.Employees.FindAsync(id);
            if (findEmployeeFirst != null)
            {
                _dbContext.Employees.Remove(findEmployeeFirst);
                await _dbContext.SaveChangesAsync();
                return findEmployeeFirst;
            }
            return null;
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _dbContext.Employees.ToListAsync();
        }
        public async Task<Employee> Update(Employee employeeToUpdate)
        {
            var modifiedEmployee = _dbContext.Employees.Attach(employeeToUpdate);
            modifiedEmployee.State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
            return employeeToUpdate;
        }
    }
}
