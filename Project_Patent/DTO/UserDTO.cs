using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Patent
{


    public class UserDTO
    {
        public string UserID { get; set; }
        public string UserPW { get; set; }
        public string UserName { get; set; }
        public string UserAddr1 { get; set; }
        public string UserAddr2 { get; set; }
        public string UserAddr3 { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPW { get; set; }
        public string ManagerRankCode { get; set; }
        public string ManagerPhone { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string LoginedUser { get; set; }
        public string LoginedUserRank { get; set; }
        

        public List<EmployeeDTO> Employeeslist { get; set; }
        public List<ReportDTO> Reportlist { get; set; }

    }
}
