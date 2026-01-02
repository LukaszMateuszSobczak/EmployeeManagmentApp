using EmployeeManagmentApp.Models;

namespace EmployeeManagmentApp.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesAsync(string userId);
        Task<Employee?> GetEmployeeAsync(int id, string userId); //mozliwe ze trzeba uzyc ?
        Task<Employee?> AddEmployeeAsync(Employee employee, string userId);
        Task<Employee?> UpdateEmployeeAsync(Employee employee, string userId);
        Task<bool> DeleteEmployeeAsync(int id, string userId);


        Task<List<Employee>> SearchEmployeesAsync(string? firstName, string? lastName, string? pesel, string? city, string userId);
        Task<List<Employee>> SearchEmployeesByFirstNameAsync(string firstName);
        Task<List<Employee>> SearchEmployeesByLastNameAsync(string lastName);
        Task<List<Employee>> SearchEmployeesByPeselAsync(string pesel);
        Task<List<Employee>> SearchEmployeesByCityAsync(string city);
    }
}
