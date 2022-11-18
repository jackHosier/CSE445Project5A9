using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


namespace A8
{
    public partial class _Default : Page
    {
        protected void Member_Page_Load(object sender, EventArgs e)
        {
            //need this for later 
            HttpCookie myCookies = Request.Cookies["LoginCookie"];
            DateTime now = DateTime.Now; 
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtMemberUsername.Text.Trim();
            string password = txtMemberPassword.Text.Trim();

            if(memberAuthenticate(userName, password))
            {
                FormsAuthentication.RedirectFromLoginPage(userName, Persistent.Checked);
            } else
            {
                lblMember.Text = "Invalid login"; 
            }
           

          
        }

        bool memberAuthenticate(string username, string password)
        {
            bool userExists = true; 

            string fLocation = Path.Combine(Request.PhysicalApplicationPath,
            @"App_Data\Member.xml");
            if (File.Exists(fLocation))
            {
                FileStream FS = new FileStream(fLocation, FileMode.Open);
                XmlDocument xd = new XmlDocument();
                xd.Load(FS);
                XmlNode node = xd;
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                {
                    // use SHA512 hash function to hash credentials

                    string hashedUserName = HashFunction.SHA512Sum(username);
                    string hashedPassword = HashFunction.SHA512Sum(password);

                    // check if the username and password exist in the XML file;
                    if (node["userName"].InnerText == hashedUserName)
                    {
                        if (node["password"].InnerText == hashedPassword)
                        {

                            //create cookie for user 
                            createMemberLoginCookie(username, password);

                            Response.Redirect("Member/Member.aspx"); //redirect to staff page 

                            userExists = true; 
                        } else
                        {
                            userExists = false; //user does not exist
                        }
                    } else
                    {
                        userExists = false; 
                    }

                }
            }

            return userExists; 
        }

        //create cookie function 
        public void createMemberLoginCookie(string userName, string password)
        {
            HttpCookie loginCookie = new HttpCookie("username", "password");

            //set cookie values 
            loginCookie.Values["username"] = userName;
            loginCookie.Values["password"] = password; 
            
            loginCookie.Expires = DateTime.Now.AddDays(5); //cookie expires in 5 days 

            loginCookie.Secure = true;   

            Response.Cookies.Add(loginCookie);
        }

        
    }
}
