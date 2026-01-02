using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EmployeeManagmentApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole imię jest wymagane")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole nazwisko jest wymagane")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole pesel jest wymagane")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Pole pesel musi zawierać dokładnie 11 znaków")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Pole pesel musi zawierać tylko cyfry")]
        
        public string Pesel { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole email jest wymagane")]
        [EmailAddress(ErrorMessage = "Niepoprawny format email")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole numer telefonu jest wymagane")]
        [Phone(ErrorMessage = "Niepoprawny format numeru telefonu")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Telefon musi mieć 9 cyfr.")]
        public string Phone { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole adres jest wymagane")]
        public Address? Address { get; set; }
        [Required(ErrorMessage = "Pole stanowisko jest wymagane")]
        public string Position { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole pensja jest wymagane")]
        [Precision(18, 2)]
        public decimal Salary { get; set; } = 0m;


        [Required(ErrorMessage = "Pole data zatrudnienia jest wymagane")]
        public DateTime HireDate { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Właściciel rekordu (user z Identity)
        public string? UserId { get; set; }
    }
}
