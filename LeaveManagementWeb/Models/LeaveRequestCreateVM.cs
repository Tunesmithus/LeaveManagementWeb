using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM: IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Leave Type")]

        [Required]
        public int LeaveTypeId { get; set; }

        public string? EmployeeId { get; set; }

        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must Be Before End Date", 
                    new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
