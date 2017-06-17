using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserParentsDetails
{
  public class UserParentDetails
    {
        public int ParentId { get; set; }

        public int UserId { get; set; }

        public string FatherName { get; set; }

        public string FatherEmail { get; set; }

        public string FatherMobileNumber { get; set; }

        public string FatherOccupation { get; set; }

        public string FatherCompanyName { get; set; }

        public string FatherDeignation { get; set; }

        public string MotherName { get; set; }

        public string MotherEmail { get; set; }

        public string MotherMobileNumber { get; set; }

        public string MotherOccupation { get; set; }

        public string MotherCompanyName { get; set; }

        public string MotherDeignation { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
