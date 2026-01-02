using EmployeeManagmentApp.Data;
using EmployeeManagmentApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagmentApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployeesAsync(string userId)
        {
            var employees = await _context.Employees.Where(e => e.UserId == userId).Include(e => e.Address).ToListAsync();
            return employees;
        }

        public async Task<Employee?> GetEmployeeAsync(int id, string userId)
        {
            Employee? employee = await _context.Employees.Where(e => e.UserId == userId).Include(e => e.Address).FirstOrDefaultAsync(e => e.Id == id);
            return employee;
        }

        public async Task<Employee?> AddEmployeeAsync(Employee employee, string userId)
        {
            var existEmployeePesel = await _context.Employees.FirstOrDefaultAsync(e => e.Pesel == employee.Pesel && e.UserId == userId);
            if (existEmployeePesel != null)
            {
                return null;
            }
            employee.UserId = userId;
            employee.CreatedAt = DateTime.UtcNow;
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> UpdateEmployeeAsync(Employee employee, string userId)
        {
            Employee? existing = await _context.Employees.Include(e => e.Address).FirstOrDefaultAsync(e => e.UserId == userId && e.Id == employee.Id);

            if (existing is null)
            {
                return null;
            }

            var existingPesel = await _context.Employees.FirstOrDefaultAsync(e => e.Pesel == employee.Pesel && e.Id != employee.Id && e.UserId == userId);

            if (existingPesel != null)
            {
                return null;
            }


            existing.FirstName = employee.FirstName;
            existing.LastName = employee.LastName;
            existing.Pesel = employee.Pesel;
            existing.Email = employee.Email;
            existing.Phone = employee.Phone;
            existing.Position = employee.Position;
            existing.Salary = employee.Salary;
            existing.HireDate = employee.HireDate;
            existing.UpdatedAt = DateTime.UtcNow;

            if (existing.Address == null)
            {
                existing.Address = new Address();
            }
               
            existing.Address.City = employee.Address.City;
            existing.Address.StreetName = employee.Address.StreetName;
            existing.Address.HouseNumber = employee.Address.HouseNumber;
            existing.Address.ApartamentNumber = employee.Address.ApartamentNumber;
            existing.Address.PostalCode = employee.Address.PostalCode;


            //_context.Employees.Update(existing);
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteEmployeeAsync(int id, string userId)
        {
            Employee? employee = await _context.Employees.Where(e => e.UserId == userId).Include(e => e.Address).FirstOrDefaultAsync(e => e.Id == id);
            if (employee is null)
            {
                return false;
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<List<Employee>> SearchEmployeesAsync(string? firstName, string? lastName, string? pesel, string? city, string userId)
        {
            var query = _context.Employees.Where(e => e.UserId == userId).Include(e => e.Address).AsQueryable();

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(e => e.FirstName.ToLower().Contains(firstName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(e => e.LastName.ToLower().Contains(lastName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(pesel))
            {
                query = query.Where(e => e.Pesel == pesel);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                query = query.Where(e => e.Address.City.ToLower().Contains(city.ToLower()));
            }

            return query.ToListAsync();

        }


        //stara wersja
        public async Task<List<Employee>> SearchEmployeesByFirstNameAsync(string firstName)
        {
            var employees = await _context.Employees.Include(e => e.Address).Where(e => e.FirstName.ToLower().Contains(firstName.ToLower())).ToListAsync();
            return employees;
        }

        public async Task<List<Employee>> SearchEmployeesByLastNameAsync(string lastName)
        {
            var employees = await _context.Employees.Include(e => e.Address).Where(e => e.LastName.ToLower().Contains(lastName.ToLower())).ToListAsync();
            return employees;
        }

        public async Task<List<Employee>> SearchEmployeesByPeselAsync(string pesel)
        {
            var employees = await _context.Employees.Include(e => e.Address).Where(e => e.Pesel == pesel).ToListAsync();
            return employees;
        }

        public async Task<List<Employee>> SearchEmployeesByCityAsync(string city)
        {
            var employees = await _context.Employees.Include(e => e.Address).Where(e => e.Address.City == city).ToListAsync();
            return employees;
        }




    }
}
