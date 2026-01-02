using EmployeeManagmentApp.Models;
using EmployeeManagmentApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;


namespace EmployeeManagmentApp.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private IEmployeeService _service;
        private UserManager<IdentityUser> _userManager;

        public EmployeeController(IEmployeeService service, UserManager<IdentityUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        private string? GetUserId() => _userManager.GetUserId(User);

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            var employees = await _service.GetEmployeesAsync(userId);
            return View(employees);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            var employee = await _service.GetEmployeeAsync(id, userId);
            if (employee is null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            var createdEmployee = await _service.AddEmployeeAsync(employee, userId);
            if (createdEmployee == null)
            {
                ModelState.AddModelError("Pesel", "Pracownik z takim numerem pesel juz istnieje");
                return View(employee);
            }
            TempData["SuccessMessage"] = "Pomyślnie dodano pracownika";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            var employee = await _service.GetEmployeeAsync(id, userId);
            if (employee is null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            var updatedEmployee = await _service.UpdateEmployeeAsync(employee, userId);

            if (updatedEmployee == null)
            {
                ModelState.AddModelError("Pesel", "Pracownik o danym numerze PESEL już istnieje");
                return View(employee);
            }

            TempData["SuccessMessage"] = "Pomyślnie edytowano pracownika";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            var success = await _service.DeleteEmployeeAsync(id, userId);
            if (!success)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Search(string? firstName, string? lastName, string? pesel, string? city)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            var employees = await _service.SearchEmployeesAsync(firstName, lastName, pesel, city, userId);
            return View(employees);
        }

        [HttpGet]
        public IActionResult Export()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ExportToExcel()
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }
            var employees = await _service.GetEmployeesAsync(userId);

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Employees");
                worksheet.Cells["A1"].Value = "Id";
                worksheet.Cells["B1"].Value = "Imię";
                worksheet.Cells["C1"].Value = "Nazwisko";
                worksheet.Cells["D1"].Value = "Pesel";
                worksheet.Cells["E1"].Value = "Email";
                worksheet.Cells["F1"].Value = "Numer telefonu";
                worksheet.Cells["G1"].Value = "Pensja";
                worksheet.Cells["H1"].Value = "Data zatrudnienia";
                worksheet.Cells["I1"].Value = "Miasto";
                worksheet.Cells["J1"].Value = "Ulica";
                worksheet.Cells["K1"].Value = "Numer domu";
                worksheet.Cells["L1"].Value = "Numer mieszkania";
                worksheet.Cells["M1"].Value = "Kod pocztowy";




                for(var i = 0; i < employees.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = employees[i].Id;
                    worksheet.Cells[i + 2, 2].Value = employees[i].FirstName;
                    worksheet.Cells[i + 2, 3].Value = employees[i].LastName;
                    worksheet.Cells[i + 2, 4].Value = employees[i].Pesel;
                    worksheet.Cells[i + 2, 5].Value = employees[i].Email;
                    worksheet.Cells[i + 2, 6].Value = employees[i].Phone;
                    worksheet.Cells[i + 2, 7].Value = employees[i].Salary;
                    worksheet.Cells[i + 2, 8].Value = employees[i].HireDate;
                    worksheet.Cells[i + 2, 9].Value = employees[i].Address.City;
                    worksheet.Cells[i + 2, 10].Value = employees[i].Address.StreetName;
                    worksheet.Cells[i + 2, 11].Value = employees[i].Address.HouseNumber;
                    worksheet.Cells[i + 2, 12].Value = employees[i].Address.ApartamentNumber;
                    worksheet.Cells[i + 2, 13].Value = employees[i].Address.PostalCode;
                }

                var stream = new MemoryStream(package.GetAsByteArray());
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "employees.xlsx");
            }
        }
    }
}
