using EmployeeManagmentApp.Models;
using EmployeeManagmentApp.Services.Intrefaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace EmployeeManagmentApp.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private UserManager<IdentityUser> _userManager;
        private IExportService _exportService;

        public EmployeeController(IEmployeeService service, UserManager<IdentityUser> userManager, IExportService exportService)
        {
            _employeeService = service;
            _userManager = userManager;
            _exportService = exportService;
        }

        private string? GetUserId() => _userManager.GetUserId(User);

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder)
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }

            ViewBag.CurrentSort = sortOrder;
            ViewBag.FirstNameSortParam = sortOrder == "first-name" ? "first-name-desc" : "first-name";
            ViewBag.LastNameSortParam = sortOrder == "last-name" ? "last-name-desc" : "last-name";
            ViewBag.HireDateSortParam = sortOrder == "hire-date" ? "hire-date-desc" : "hire-date";
            ViewBag.CitySortParam = sortOrder == "city" ? "city-desc" : "city";

            var employees = await _employeeService.SortEmployees(userId, sortOrder);

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

            var employee = await _employeeService.GetEmployeeAsync(id, userId);
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
            var createdEmployee = await _employeeService.AddEmployeeAsync(employee, userId);
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

            var employee = await _employeeService.GetEmployeeAsync(id, userId);
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
            var updatedEmployee = await _employeeService.UpdateEmployeeAsync(employee, userId);

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

            var success = await _employeeService.DeleteEmployeeAsync(id, userId);
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

            var employees = await _employeeService.SearchEmployeesAsync(firstName, lastName, pesel, city, userId);
            return View(employees);
        }

        [HttpPost]
        public async Task<IActionResult> ExportToExcel()
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }
            var employees = await _employeeService.GetEmployeesAsync(userId);

            var fileBytes = _exportService.GenerateEmployeesExcel(employees);

            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "employees.xlsx");
        }

        [HttpPost]
        public async Task<IActionResult> ExportToCsv()
        {
            var userId = GetUserId();
            if (userId is null)
            {
                return Challenge();
            }
            var employees = await _employeeService.GetEmployeesAsync(userId);

            var fileBytes = _exportService.GenerateEmployeesCsv(employees);

            return File(
                fileContents: fileBytes,
                contentType: "text/csv",
                fileDownloadName: "employees.csv"
            );
        }
    }
}

