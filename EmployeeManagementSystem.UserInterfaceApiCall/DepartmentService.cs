using EmployeeDepartmentSkillGenderManagementSystem.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _httpClient;
        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Department> CreateDepartment(Department newDepartment)
        {
            return await _httpClient.PostJsonAsync<Department>("api/departments", newDepartment);
        }
        public async Task DeleteDepartment(int id)
        {
            await _httpClient.DeleteAsync($"api/departments/{id}");
        }
        public async Task<Department> GetDepartmentById(int id)
        {
            return await _httpClient.GetJsonAsync<Department>($"api/departments/{id}");
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _httpClient.GetJsonAsync<Department[]>("api/departments");
        }
        public async Task<Department> UpdateDepartment(Department updatedDepartment)
        {
            return await _httpClient.PutJsonAsync<Department>("api/departments", updatedDepartment);
        }
    }
}
