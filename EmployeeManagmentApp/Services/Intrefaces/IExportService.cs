using EmployeeManagmentApp.Models;

namespace EmployeeManagmentApp.Services.Intrefaces
{
    public interface IExportService
    {
        public byte[] GenerateEmployeesCsv(List<Employee> employees);
        public byte[] GenerateEmployeesExcel(List<Employee> employees);
    }
}
