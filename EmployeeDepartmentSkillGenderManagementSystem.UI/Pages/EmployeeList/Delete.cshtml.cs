using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.EmployeeList
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IEmployeeRepository _repository;
        public bool ShowModal { get; set; } = true;
        [BindProperty]
        public Employee Employee { get; set; }
        public DeleteModel(ApplicationDbContext appDbContext, IEmployeeRepository repository)
        {
            _appDbContext = appDbContext;
            _repository = repository;
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
                return RedirectToPage("/DefaultNotFound");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostCheckDeleteAsync(int? id)
        {
            Employee = await _appDbContext.Employees
                                  .Include(e => e.Department)
                                  .Include(e => e.Gender)
                                  .Include(e => e.Skill)
                                  .FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (Employee == null)
            {
                return RedirectToPage("/CustomerNotFound");
            }
            ShowModal = false;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/CustomerNotFound");
            }

            Employee = await _appDbContext.Employees.FindAsync(id);

            if (Employee != null)
            {
                await _repository.Delete(id.Value);
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage("/CustomerNotFound");
            }
        }
    }
}
