using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeDepartmentSkillGenderManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<Employee>> GetListOfEmployees()
        {
            try
            {
                return Ok(await _repository.GetEmployees());
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                      "There were error in retrieving the data from the database!");
            }
        }
        [HttpGet(template: "{id:int}")]
        public async Task<ActionResult> GetEmployeeById(int id)
        {
            try
            {
                Employee employee = await _repository.GetEmployee(id);
                if (employee != null)
                {
                    return Ok(employee);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in retrieving the specific employee from the database!");
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateNewEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return BadRequest();
                }
                var employeeCreated = await _repository.Create(employee);
                return CreatedAtAction(nameof(GetEmployeeById), new { id = employeeCreated.EmployeeId }, employeeCreated);

            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in creating new employee, Please contact your admin!");
            }
        }
        [HttpPut()]
        public async Task<ActionResult> UpdateEmployee(Employee employee)
        {
            try
            {

                var getEmployee = await _repository.GetEmployee(employee.EmployeeId);
                if (getEmployee != null)
                {
                    return Ok(await _repository.Update(employee));
                }
                else
                {
                    return NotFound($"Employee with Id = {employee.EmployeeId} not found");
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "There were error in updating the employee data from the database!");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            try
            {
                var employeeToDelete = await _repository.GetEmployee(id);
                if (employeeToDelete == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
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
