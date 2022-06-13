namespace LeaveManagement.Common.Models
{
    public class EmployeeLeaveRequestViewVM
    {

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }

        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> allocations, List<LeaveRequestVM> requests )
        {
            LeaveAllocations = allocations;
            LeaveRequests = requests; 
        }


    }
}
