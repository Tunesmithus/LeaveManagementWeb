using LeaveManagementWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class EmployeeAllocationVM:EmployeeListVM
    {
        public List<LeaveAllocationVM>? LeaveAllocations { get; set; }

        
    }

}
