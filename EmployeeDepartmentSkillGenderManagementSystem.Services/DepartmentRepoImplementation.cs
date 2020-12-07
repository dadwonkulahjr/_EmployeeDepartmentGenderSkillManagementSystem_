using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Services
{
    public class DepartmentRepoImplementation : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepoImplementation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Department> Create(Department department)
        {
            var result = await _dbContext.Departments.AddAsync(department);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Department> Delete(int id)
        {
            var findDepartmentToDelete = await _dbContext.Departments.FindAsync(id);
            if (findDepartmentToDelete != null)
            {
                _dbContext.Departments.Remove(findDepartmentToDelete);
                await _dbContext.SaveChangesAsync();
                return findDepartmentToDelete;
            }
            return null;
        }
        public async Task<Department> GetDepartment(int id)
        {
            return await _dbContext.Departments.FirstOrDefaultAsync(d => d.DepartmentId == id);
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _dbContext.Departments.ToListAsync();
        }
        public async Task<Department> Update(Department departmentToUpdate)
        {
            var result = _dbContext.Departments.Attach(departmentToUpdate);
            result.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return departmentToUpdate;
        }
    }
}
