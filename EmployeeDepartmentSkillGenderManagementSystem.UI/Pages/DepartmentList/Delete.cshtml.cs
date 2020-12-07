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
    public class DeleteModel : PageModel
    {
        private readonly IDepartmentRepository _repository;
        public bool ShowModal { get; set; } = true;
        [BindProperty]
        public Department Department { get; set; }
        public DeleteModel(IDepartmentRepository repository)
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
        public async Task<IActionResult> OnPostCheckDeleteAsync(int? id)
        {
            Department = await _repository.GetDepartment(id.Value);
            if (Department == null)
            {
                return RedirectToPage("/DepartmentNotFound");
            }
            ShowModal = false;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/DepartmentNotFound");
            }

            Department = await _repository.GetDepartment(id.Value);

            if (Department == null)
            {
                return RedirectToPage("/AgentNotFound");
            }
            Department agent = await _repository.Delete(Department.DepartmentId);
            if (agent == null)
            {
                return RedirectToPage("/DatabaseError");
            }
            return RedirectToPage("Index");
        }
    }
}
