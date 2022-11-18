using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A8
{
    public partial class _Member : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //load the services 

        }

        /*
         * ----------------------- ADD ALL SERVICES HERE ----------------------
         */ 
        protected void WordCountBtn_Click(object sender, EventArgs e)
        {
            string file = WordCountBox.Text; 

            //call the service 

            


        }

        protected void Top10Btn_Click(object sender, EventArgs e)
        {
            string file = Top10Box.Text;    

            //call the service 
        }

        protected void SendMessageBtn_Click(object sender, EventArgs e)
        {
            string Sender = SenderBox.Text;
            string reciever = RecieverBox.Text;
            string message = MessageBox.Text; 


        }

        /*
         * ADD ADDITIONAL SERVICES HERE
         */ 
       
    }
}