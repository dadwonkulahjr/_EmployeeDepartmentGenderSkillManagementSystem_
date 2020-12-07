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
    public class IndexModel : PageModel
    {

        private readonly ISkillRepository _repository;
        public IEnumerable<Skill> Skills { get; set; }
        public IndexModel(ISkillRepository repository)
        {
            _repository = repository;
        }
        public async Task OnGet()
        {
            Skills = (await _repository.GetListOfSkills()).ToList();
        }
    }
}
