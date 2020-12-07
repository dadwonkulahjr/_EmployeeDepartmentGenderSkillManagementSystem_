using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.GenderList
{
    public class IndexModel : PageModel
    {
        private readonly IGenderRepository _repository;
        public IEnumerable<Gender> Genders { get; set; }
        public IndexModel(IGenderRepository repository)
        {
            _repository = repository;
        }
        public async Task OnGet()
        {
            Genders = (await _repository.GetGenders()).ToList();
        }
    }
}
