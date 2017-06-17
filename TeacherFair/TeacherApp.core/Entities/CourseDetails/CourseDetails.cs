using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.CourseDetails
{
    public class CourseDetails
    {

        public int StudentCourseId { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime CompleteDate { get; set; }

        public int CountryId { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
