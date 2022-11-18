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
           //load up the image verifier  
        }

        protected void RegisterUserBtn_Click(object sender, EventArgs e)
        {

            string username = newUserNameBox.Text; 
            string password = newPasswordBox.Text;

            //encrypt the login info 
            string hashedUsername = HashFunction.SHA512Sum(username); 
            string hashedPassword = HashFunction.SHA512Sum(password);   


            //load up the XML Document 
            
            string filePath = HttpRuntime.AppDomainAppPath + @"\Account\App_Data\Members.xml";

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(filePath);   

            XmlElement root = xmlDoc.DocumentElement;

            //check if the user already exists 

            foreach(XmlNode node in root.ChildNodes)
            {
                if (node["user"].InnerText == hashedUsername)
                {
                    StatusLbl.Text = String.Format("*Sorry, Account with user name {0} already exists.", username); 
                    return; 
                } else
                {
                    XmlElement newMember = xmlDoc.CreateElement("member", root.NamespaceURI);
                    root.AppendChild(newMember);

                    XmlElement newUser = xmlDoc.CreateElement("user", root.NamespaceURI);
                    newUser.InnerText = hashedUsername;
                    xmlDoc.AppendChild(newMember);

                    XmlElement newPassword = xmlDoc.CreateElement("password", root.NamespaceURI);   
                    newPassword.InnerText = hashedPassword;
                    xmlDoc.AppendChild(newPassword);

                    xmlDoc.Save(filePath); 
                }
            }
        }

       
    }
}