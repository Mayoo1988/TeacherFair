using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserSubjects
{
    public class UserSubjects
    {

        public int UserSubjectId { get; set; }

        public int SubjectId { get; set; }

        public int UserId { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
