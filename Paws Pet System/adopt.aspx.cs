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
    public partial class adopt : System.Web.UI.Page
    {
        SqlDataAdapter da = new SqlDataAdapter();                  // Creates an instance da of class SqlDataAdapter
        DataSet ds = new DataSet();                               //Creates an instance ds of class Dataset
        StringBuilder htmlTable = new StringBuilder();            //Creates an instance htmlTable of class StringBuilder
        public string total;                                    //String total to store the value of sql data
        int totalcost;                                         //totalcost for Total Animal Cost

        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }
        protected void button1_Click(object sender, EventArgs e)      //Creating a filter Button Event
        {
            string filtertype = filter.SelectedValue;                 //Selecting the Value of radio button
            if (Page.IsPostBack)                                     //Reloading the Page every time button is clicked
                BindData();                                          //Viewing the table by running the method BindData()
        }
        private void BindData() {

            SqlConnection con = new SqlConnection();                                     //Establishing the Coneection
            con.ConnectionString = @"Data Source=sql-server; 
            Persist Security Info=False; User ID=ac8441o;Password=!1SQLServer";          //Connecting Databse to the application
            con.Open();                                                                  //Opening the Connection
            string filtertype = filter.SelectedValue;                                    //Selecting the Value of radio button i.e. None here


            if (filtertype == "Breed")    //Chechking for Value of filtertype string to Breed
            {
                SqlCommand cmd1 = new SqlCommand("SELECT CustomerID,FirstName,LastName,Phone,Email,PetName,PetAge,PetGender,PetWeight,DateRescued,PetSpecies,PetBreed,Sanctuary,AnimalCost FROM UserData ORDER BY PetBreed;", con);  //SQL Command to Select Table from the Database and ordering by PetBreed
                da = new SqlDataAdapter(cmd1);
                cmd1.ExecuteNonQuery();      //Executing the Query
            }
            else if (filtertype == "Species")        //Chechking for Value of filtertype string to Species
            {
                SqlCommand cmd2 = new SqlCommand("SELECT CustomerID,FirstName,LastName,Phone,Email,PetName,PetAge,PetGender,PetWeight,DateRescued,PetSpecies,PetBreed,Sanctuary,AnimalCost FROM UserData ORDER BY PetSpecies;", con);   //SQL Command to Select Table from the Database and ordering by PetSpecies
                da = new SqlDataAdapter(cmd2);
                cmd2.ExecuteNonQuery();     //Executing the Query
            }
            else if (filtertype == "Sanctuary")      //Chechking for Value of filtertype string to Sanctuary
            {
                SqlCommand cmd3 = new SqlCommand("SELECT CustomerID,FirstName,LastName,Phone,Email,PetName,PetAge,PetGender,PetWeight,DateRescued,PetSpecies,PetBreed,Sanctuary,AnimalCost FROM UserData ORDER BY Sanctuary;", con);    //SQL Command to Select Table from the Database and ordering by Sanctuary
                da = new SqlDataAdapter(cmd3);
                cmd3.ExecuteNonQuery();         //Executing the Query
            }
            else
            {
                SqlCommand cmd3 = new SqlCommand("SELECT CustomerId,FirstName,LastName,Phone,Email,PetName,PetAge,PetGender,PetWeight,DateRescued,PetSpecies,PetBreed,Sanctuary,AnimalCost FROM UserData ORDER BY CustomerID;", con);  //SQL Command to Select Table from the Database and ordering by CustomerID
                da = new SqlDataAdapter(cmd3);
                cmd3.ExecuteNonQuery();             //Executing the Query
            }
            
            
            da.Fill(ds);
            con.Close();      //Closing the Connection

            htmlTable.Append("<table style='width:100%;'>");   //Setting the Table
            htmlTable.Append("<tr style='background-color:#4CAF50;font-size:15px; color: white; text-align: left;'><th>CustomerID</th><th>First Name</th><th>Last Name</th><th>Phone No.</th><th>Email</th><th>Pet Name</th><th>Pet Age</th><th>Pet Gender</th><th>Pet Weight</th>" +
                "<th>Date Rescued</th><th>Pet Species</th><th>Pet Breed</th><th>Sanctuary</th><th>Maintenance Cost</th></tr>");  //Setting Table heading 

            /*Appending the Data from the Databse*/
            if (!object.Equals(ds.Tables[0], null))
            {
                if (ds.Tables[0].Rows.Count > 0)                            //Storing the Data value of each rows and column
                {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)           //Loop for accessing the Data
                    {
                        htmlTable.Append("<tr style='color: BLACK;'>");
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["CustomerID"] + "</td>"); //Appending CustomerID
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["FirstName"] + "</td>");   //Appending FirstName
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["LastName"] + "</td>");    //Appending LastName
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["Phone"] + "</td>");       //Appending Phone
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["Email"] + "</td>");       //Appending Email
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetName"] + "</td>");     //Appending PetNameD
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetAge"] + "</td>");      //Appending PetAge
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetGender"] + "</td>");      //Appending PetGender
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetWeight"] + "</td>");       //Appending PetWeight
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["DateRescued"] + "</td>");     //Appending DateRescue
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetSpecies"] + "</td>");      //Appending PetSpecies
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["PetBreed"] + "</td>");        //Appending PetBreed
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["Sanctuary"] + "</td>");      //Appending Sanctuary
                        htmlTable.Append("<td style='padding: 15px;text - align: left;'>" + ds.Tables[0].Rows[i]["AnimalCost"] + "</td>");     //Appending AnimalCost
                        total = (ds.Tables[0].Rows[i]["AnimalCost"]).ToString();  //Store the value to string for each pet
                        totalcost += int.Parse(total);                            //Sum up animal maintainance for each pet
                        htmlTable.Append("</tr>");

                    }
                    htmlTable.Append("</table>");
                    Label1.Text = "The Total Animal Maintainance Cost is=" + totalcost;
                    PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });   //Sending Data to HTML table to view Data
                }
                else
                {
                    htmlTable.Append("<tr>");
                    htmlTable.Append("<td align='center' colspan='4'>There is no Record.</td>");   //If No Record is present, error message
                    htmlTable.Append("</tr>");
                }
            }
        }
    }
}