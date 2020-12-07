using EmployeeDepartmentSkillGenderManagementSystem.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace EmployeeManagementSystem.UserInterfaceApiCall
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Employee> CreateEmployee(Employee newEmployee)
        {
            return await _httpClient.PostJsonAsync<Employee>("api/employees", newEmployee);
        }
        public async Task DeleteEmployee(int id)
        {
            await _httpClient.DeleteAsync($"api/employees/{id}");
        }
        public async Task<Employee> GetEmployeeId(int id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/employees");
        }
        public async Task<Employee> UpdateEmployee(Employee updatedEmployee)
        {
            return await _httpClient.PutJsonAsync<Employee>("api/employees", updatedEmployee);
        }
    }
}
