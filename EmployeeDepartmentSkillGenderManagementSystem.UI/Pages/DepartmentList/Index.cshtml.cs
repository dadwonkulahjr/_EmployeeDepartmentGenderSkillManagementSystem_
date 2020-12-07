using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.DepartmentList
{
    public class IndexModel : PageModel
    {
        private readonly IDepartmentRepository _repository;
        public IEnumerable<Department> Departments { get; set; }
        public IndexModel(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public async Task OnGet()
        {
            Departments = (await _repository.GetDepartments()).ToList();
        }
    }
}
