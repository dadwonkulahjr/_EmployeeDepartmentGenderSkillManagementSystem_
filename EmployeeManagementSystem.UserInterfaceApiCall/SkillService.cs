using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public class SkillService : ISkillService
    {
        private readonly HttpClient _httpClient;
        public SkillService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Skill> CreateSkill(Skill newSkill)
        {
            return await _httpClient.PostJsonAsync<Skill>("api/skills", newSkill);
        }
        public async Task DeleteSkill(int id)
        {
            await _httpClient.DeleteAsync($"api/skills/{id}");
        }
        public async Task<Skill> GetSkillById(int id)
        {
            return await _httpClient.GetJsonAsync<Skill>($"api/skills/{id}");
        }
        public async Task<IEnumerable<Skill>> GetListOfSkills()
        {
            return await _httpClient.GetJsonAsync<Skill[]>("api/skills");
        }
        public async Task<Skill> UpdateSkill(Skill updatedSkill)
        {
            return await _httpClient.PutJsonAsync<Skill>("api/skills", updatedSkill);
        }
    }
}
