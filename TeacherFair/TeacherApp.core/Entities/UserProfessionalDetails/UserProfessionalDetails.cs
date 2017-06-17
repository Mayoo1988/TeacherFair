using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserProfessionalDetails
{
   public class UserProfessionalDetails
    {

        public int ProfessionalDetailId { get; set; }

        public int UserId { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        public string EmployeeType { get; set; }

        public string Remarks { get; set; }

      
        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
