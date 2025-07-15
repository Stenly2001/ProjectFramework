using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectFrameworkWeb.BLL;


namespace ProjectFrameworkWeb.AdminPages
{
    public partial class ContactSettings : BasePage
    {
        private ContactBLL ContactBLLObj = new ContactBLL();

        protected new void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Load the Data
                TextBox_Address.Text = ContactBLLObj.GetValue("Address");
                TextBoxURL.Text = ContactBLLObj.GetValue("Site_URL");
                TextBoxContact_No.Text = ContactBLLObj.GetValue("Contact_No");
                string Result = ContactBLLObj.GetValue("EnableMobAuth");
                if (Result.ToLower() == "true")
                {
                    CheckEnableAPIAuth.Checked = true;
                }
                else
                {
                    CheckEnableAPIAuth.Checked = false;
                }

            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ContactBLLObj.SetValue("Address", TextBox_Address.Text);
                ContactBLLObj.SetValue("Site_URL", TextBoxURL.Text);
                ContactBLLObj.SetValue("Contact_No", TextBoxContact_No.Text);
                ContactBLLObj.SetValue("EnableMobAuth", CheckEnableAPIAuth.Checked.ToString());
                ContactBLL.SetAuthToken(CheckEnableAPIAuth.Checked);
                LabelStatus.Text = "Settings Updated Successfully...";
            }
            catch (Exception Ex)
            {
                LabelStatus.Text = Ex.Message;
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AdminSettings");
        }
    }
}