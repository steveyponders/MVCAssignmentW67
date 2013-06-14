using System.Web.Mvc;

namespace MVCAssignmentW67Sln.Areas.ContactDetails
{
    public class ContactDetailsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ContactDetails";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ContactDetails_default",
                "ContactDetails/{controller}/{action}/{id}",
                new { controller = "Management", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"MVCAssignmentW67Sln.Areas.ContactDetails.Controllers"}
            );
        }
    }
}
