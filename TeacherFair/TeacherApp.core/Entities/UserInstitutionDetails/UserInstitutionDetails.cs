using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserInstitutionDetails
{
   public class UserInstitutionDetails
    {
        public int InstitutionId { get; set; }

        public string InstitutionName { get; set; }

        public int UserId { get; set; }

        public int ClassId { get; set; }

        public int BoardId { get; set; }

        public int PassingYear { get; set; }

        public int GradePercent { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
