using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFrameworkCommonLib
{
    public class AppContact
    {
        public string Address { get; set; }
        public string Site_URL { get; set; }

        public string Contact_No { get; set; }

        public AppContact()
        {
            Address = "";
            Site_URL = "";
            Contact_No = "";
        }
    }
}
