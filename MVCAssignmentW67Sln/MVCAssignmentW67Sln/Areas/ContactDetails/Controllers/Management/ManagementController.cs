using MVCAssignmentW67Sln.Areas.ContactDetails.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignmentW67Sln.Areas.ContactDetails.Controllers
{
    public class ManagementController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ContactDetailsViewModel contactDetailsViewModel = new ContactDetailsViewModel();
            contactDetailsViewModel.ContactDetails = new Models.ContactDetails()
                {
                    //CellPhone = new Models.Phone() {AreaCode = "082", CountryCode = "+27", PhoneNumber = "9991919"},
                    Email = "test@ds.com",
                    FirstName = "Steve",
                    //HomeAddress = new Models.Address() { City = "a", Country = "SA", Line1 = "12 West str", Line2 = "Houghton", Line3 = "JHB", PostalCode = "2195", Province = "GAUTENG"},
                    //HomePhone = new Models.Phone() {AreaCode = "082", CountryCode = "+27", PhoneNumber = "9991919"},
                    LastName = "Smuts"
                };
            contactDetailsViewModel.Address = new Models.Address() { City = "a", Country = "SA", Line1 = "12 West str", Line2 = "Houghton", Line3 = "JHB", PostalCode = "2195", Province = "GAUTENG"};
            contactDetailsViewModel.Phone = new Models.Phone() {AreaCode = "082", CountryCode = "+27", PhoneNumber = "9991919"};
            return View(contactDetailsViewModel);
        }        

        [HttpPost]
        public ActionResult Index(ContactDetails.Models.ContactDetails details)
        {
            return View(details);
        }

        ////[HttpPost]
        ////public ActionResult Index(string xml)
        ////{
        ////    ViewModels.ContactDetailsViewModel details = new ViewModels.ContactDetailsViewModel();
        ////    details = ViewModels.ContactDetailsViewModel.Deserialize(xml);

        ////    return View();
        ////}
    }
}
