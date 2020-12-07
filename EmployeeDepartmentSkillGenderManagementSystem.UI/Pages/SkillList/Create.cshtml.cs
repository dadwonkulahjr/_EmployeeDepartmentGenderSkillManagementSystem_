using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList
{
    public class CreateModel : PageModel
    {
        private readonly ISkillRepository _repository;
        [BindProperty]
        public Skill Skill { get; set; }
        public CreateModel(ISkillRepository repository)
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

            await _repository.Create(Skill);
            return RedirectToPage("Index");

        }
    }
}
