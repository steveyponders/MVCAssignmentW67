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
            contactDetailsViewModel.ContactDetails = new Models.ContactDetails();
            contactDetailsViewModel.Address = new Models.Address();
            contactDetailsViewModel.Phone = new Models.Phone();
            return View(contactDetailsViewModel);
        }        

        [HttpPost]
        public ActionResult Index(ContactDetails.Models.ContactDetails details)
        {
            return View(details);
        }        
    }
}
