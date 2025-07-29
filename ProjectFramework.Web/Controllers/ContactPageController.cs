using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.Models;

namespace ProjectFramework.Web.Controllers
{
    public class ContactPageController : AppControllerBase
    {
        public ContactViewModel ContactSettings = new ContactViewModel();
        public IActionResult Contact()
        {
            return View("~/Views/Admin/Contact.cshtml", ContactSettings);

        }

        private void SetAdminFlag()
        {
            string strUserID = HttpContext.Session.GetString("UserID");
            if (string.IsNullOrEmpty(strUserID))
            {
                ContactSettings.IsAdmin = false;
            }
            else
            {
                ContactSettings.IsAdmin = true;
            }
        }

        public IActionResult Settings()
        {
            SetAdminFlag();

            if (ContactSettings.IsAdmin)
            {
                return View("~/Views/Admin/Contact.cshtml", ContactSettings);

            }
            else
            {
                return RedirectToAction("Error", "Home");
            }

        }
        [HttpPost]
        public IActionResult Settings(string Address, string Site_URL, string Contact_No, string EnableMobAuth)
        {
            ContactSettings.Address = Address;
            ContactSettings.Site_URL = Site_URL;
            ContactSettings.Contact_No = Contact_No;
            if (!string.IsNullOrEmpty(EnableMobAuth) && EnableMobAuth.ToLower() == "true")
            {
                ContactSettings.EnableMobAuth = "true";
            }
            else
            {
                ContactSettings.EnableMobAuth = "false";
            }
            if (ContactSettings.UpdateSettings())
            {
                ContactSettings.StatusString = "Settings Updated Successfully";
            }
            else
            {
                ContactSettings.StatusString = "Settings Updation Failed";
            }
            SetAdminFlag();
            return View("~/Views/Admin/Contact.cshtml", ContactSettings);
        }
    }
}
