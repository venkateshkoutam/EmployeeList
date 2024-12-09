using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoining { get; set; }

        [Precision(18, 2)]
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }

    }
}
