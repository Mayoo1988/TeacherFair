using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp.core.Entities.AddressDetails
{
    public class AddressDetails
    {
        public int AddresDetailId { get; set; }

        public int UserId { get; set; }

        public int AddressTypeId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        public int CountryId { get; set; }

        public string PinCode { get; set; }

        public int Status { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
