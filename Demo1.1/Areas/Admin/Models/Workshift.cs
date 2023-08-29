using System.ComponentModel.DataAnnotations;

namespace Demo1._1.Areas.Admin.Models
{
    public class Workshift
    {
        [Key]
        public int WorkshiftId { get; set; }
        public string? ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
    }
}
