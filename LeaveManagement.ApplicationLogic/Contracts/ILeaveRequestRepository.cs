using LeaveManagement.Common.Models;
using LeaveManagement.ApplicationLogic.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.ApplicationLogic.Contracts
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task <bool>CreateLeaveRequest(LeaveRequestCreateVM request);

        Task <EmployeeLeaveRequestViewVM>GetMyLeaveDetails();
        Task <List<LeaveRequest>>GetAllAsync(string employeeId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task CancelLeaveRequest(int leaveRequestId);

       


    }
}
