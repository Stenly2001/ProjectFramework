<%@ Page Title="Contact Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactSettings.aspx.cs" Inherits="ProjectFrameworkWeb.AdminPages.ContactSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="panel panel-primary">
      <div class="panel-heading"><h4>Update Contact Settings</h4></div>
      <div class="panel-body">

          <div class="form-group">
            <label for="TextBox_Address">Company Address</label>
                <asp:TextBox ID="TextBox_Address" class="form-control"  style="min-width: 100%;" runat="server" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxURL">Website Url</label>
                <asp:TextBox ID="TextBoxURL" class="form-control" style="min-width: 100%;" runat="server" Width="80%" TextMode="Url"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxContact_No">Contact No.</label>
                <asp:TextBox ID="TextBoxContact_No" class="form-control" style="min-width: 100%;" runat="server" TextMode="Number" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
              <asp:CheckBox ID="CheckEnableAPIAuth" runat="server" Text="Enable Authentication Check for Mobile API Calls" />
          </div>
          <div class="form-group">
              <asp:Button ID="ButtonUpdate" runat="server" Text="Update Contact" class="btn btn-primary" OnClick="ButtonUpdate_Click" />
              <asp:Button ID="ButtonBack" runat="server" Text="Back" class="btn btn-primary" OnClick="ButtonBack_Click" />
          </div>
          <div class="form-group">
              <asp:Label ID="LabelStatus" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
          </div>

      </div>
    </div>
</asp:Content>
