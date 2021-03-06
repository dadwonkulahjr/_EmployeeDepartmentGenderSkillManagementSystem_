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
    public class DetailsModel : PageModel
    {
        private readonly IGenderRepository _repository;
        public Gender Gender { get; set; }
        public DetailsModel(IGenderRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/GenderNotFound");
            }

            Gender = await _repository.GetGender(id.Value);

            if (Gender == null)
            {
                return RedirectToPage("/GenderNotFound");
            }
            return Page();
        }
    }
}
