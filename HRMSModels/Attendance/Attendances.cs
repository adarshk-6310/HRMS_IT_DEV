using System.ComponentModel.DataAnnotations;

namespace Models.Attendance
{
    public class Attendances
    {
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Status { get; set; } // Present, Absent, Leave

        public string Remarks { get; set; }
    }
}
