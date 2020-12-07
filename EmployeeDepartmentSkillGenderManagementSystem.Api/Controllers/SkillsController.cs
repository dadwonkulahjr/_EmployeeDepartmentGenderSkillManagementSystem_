using System.Threading.Tasks;
using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillRepository _repository;
        public SkillsController(ISkillRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<Skill>> GetListOfSkills()
        {
            try
            {
                return Ok(await _repository.GetListOfSkills());
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                      "There were error in retrieving the data from the database!");
            }
        }
        [HttpGet(template: "{id:int}")]
        public async Task<ActionResult> GetSkillById(int id)
        {
            try
            {
                Skill skill = await _repository.GetSkillId(id);
                if (skill != null)
                {
                    return Ok(skill);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in retrieving the specific skill from the database!");
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateNewSkill(Skill skill)
        {
            try
            {
                if (skill == null)
                {
                    return BadRequest();
                }
                var skillCreated = await _repository.Create(skill);
                return CreatedAtAction(nameof(GetSkillById), new { id = skillCreated.SkillId }, skillCreated);

            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in creating new skill, Please contact your admin!");
            }
        }
        [HttpPut()]
        public async Task<ActionResult> UpdateSkill(Skill skill)
        {
            try
            {

                var getSkill = await _repository.GetSkillId(skill.SkillId);
                if (getSkill != null)
                {
                    return Ok(await _repository.Update(skill));
                }
                else
                {
                    return NotFound($"Skill with Id = {skill.SkillId} not found");
                }
            }
            catch (System.Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "There were error in updating the skill data from the database!");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteSkill(int id)
        {
            try
            {
                var skillToDelete = await _repository.GetSkillId(id);
                if (skillToDelete == null)
                {
                    return NotFound($"Skill with Id = {id} not found");
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
