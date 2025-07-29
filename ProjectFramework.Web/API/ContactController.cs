using Microsoft.AspNetCore.Mvc;
using ProjectFrameworkCommonLib;
using System;

namespace ProjectFramework.Web.API
{
    public class ContactController : Controller
    {
        [Route("GetContactInfo")]
        [HttpGet]
        public ActionResult GetContactInfo()
        {
            try
            {
                AppContact Contact = new AppContact();
                Contact.Address = "Alappuzha | Kerala | India";
                Contact.Site_URL = "https://www.google.com";
                Contact.Contact_No = "7900192017";
                return Ok(Contact); ;
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
        [Route("GetContactInfoEx")]
        [HttpGet]
        public ActionResult GetContactInfoEx(string Key)
        {
            try
            {
                string Value = "Key Value";

                return Ok(Value);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
        [Route("UpdateContactInfo")]
        [HttpPost]
        public ActionResult UpdateContactInfo(AppSettings Settings)
        {
            try
            {
                return Ok("Settings Updated Successfully");
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
    }
}
