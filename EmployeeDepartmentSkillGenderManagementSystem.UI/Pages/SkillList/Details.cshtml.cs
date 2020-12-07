using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList
{
    public class DetailsModel : PageModel
    {
        private readonly ISkillRepository _repository;
        public Skill Skill { get; set; }
        public DetailsModel(ISkillRepository repository)
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
    }
}
