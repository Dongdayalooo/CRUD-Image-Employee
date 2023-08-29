using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1._1.Areas.Admin.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime? EmployeeDOB { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmployeePhone { get; set; }
        public string? EmployeeEmail { get; set; }
        [Display(Name = "Image")]
        public string? EmployeeImage { get; set; }
        
        [Display(Name = "Image")]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
