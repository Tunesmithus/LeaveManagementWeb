using LeaveManagement.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        [Display (Name = "Number of Days")]
        public int  NumberOfDays { get; set; }

        [Required]
        [Display(Name ="Allocation Period")]
        public int Period { get; set; }

        public LeaveTypeVM? LeaveType { get; set; }

    }
}