using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.DepartmentList
{
    public class CreateModel : PageModel
    {
        private readonly IDepartmentRepository _repository;
        [BindProperty]
        public Department Department { get; set; }
        public CreateModel(IDepartmentRepository repository)
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

            await _repository.Create(Department);
            return RedirectToPage("Index");

        }
    }
}
