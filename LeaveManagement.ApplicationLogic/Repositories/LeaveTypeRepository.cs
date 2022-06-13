using LeaveManagement.ApplicationLogic.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.ApplicationLogic.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
          
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
