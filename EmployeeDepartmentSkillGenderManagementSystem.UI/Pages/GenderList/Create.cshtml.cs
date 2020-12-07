using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.GenderList
{
    public class CreateModel : PageModel
    {
        private readonly IGenderRepository _repository;
        [BindProperty]
        public Gender Gender { get; set; }
        public CreateModel(IGenderRepository repository)
        {
            _repository = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _repository.Create(Gender);
            return RedirectToPage("Index");

        }
    }
}
