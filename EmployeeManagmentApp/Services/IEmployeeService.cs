using EmployeeManagmentApp.Models;

namespace EmployeeManagmentApp.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesAsync(string userId);
        Task<Employee?> GetEmployeeAsync(int id, string userId);
        Task<Employee?> AddEmployeeAsync(Employee employee, string userId);
        Task<Employee?> UpdateEmployeeAsync(Employee employee, string userId);
        Task<bool> DeleteEmployeeAsync(int id, string userId);

        Task<List<Employee>> SearchEmployeesAsync(string? firstName, string? lastName, string? pesel, string? city, string userId);

    }
}
