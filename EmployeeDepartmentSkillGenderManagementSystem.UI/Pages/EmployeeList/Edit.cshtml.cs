using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.EmployeeList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IEmployeeRepository _repository;
        [BindProperty]
        public Employee Employee { get; set; }
        public EditModel(ApplicationDbContext appDbContext, IEmployeeRepository repository)
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
                return RedirectToPage("/CustomerNotFound");
            }
            ViewData["DepartmentId"] = new SelectList(_appDbContext.Departments, "DepartmentId", "DepartmentName");
            ViewData["GenderId"] = new SelectList(_appDbContext.Genders, "GenderId", "Sex");
            ViewData["SkillId"] = new SelectList(_appDbContext.Skills, "SkillId", "SkillName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _repository.Update(Employee);
            return RedirectToPage("Index");
        }
    }
}
