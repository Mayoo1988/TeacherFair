using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserLoginTrail
{
   public class UserLoginTrail
    {
        public int UserId { get; set; }

        public string IpAddress { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public DateTime LoginDatetime { get; set; }

      

    }
}
