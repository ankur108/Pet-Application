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
    public partial class Login : Page
    {
          SqlCommand comm = new SqlCommand();                //Creates an instance comm of class SqlCommand
        SqlConnection connect = new SqlConnection();         //Starting a connection by creating an instance of the Class
          SqlDataAdapter data = new SqlDataAdapter();        // Creates an instance of class SqlDataAdapter
          DataSet dataset = new DataSet();                   //Creates an instance comm of class SqlCommand

        
        protected void Page_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = (@"Data Source=sql-server; 
            Persist Security Info=False; User ID=ac8441o;Password=!1SQLServer");          //Connecting SQL Server to the application
            connect.Open();                                                             //Opening the Connection
        }
                
        protected void Logins_Click(object sender, EventArgs e)                           //Creating a Button Event
        {
            connect.Close();                                                              //Closing the Connection
            comm.CommandText = "select * from login where username='" + user.Text + "'AND password='" + pass.Text +"'";   //Passing the SQL Command to Command text
            comm.Connection = connect;                                                                                    //Initialization of String
            data.SelectCommand = comm;
            data.Fill(dataset, "login");                                                                                 //Paasing the Values of Table login in dataset
            if (dataset.Tables[0].Rows.Count > 0)                                                                        //Checking the Value of Data in Login
             {

                 Response.Redirect("~/Select.aspx");  //Redirect page to Select after successful login
             }
            else
            {
                Label2.Text = "Invalid Username/Password";                 //Display an Error message
            }
            
        }
        protected void Create_Click(object sender, EventArgs e)                 //Creating a Create new User button event
        {
            
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO LOGIN VALUES('" +newuser.Text+ "','" + newpass.Text + "','" + email.Text + "')";    //Inserting the Values of user to store in Login Database
            comm.Connection = connect;                                                                          //Initialization of Connection
            if(comm.ExecuteNonQuery()==1)                                                              //Executing the Query and check whether the query has occured or not
            {
                Label3.Text = "Welcome to Paw Pet Store";                                            //Display message for successful Account Creation
            }
            connect.Close();                                                                            //Closing the Connection
        }



    }
}