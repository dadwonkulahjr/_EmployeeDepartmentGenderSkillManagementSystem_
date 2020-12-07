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
    public class DeleteModel : PageModel
    {
        private readonly ISkillRepository _repository;
        public bool ShowModal { get; set; } = true;
        [BindProperty]
        public Skill Skill { get; set; }
        public DeleteModel(ISkillRepository repository)
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
        public async Task<IActionResult> OnPostCheckDeleteAsync(int? id)
        {
            Skill = await _repository.GetSkillId(id.Value);
            if (Skill == null)
            {
                return RedirectToPage("/SkillNotFound");
            }
            ShowModal = false;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
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
            Skill agent = await _repository.Delete(Skill.SkillId);
            if (agent == null)
            {
                return RedirectToPage("/DatabaseError");
            }
            return RedirectToPage("Index");
        }
    }
}
