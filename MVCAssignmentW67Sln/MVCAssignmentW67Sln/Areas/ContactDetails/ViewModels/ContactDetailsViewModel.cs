using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentW67Sln.Areas.ContactDetails.ViewModels
{
    public class ContactDetailsViewModel
    {
        public MVCAssignmentW67Sln.Areas.ContactDetails.Models.ContactDetails ContactDetails { get; set; }

        public MVCAssignmentW67Sln.Areas.ContactDetails.Models.Address Address { get; set; }

        public MVCAssignmentW67Sln.Areas.ContactDetails.Models.Phone Phone { get; set; }
    }
}
