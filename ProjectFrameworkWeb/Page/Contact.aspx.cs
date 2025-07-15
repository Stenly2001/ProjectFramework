using ProjectFrameworkWeb.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFrameworkWeb
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPageData();
            }

        }
        public void LoadPageData()
        {
            ContactBLL ContactInfo = new ContactBLL();
            LabelAddress.Text = ContactInfo.GetValue("Address");
            LabelSite_URL.Text = ContactInfo.GetValue("Site_URL");
            LabelContact_No.Text = ContactInfo.GetValue("Contact_No");

        }
    }
}