using EmployeeManagmentApp.Models;
using EmployeeManagmentApp.Services.Intrefaces;
using OfficeOpenXml;
using System.Text;
using EmployeeManagmentApp.Services.DTOs;

namespace EmployeeManagmentApp.Services
{
    public class ExportService : IExportService
    {
        public byte[] GenerateEmployeesExcel(List<Employee> employees)
        {
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Employees");
            SetupHeaders(worksheet);
            PopulateEmployeeData(worksheet, employees);
            return package.GetAsByteArray();

        }

        public byte[] GenerateEmployeesCsv(List<Employee> employees)
        {
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Employees");

            worksheet.Cells["A1"].LoadFromCollection(FlattenEmployeesForExport(employees), PrintHeaders: true);
            var range = worksheet.Cells[worksheet.Dimension.Address];

            var format = new ExcelOutputTextFormat
            {
                Delimiter = ';',
                Encoding = Encoding.UTF8,
                FirstRowIsHeader = true
            };

            using var ms = new MemoryStream();
            range.SaveToText(ms, format);

            return ms.ToArray();
        }

        private List<EmployeeCsvDto> FlattenEmployeesForExport(List<Employee> employees)
        {
            var exportData = employees.Select(e => new EmployeeCsvDto
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Pesel = e.Pesel,
                Email = e.Email,
                Phone = e.Phone,
                City = e.Address.City,
                StreetName = e.Address.StreetName,
                HouseNumber = e.Address.HouseNumber,
                ApartamentNumber = e.Address.ApartamentNumber,
                PostalCode = e.Address.PostalCode,
                Position = e.Position,
                Salary = e.Salary,
                HireDate = e.HireDate.ToString(),
                CreatedAt = e.CreatedAt.ToString(),
                UpdatedAt = e.UpdatedAt.ToString()
            }).ToList();
            return exportData;
        }


        //PRIVATE HELPER METHODS
        private static void SetupHeaders(ExcelWorksheet worksheet)
        {
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
        }

        private static void PopulateEmployeeData(ExcelWorksheet worksheet, List<Employee> employees)
        {
            for (var i = 0; i < employees.Count; i++)
            {
                worksheet.Cells[i + 2, 1].Value = employees[i].Id;
                worksheet.Cells[i + 2, 2].Value = employees[i].FirstName;
                worksheet.Cells[i + 2, 3].Value = employees[i].LastName;
                worksheet.Cells[i + 2, 4].Value = employees[i].Pesel;
                worksheet.Cells[i + 2, 5].Value = employees[i].Email;
                worksheet.Cells[i + 2, 6].Value = employees[i].Phone;
                worksheet.Cells[i + 2, 7].Value = employees[i].Salary;
                worksheet.Cells[i + 2, 8].Value = employees[i].HireDate.ToString();
                worksheet.Cells[i + 2, 9].Value = employees[i].Address.City;
                worksheet.Cells[i + 2, 10].Value = employees[i].Address.StreetName;
                worksheet.Cells[i + 2, 11].Value = employees[i].Address.HouseNumber;
                worksheet.Cells[i + 2, 12].Value = employees[i].Address.ApartamentNumber;
                worksheet.Cells[i + 2, 13].Value = employees[i].Address.PostalCode;
            }
        }
    }

}
