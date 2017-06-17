using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserDetails
{
   public class UserDetails
    {
        public int PersonalDetailsId { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string MotherName { get; set; }

        public string FatherName { get; set; }

        public string Disability { get; set; }

        public string EnrollmentId { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }
    }
}
