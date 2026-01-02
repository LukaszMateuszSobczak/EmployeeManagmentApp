using EmployeeManagmentApp.Models;
using EmployeeManagmentApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


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
    }
}
