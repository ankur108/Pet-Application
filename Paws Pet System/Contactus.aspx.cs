using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Paws_Pet_System
{
    public partial class Contactus : System.Web.UI.Page
    {
        SqlCommand comm = new SqlCommand();              //Creating an instance comm of SqlCommand
        SqlConnection connect = new SqlConnection();     //Creates a Connection to connect Database
        SqlDataAdapter data = new SqlDataAdapter();      //Creating an instance data of SqlDataAdapter
        DataSet dataset = new DataSet();                //Creating an instance dataset of DataSet

        protected void Page_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = (@"Data Source=sql-server; 
            Persist Security Info=False; User ID=ac8441o;Password=!1SQLServer");      //Establish a Connection String to connect Database to application
            connect.Open();                                                           //Opens the connection
        }
            public void Contact_Click(object sender, EventArgs e)                    //Creates a Button Event
            {
           
            comm.CommandType = CommandType.Text;                                    
            comm.CommandText = "INSERT INTO ContactData(Name,Email,Comment) VALUES('" + name.Text + "','" + email.Text + "','" + comment.Text + "')";   //Passing the query to Add databse to the table
            comm.Connection = connect;               //Initialising the connection
            
            if (comm.ExecuteNonQuery() == 1)         //Checking whether execution has Occurred
            {
                Label10.Text = "Thank you for your interest, We will be in touch";
            }
            connect.Close();                        //Closes the Connection

        }
        
    }
}