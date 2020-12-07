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
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _appDbContext;
        public Employee Employee { get; set; }
        public DetailsModel(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/CustomerNotFound");
            }
            Employee = await _appDbContext.Employees
                                 .Include(e => e.Department)
                                 .Include(e => e.Gender)
                                 .Include(e => e.Skill)
                                 .FirstOrDefaultAsync(e => e.EmployeeId == id);
            if (Employee == null)
            {
                return RedirectToPage("/CustomerNotFound");
            }

            return Page();
        }
    }
}
