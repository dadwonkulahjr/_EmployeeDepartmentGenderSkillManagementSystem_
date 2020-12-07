using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList
{
    public class EditModel : PageModel
    {
        private readonly ISkillRepository _repository;
        [BindProperty]
        public Skill Skill { get; set; }
        public EditModel(ISkillRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/SkillNotFound");
            }

            Skill = await _repository.GetSkillId(id.Value);

            if (Skill == null)
            {
                return RedirectToPage("/SkillNotFound");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _repository.Update(Skill);
            return RedirectToPage("Index");
        }
    }
}
