using System.ComponentModel.DataAnnotations;

namespace Models.Payroll
{
    public class SalaryStructure
    {
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        [Required]
        public decimal BasicSalary { get; set; }

        public decimal HRA { get; set; }

        public decimal Allowances { get; set; }

        public decimal Deductions { get; set; }

        public decimal NetSalary { get; set; }

        public DateTime SalaryMonth { get; set; }
    }
}
