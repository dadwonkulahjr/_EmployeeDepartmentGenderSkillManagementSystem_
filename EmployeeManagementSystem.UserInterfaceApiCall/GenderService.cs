using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public class GenderService : IGenderService
    {
        private readonly HttpClient _httpClient;
        public GenderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Gender> CreateGender(Gender newGender)
        {
            return await _httpClient.PostJsonAsync<Gender>("api/genders", newGender);
        }
        public async Task DeleteGender(int id)
        {
            await _httpClient.DeleteAsync($"api/genders/{id}");
        }
        public async Task<Gender> GetGenderById(int id)
        {
            return await _httpClient.GetJsonAsync<Gender>($"api/genders/{id}");
        }
        public async Task<IEnumerable<Gender>> GetGenders()
        {
            return await _httpClient.GetJsonAsync<Gender[]>("api/genders");
        }
        public async Task<Gender> UpdateGender(Gender updatedGender)
        {
            return await _httpClient.PutJsonAsync<Gender>("api/genders", updatedGender);
        }
    }
}
