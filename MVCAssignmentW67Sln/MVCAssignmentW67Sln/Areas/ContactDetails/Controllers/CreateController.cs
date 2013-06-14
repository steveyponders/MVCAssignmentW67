using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignmentW67Sln.Areas.ContactDetails.Controllers
{
    public class CreateController : Controller
    {
        //
        // GET: /ContactDetails/Create/

        public ActionResult Index(string xml)
        {
            ViewModels.ContactDetailsViewModel details = new ViewModels.ContactDetailsViewModel();
            details = ViewModels.ContactDetailsViewModel.Deserialize(xml);

            return View();
        }

    }
}
