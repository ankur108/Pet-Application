using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paws_Pet_System
{
    
    public partial class Select : System.Web.UI.Page
    {
        
        protected void Germany_Click(object sender, EventArgs e)    //Image Button Event for Germany
        {
            Session["value"] = "Germany";                           //Storing the Value in value "Germany" through session for use in other web form
            Response.Redirect("~/form.aspx");                      //Redirecting the to form
        }
        protected void UK_Click(object sender, EventArgs e)         //Image Button Event for UK
        {
            Session["value"] = "UK";                               //Storing the Value in value "UK" through session for use in other web form
            Response.Redirect("~/form.aspx");                      //Redirecting the to form
        }
        protected void Romania_Click(object sender, EventArgs e)    //Image Button Event for Romania
        {
            Session["value"] = "Romania";                           //Storing the Value in value "Romania" through session for use in other web form
            Response.Redirect("~/form.aspx");                        //Redirecting the to form
        }
    }
}