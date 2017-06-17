using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.UserDocumentDetails
{
    public class UserDocumentDetails
    {
        public int UserDocumentId { get; set; }

        public int DocumenttypeId { get; set; }

        public string DocumentName { get; set; }

        public int UserId { get; set; }

        public int Status { get; set; }


        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
