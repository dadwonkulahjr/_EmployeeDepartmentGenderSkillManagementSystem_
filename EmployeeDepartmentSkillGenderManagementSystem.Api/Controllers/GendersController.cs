using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IGenderRepository _repository;
        public GendersController(IGenderRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<Gender>> GetListOfGenders()
        {
            try
            {
                return Ok(await _repository.GetGenders());
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                      "There were error in retrieving the data from the database!");
            }
        }
        [HttpGet(template: "{id:int}")]
        public async Task<ActionResult> GetGenderById(int id)
        {
            try
            {
                Gender gender = await _repository.GetGender(id);
                if (gender != null)
                {
                    return Ok(gender);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in retrieving the specific gender from the database!");
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateNewEmployee(Gender gender)
        {
            try
            {
                if (gender == null)
                {
                    return BadRequest();
                }
                var genderCreated = await _repository.Create(gender);
                return CreatedAtAction(nameof(GetGenderById), new { id = genderCreated.GenderId }, genderCreated);

            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in creating new employee, Please contact your admin!");
            }
        }
        [HttpPut()]
        public async Task<ActionResult> UpdateGender(Gender gender)
        {
            try
            {

                var getGender = await _repository.GetGender(gender.GenderId);
                if (getGender != null)
                {
                    return Ok(await _repository.Update(gender));
                }
                else
                {
                    return NotFound($"Gender with Id = {gender.GenderId} not found");
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "There were error in updating the gender data from the database!");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteGender(int id)
        {
            try
            {
                var genderToDelete = await _repository.GetGender(id);
                if (genderToDelete == null)
                {
                    return NotFound($"Gender with Id = {id} not found");
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
