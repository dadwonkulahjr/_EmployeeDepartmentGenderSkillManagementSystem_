using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.EmployeeList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _repository;
        private readonly IEmployeeRepository _employeeRepository;
        public CreateModel(ApplicationDbContext repository, IEmployeeRepository employeeRepository)
        {
            _repository = repository;
            _employeeRepository = employeeRepository;
         
        }

        [BindProperty]
        public Employee Employee { get; set; }
        public IActionResult OnGet()
        {
            ViewData["DepartmentId"] = new SelectList(_repository.Departments, "DepartmentId", "DepartmentName");
            ViewData["GenderId"] = new SelectList(_repository.Genders, "GenderId", "Sex");
            ViewData["SkillId"] = new SelectList(_repository.Skills, "SkillId", "SkillName");
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _employeeRepository.Create(Employee);
            return RedirectToPage("Index");
        }
    }
}
