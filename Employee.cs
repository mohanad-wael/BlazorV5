using EmployeeManagement.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blazorv5
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
       
        public int DepartmentId { get; set; }
        
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
