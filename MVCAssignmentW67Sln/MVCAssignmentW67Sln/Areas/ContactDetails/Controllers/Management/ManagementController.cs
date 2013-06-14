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
            //populate contact model
            ContactDetails.Models.ContactDetails contact = new Models.ContactDetails();
            contact.CellPhone = new Models.Phone()
            {
                AreaCode = "011",
                CountryCode = "ZAR",
                PhoneNumber = "011"
            };
            contact.Email = "dsa@dsa.com";
            contact.FirstName = "ddd";
            contact.HomeAddress = new Models.Address()
            {
                City = "Houghton",
                Country = "ZA",
                Line1 = "44 west ave",
                Line2 = "test line 2",
                Line3 = "test line 3",
                PostalCode = "2222",
                Province = "GAUTENG"
            };
            contact.HomePhone = new Models.Phone()
            {
                AreaCode = "011",
                CountryCode = "+27",
                PhoneNumber = "8889999"
            };
            contact.LastName = "Aglioti";


            //populate viewmodel from model
            ContactDetailsViewModel vm = new ContactDetailsViewModel()
            {
                CellAreaCode = contact.CellPhone.AreaCode,
                CellCountryCode = contact.CellPhone.CountryCode,
                CellPhoneNumber = contact.CellPhone.PhoneNumber,

                HomeAreaCode = contact.HomePhone.AreaCode,
                HomeCountryCode = contact.HomePhone.CountryCode,
                HomePhoneNumber = contact.HomePhone.PhoneNumber,

                Email = contact.Email,
                FirstName = contact.FirstName,

                HomeCity = contact.HomeAddress.City,
                HomeCountry = contact.HomeAddress.Country,
                HomeLine1 = contact.HomeAddress.Line1,
                HomeLine2 = contact.HomeAddress.Line2,
                HomeLine3 = contact.HomeAddress.Line3,
                HomePostalCode = contact.HomeAddress.PostalCode,
                HomeProvince = contact.HomeAddress.Province,

                LastName = contact.LastName
            };

            return View(vm);
        }


        [HttpPost]
        public ActionResult Index(ContactDetailsViewModel details)
        {
            // map back to Model
            Models.ContactDetails contact = new Models.ContactDetails();
            contact.CellPhone = new Models.Phone()
            {
                AreaCode = details.CellAreaCode,
                CountryCode = details.CellCountryCode,
                PhoneNumber = details.CellPhoneNumber
            };
            contact.Email = details.Email;
            contact.FirstName = details.FirstName;
            contact.HomeAddress = new Models.Address()
            {
                City = details.HomeCity,
                Country = details.HomeCountry,
                Line1 = details.HomeLine1,
                Line2 = details.HomeLine2,
                Line3 = details.HomeLine3,
                PostalCode = details.HomePostalCode,
                Province = details.HomeProvince
            };
            contact.HomePhone = new Models.Phone()
            {
                AreaCode = details.HomeAreaCode,
                CountryCode = details.HomeCountryCode,
                PhoneNumber = details.HomePhoneNumber
            };
            contact.LastName = details.LastName;
            return RedirectToAction("ViewDetails", "Management", details);
        }

        [HttpGet]
        public ActionResult ViewDetails(ContactDetailsViewModel details)
        {
            return View(details);
        }

    }
}
