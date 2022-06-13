using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class AdminLeaveRequestViewVM
    {
        [Display(Name = "Total Number of Request")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Request")]

        public int ApprovedRequest { get; set; }

        [Display(Name = "Pending Request")]

        public int PendingRequest { get; set; }

        [Display(Name = "Rejected Request")]

        public int RejectedRequest { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
