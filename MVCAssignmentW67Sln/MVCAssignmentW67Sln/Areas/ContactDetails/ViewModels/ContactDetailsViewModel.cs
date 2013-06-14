using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MVCAssignmentW67Sln.Areas.ContactDetails.ViewModels
{
    public class ContactDetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //phone
        public string CellAreaCode { get; set; }
        public string CellPhoneNumber { get; set; }
        public string CellCountryCode { get; set; }

        //phone
        public string HomeAreaCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string HomeCountryCode { get; set; }

        //Address
        public string HomeLine1 { get; set; }
        public string HomeLine2 { get; set; }
        public string HomeLine3 { get; set; }
        public string HomeCity { get; set; }
        public string HomeProvince { get; set; }
        public string HomeCountry { get; set; }
        public string HomePostalCode { get; set; }
    }
}
