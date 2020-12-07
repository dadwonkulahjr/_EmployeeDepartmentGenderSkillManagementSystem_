using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _repository;
        public DepartmentsController(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<Department>> GetListOfDepartments()
        {
            try
            {
                return Ok(await _repository.GetDepartments());
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                      "There were error in retrieving the Departments data from the database!");
            }
        }
        [HttpGet(template: "{id:int}")]
        public async Task<ActionResult> GetDepartmentById(int id)
        {
            try
            {
                Department department = await _repository.GetDepartment(id);
                if (department != null)
                {
                    return Ok(department);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in retrieving the specific department from the database!");
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateNewDepartment(Department department)
        {
            try
            {
                if (department == null)
                {
                    return BadRequest();
                }
                var departmentCreated = await _repository.Create(department);
                return CreatedAtAction(nameof(GetDepartmentById), new { id = departmentCreated.DepartmentId }, departmentCreated);

            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in creating new department, Please contact your admin!");
            }
        }
        [HttpPut()]
        public async Task<ActionResult> UpdateDepartment(Department department)
        {
            try
            {

                var getDepartment = await _repository.GetDepartment(department.DepartmentId);
                if (getDepartment != null)
                {
                    return Ok(await _repository.Update(department));
                }
                else
                {
                    return NotFound($"Department with Id = {department.DepartmentId} not found");
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "There were error in updating the employee data from the database!");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            try
            {
                var departmentToDelete = await _repository.GetDepartment(id);
                if (departmentToDelete == null)
                {
                    return NotFound($"Department with Id = {id} not found");
                }

                return Ok(await _repository.Delete(id));

            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in deleting the data from the database!");

            }
        }
    }
}
