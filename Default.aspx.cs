using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml; 

namespace A8
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //if user is not currently logged in, redirect to the login page 
        }

        protected void NewMemberBtn_Click(object sender, EventArgs e)
        {
            //link to member registration page 
            Response.Redirect("Member/MemberReg.aspx"); 
        }

        protected void MemberSignInBtn_Click(object sender, EventArgs e)
        {
            //link to member signin page
            Response.Redirect("Member/MemberLogin.aspx"); 

        }

        protected void StaffSignInBtn_Click(object sender, EventArgs e)
        {
            //link to staff signin page 
            Response.Redirect("Login.aspx"); 

        }

        protected void MemberBtn_Click(object sender, EventArgs e)
        {
            //link to the member page 
            Response.Redirect("Member/Member.aspx"); 
        }

        protected void StaffBtn_Click(object sender, EventArgs e)
        {
            //link to staff page 
            Response.Redirect("Staff/Staff.aspx"); 
        }
    }
}