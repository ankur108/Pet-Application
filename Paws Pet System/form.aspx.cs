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
    public partial class form : Page
    {
        SqlCommand comm = new SqlCommand();                 //Creates an instance comm of class SqlCommand
        SqlConnection connect = new SqlConnection();        //Creates an instance connect of class SqlConnection
        SqlDataAdapter data = new SqlDataAdapter();         //Creates an instance data of class SqlDataAdapter
        DataSet dataset = new DataSet();                    //Creates an instance dataset of class Dataset
        public float animalcost;                           //Declaring the variable animal cost with Public Access level
       


        protected void Page_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = (@"Data Source=sql-server;                 
            Persist Security Info=False; User ID=ac8441o;Password=!1SQLServer");  //Connecting SQL Server to the application
            connect.Open();


        }
        public void Submit_Click(object sender, EventArgs e)                     // Submit Button Event
        {
            

            string sanctuary = Session["value"].ToString();                      //Getting the value of sanctuary using session from Select Page
            try
            {
                
                animalcost = (float.Parse(foodcost.Text) * float.Parse(petweight.Text)) + float.Parse(housingcost.Text) + float.Parse(vaccine.Text) + float.Parse(neuter.Text) + float.Parse(chip.Text) + float.Parse(flea.Text) + float.Parse(pills.Text);
                //Calculating the total animal cost
            }
            catch (Exception ex)
            {

            }
            

            string imagename = firstname.Text;   //Getting the Value of firstname textbox

            string FileExtension = System.IO.Path.GetExtension(petphoto.PostedFile.FileName);
            string Folder = Server.MapPath(".\\") + "Images\\";                  //setting the path of the image
            string Filename = imagename;                                         //The image will be unique              
            petphoto.SaveAs(Folder + Filename + FileExtension);                 //Saving Photo

            

            comm.Connection = connect;                                //Initialisation the connection
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO UserData(FirstName,LastName,Phone,Email,PetName,PetAge,PetGender,PetWeight,DateRescued,PetPhoto,PetSpecies,PetBreed,Sanctuary,Petfood,Pethousing,petvaccine,petneutering,petchip,petflea,petpills,animalcost) VALUES('" 
                    + firstname.Text + "','" + lastname.Text + "','" + phone.Text + "','" + emailid.Text + "','" + petname.Text + "','" + petage.Text + "','" + petgender.Text + "','" + petweight.Text + "'" +
                        ",'" + petrescued.Text + "','" + Filename + FileExtension + "','" + petspecies.Text + "','" + petbreed.Text + "','" + sanctuary + "','" + foodcost.Text + "','" + housingcost.Text + "','" + vaccine.Text + "','" + neuter.Text + "','" + chip.Text + "'" +
                        ",'" + flea.Text + "','" + pills.Text + "','" + animalcost + "')";
                   //Passing the SQL Command
                    if (comm.ExecuteNonQuery() == 1)     //Executing the Query
                    {
                        Label15.Text = "Information Saved in the Database"; //Output Message when the information is saved
                   
                    }
                    connect.Close();            //Closing the coonection
                }
            }
        

        
    }
