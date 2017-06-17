using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserLoginDetails
{
    public class UserLoginDetails
    {
        public int UserId { get; set; }

        public string LoginEmail { get; set; }

        public string LoginMobile { get; set; }

        public string Password { get; set; }

        public int StatusId { get; set; }

        public int UserTypeId { get; set; }

        public int PasswordRetryCount { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
