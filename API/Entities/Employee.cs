using System;

namespace API.Entities;

public class Employee
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Position { get; set; }
    public required string Salary { get; set; }
}
