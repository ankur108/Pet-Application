using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Paws_Pet_System
{
    public partial class Remove : System.Web.UI.Page
    {
        SqlDataAdapter da = new SqlDataAdapter();               // Creates an instance da of class SqlDataAdapter
        DataSet ds = new DataSet();                             //Creates an instance ds of class Dataset
        StringBuilder htmlTable = new StringBuilder();          //Creates an instance htmlTable of class StringBuilder

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void button1_Click(object sender, EventArgs e)   //Creating a remove Button Event
        {
            SqlConnection con = new SqlConnection();    //Initialisation of Connection
            con.ConnectionString = @"Data Source=sql-server; 
            Persist Security Info=False; User ID=ac8441o;Password=!1SQLServer";    //Connecting the SQL Server to the Application
            con.Open();                    //Opeing the Connection
            string removepet = remove.Text;                 //Taking the Value of CustomeRID
            SqlCommand cmmd = new SqlCommand("DELETE FROM UserData WHERE CustomerID =" + removepet, con);
            cmmd.ExecuteNonQuery();
            con.Close();
            if (Page.IsPostBack)
                BindData();
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=sql-server; 
            Persist Security Info=False; User ID=ac8441o;Password=!1SQLServer";               //Connecting the SQL Server to the Application
            SqlCommand cmd = new SqlCommand("SELECT CustomerID,FirstName,LastName,Phone,Email,PetName,PetAge,PetGender,PetWeight,DateRescued,PetSpecies,PetBreed,Sanctuary,AnimalCost FROM UserData ORDER BY CustomerID;", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();                            //Opeing the Connection
            cmd.ExecuteNonQuery();                  //Executing the Query
            string removepet = remove.Text;                        //Taking the Value of CustomeRID
            SqlCommand cmmd = new SqlCommand("DELETE FROM UserData WHERE CustomerID ="+ removepet, con);   //Paasing the SQL Command to the Command String
            con.Close();  //Closing thE Connection

            htmlTable.Append("<table style='width: 120%;'>"); //Setting the Table
            htmlTable.Append("<tr style='background-color:#4CAF50;font-size:15px; color: white; text-align: left; '><th>CustomerID</th><th>First Name</th><th>Last Name</th><th>Phone No.</th><th>Email</th><th>Pet Name</th><th>Pet Age</th><th>Pet Gender</th><th>Pet Weight</th>" +
                "<th>Date Rescued</th><th>Pet Species</th><th>Pet Breed</th><th>Sanctuary</th><th>Maintenance Cost</th></tr>");

            /*Appending the Data from the Databse*/
            if (!object.Equals(ds.Tables[0], null))
            {
                if (ds.Tables[0].Rows.Count > 0)              //Storing the Data value of each rows and column
                {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)    //Loop for accessing the Data
                    {
                        htmlTable.Append("<tr style='color: BLACK;'>");
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["CustomerID"] + "</td>");  //Appending CustomerID
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["FirstName"] + "</td>");   //Appending FirstName
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["LastName"] + "</td>");    //Appending LastName
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["Phone"] + "</td>");       //Appending Phone
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["Email"] + "</td>");       //Appending Email
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetName"] + "</td>");     //Appending PetName
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetAge"] + "</td>");      //Appending PetAge
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetGender"] + "</td>");   //Appending PerGender
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetWeight"] + "</td>");   //Appending PetWeight
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["DateRescued"] + "</td>"); //Appending DateRescued
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetSpecies"] + "</td>");  //Appending PetSpecies
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetBreed"] + "</td>");    //Appending PetBreed
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["Sanctuary"] + "</td>");    //Appending Sanctuary
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["AnimalCost"] + "</td>");   //Appending Animal Cost
                        htmlTable.Append("</tr>");
                    }
                         htmlTable.Append("</table>");
                    PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });     //Sending Data to HTML table to view Data
                }
                else
                {
                    htmlTable.Append("<tr>");
                    htmlTable.Append("<td align='center' colspan='4'>There is no Record.</td>");             //If No Record is present, error message
                    htmlTable.Append("</tr>");
                }
            }

        }

        
    }
}