
using EmployeeManagement.Core.Enums;

namespace EmployeeManagement.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Fullname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateTime? DOB { get; set; }

        public Gender? Genders { get; set; }

        public string? Address { get; set; }
    }
}
