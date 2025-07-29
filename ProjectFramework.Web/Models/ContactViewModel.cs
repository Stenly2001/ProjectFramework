using System;

namespace ProjectFramework.Web.Models
{
    public class ContactViewModel : ViewModelBase
    {
        public BLL.ContactBLL ContactBLLObj = new BLL.ContactBLL();
        public string Address { get; set; }
        public string Site_URL { get; set; }
        public string Contact_No { get; set; }
        public string EnableMobAuth { get; set; }
        public bool IsChecked { get; set; }
        public ContactViewModel()
        {
            LoadSettings();
        }
        private void LoadSettings()
        {
            Address = ContactBLLObj.GetValue("Address");
            Site_URL = ContactBLLObj.GetValue("Site_URL");
            Contact_No = ContactBLLObj.GetValue("Contact_No");
            EnableMobAuth = ContactBLLObj.GetValue("EnableMobAuth");
            if (EnableMobAuth.ToLower() == "true")
            {
                IsChecked = true;
            }
            else
            {
                IsChecked = false;
            }
        }
        public bool UpdateSettings()
        {
            try
            {
                ContactBLLObj.SetValue("Address", Address);
                ContactBLLObj.SetValue("Site_URL", Site_URL);
                ContactBLLObj.SetValue("Contact_No", Contact_No);
                ContactBLLObj.SetValue("EnableMobAuth", EnableMobAuth);
                LoadSettings();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
