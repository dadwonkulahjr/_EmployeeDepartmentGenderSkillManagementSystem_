using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.EmployeeList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _appDbContext;
        public IEnumerable<Employee> Employees { get; set; }
        public IndexModel(ApplicationDbContext repository)
        {
            _appDbContext = repository;
        }
        public async Task OnGet()
        {
            Employees = await _appDbContext.Employees
                                .Include(e => e.Department)
                                .Include(e => e.Gender)
                                .Include(e => e.Skill)
                                .ToListAsync();
        }
    }
}
