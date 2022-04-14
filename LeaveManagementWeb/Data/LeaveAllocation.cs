using LeaveManagementWeb.Data.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation: BaseEntity
    {

        public string Name { get; set; }

        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public string? EmployeeId { get; set; }

       
    }
}
