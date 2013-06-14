using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MVCAssignmentW67Sln.Areas.ContactDetails.ViewModels
{
    public class ContactDetailsViewModel
    {
        public MVCAssignmentW67Sln.Areas.ContactDetails.Models.ContactDetails ContactDetails { get; set; }

        public MVCAssignmentW67Sln.Areas.ContactDetails.Models.Address Address { get; set; }

        public MVCAssignmentW67Sln.Areas.ContactDetails.Models.Phone Phone { get; set; }

        // This will convert the passed XYZ object to JSON string
        public static string Serialize(ContactDetailsViewModel xyz)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(xyz);
        }

        // This will convert the passed JSON string back to XYZ object
        public static ContactDetailsViewModel Deserialize(string data)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<ContactDetailsViewModel>(data);
        }
    }
}
