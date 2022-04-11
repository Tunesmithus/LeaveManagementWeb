using LeaveManagementWeb.Data.Migrations;

namespace LeaveManagementWeb.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }


    }
}
