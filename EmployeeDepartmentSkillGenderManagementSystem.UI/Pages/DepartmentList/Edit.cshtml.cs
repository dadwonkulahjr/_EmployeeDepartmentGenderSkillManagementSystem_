using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.DepartmentList
{
    public class EditModel : PageModel
    {
        private readonly IDepartmentRepository _repository;
        [BindProperty]
        public Department Department { get; set; }
        public EditModel(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/DepartmentNotFound");
            }

            Department = await _repository.GetDepartment(id.Value);

            if (Department == null)
            {
                return RedirectToPage("/DepartmentNotFound");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _repository.Update(Department);
            return RedirectToPage("Index");
        }

    }
}
