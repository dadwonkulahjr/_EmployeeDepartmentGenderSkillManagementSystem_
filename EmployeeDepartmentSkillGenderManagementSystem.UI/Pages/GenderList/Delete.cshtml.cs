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
    public class DeleteModel : PageModel
    {
        private readonly IGenderRepository _repository;
        public bool ShowModal { get; set; } = true;
        [BindProperty]
        public Gender Gender { get; set; }
        public DeleteModel(IGenderRepository repository)
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
        public async Task<IActionResult> OnPostCheckDeleteAsync(int? id)
        {
            Gender = await _repository.GetGender(id.Value);
            if (Gender == null)
            {
                return RedirectToPage("/GenderNotFound");
            }
            ShowModal = false;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
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
            Gender agent = await _repository.Delete(Gender.GenderId);
            if (agent == null)
            {
                return RedirectToPage("/DatabaseError");
            }
            return RedirectToPage("Index");
        }
    }
}
