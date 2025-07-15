using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using ProjectFrameworkCommonLib;
using ProjectFrameworkWeb.BLL;

namespace ProjectFrameworkWeb.API
{
    public class ContactController : TokenCheckController
    {
        private ContactBLL ContactBLLObj = new ContactBLL();

        [HttpGet]
        public HttpResponseMessage GetContactInfo()
        {
            try
            {
                AppContact Setting = new AppContact();
                Setting.Address = ContactBLLObj.GetValue("Address");
                Setting.Site_URL = ContactBLLObj.GetValue("Site_URL");
                Setting.Contact_No = ContactBLLObj.GetValue("Contact_No");
                var message = Request.CreateResponse(HttpStatusCode.OK, Setting);
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }

        }
        [HttpGet]
        public HttpResponseMessage GetContactInfoEx(string Key)
        {
            try
            {
                string Value = ContactBLLObj.GetValue(Key);
                var message = Request.CreateResponse(HttpStatusCode.OK, Value);
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }

        }
        public HttpResponseMessage UpdateContactInfo(AppSettings Settings)
        {
            try
            {
                ContactBLLObj.SetValue("AppName", Settings.AppName);
                ContactBLLObj.SetValue("MainHeading", Settings.MainHeading);
                ContactBLLObj.SetValue("MainDesc", Settings.MainDesc);
                var message = Request.CreateResponse(HttpStatusCode.OK, "Settings Updated Successfully");
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }

        }

    }

   
}