using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MoviesAssessment
{
    class Database
    {

        //Create Connection, Command and an Adapter
        SqlConnection Connection = new SqlConnection();
        SqlCommand Command = new SqlCommand();
        SqlDataAdapter DataAD = new SqlDataAdapter();

        public Database()
        {
           ConnectToDB(); 
        }

        

        private void ConnectToDB()
        {
            //Connection string to DB
            string connectionstring = @"Data Source=DESKTOP-KIO7TVU\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";

            Connection.ConnectionString = connectionstring;
            Command.Connection = Connection;
        }

        public void ClearAllTextBoxes(Control root)
        {
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
            }
        }

        //=======================_Movies_Related_==========================

        public DataTable FillDGVMoviesWithMovies()
        {
            //Create a datatable --> Movies 
            DataTable dtMovies = new DataTable();

            using (DataAD = new SqlDataAdapter("SELECT MovieID, Title, Year, Rating, Genre, Plot FROM Movies", Connection))
            {
                //Open a connection to the DB
                Connection.Open();
                //Fill the datatable from the SQL
                DataAD.Fill(dtMovies);
                //Close the connection
                Connection.Close();
            }

            //Passes the datatable to the DataGridView
            return dtMovies;

        }

        public string InsertOrUpdateMovie(string Title, string Year, string Rating, string Genre, string Plot, string ID,
            string AddOrUpdate)
        {
            try
            {
                if (AddOrUpdate == "Add")
                {
                    //Creates a Command object, a Query and opens a connection to SQL Server
                    var myCommand = new SqlCommand("INSERT INTO Movies (Title, Year, Rating, Genre, Plot)" + "VALUES(@Title, @Year, @Rating, @Genre, @Plot, )", Connection);

                    //Parameters preventing SQL injections
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Title);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                   

                    //Opens connection to add in SQL and closes
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies set Title = @Title, Year = @Year, Rating = @Rating, Genre = @Genre, Plot = @Plot  WHERE MovieID = @ID ", Connection);

                    //Parameters preventing SQL injections
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("ID", ID);

                    //Opens connection to add in SQL and closes
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return "successfully";
            }
            catch (Exception e)
            {
                // Closes a second time as it jumps the first connection.close when ExecuteNonQuery fails
                Connection.Close();

                return " Has Failed with " + e;
            }
        }

        public string DeleteMovie(string ID, string Table)
        {
            //Only runs if there is something in the textbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {
                    case "Movie":
                        myCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID = @ID");
                        break;
                }

                //Parameters to prevent SQL injections
                myCommand.Connection = Connection;
                myCommand.Parameters.AddWithValue("ID", ID);

                //Opens a connection to add in SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return "Successfully";
            }
            else
            {
                Connection.Close();
                return "Failed";
            }
        }
        
        //=======================_Customer_Related_==========================

        public DataTable FillDGVCustomersWithCustomers()
        {
            //Create a datatable --> Customers
            DataTable dtCustomers = new DataTable();

            using (DataAD = new SqlDataAdapter("SELECT CustID, FirstName, LastName, Address, Phone From Customer", Connection))
            {
                //Open a connection to the DB
                Connection.Open();
                //Fill the datatable from the SQL
                DataAD.Fill(dtCustomers);
                //Close the connection
                Connection.Close();
            }
            //Passes the datatable to the DataGridView
            return dtCustomers;
        }

        public string InsertOrUpdateCustomer(string Firstname, string Lastname, string Address, string Phone, string ID, string AddOrUpdate)
        {
            try
            {
                if (AddOrUpdate == "Add")
                {
                   //Creates a Command object, a Query and opens a connection to SQL Server
                    var myCommand = new SqlCommand("INSERT INTO Customer (FirstName, LastName, Address, Phone)" + "VALUES(@Firstname, @Lastname, @Address, @Phone)", Connection);

                    //Parameters preventing SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);

                    //Opens connection to add in SQL and closes connection
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Customer set FirstName = @Firstname, LastName = @Lastname, Address = @address, Phone = @phone WHERE CustID = @ID ", Connection);

                    //Parameters preventing SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("ID", ID);

                    //Opens connection to add in SQL and closes
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return " successfully";
            }
            catch (Exception e)
            {
               // Closes a second time as it jumps the first connection.close when ExecuteNonQuery fails
               Connection.Close();

                return " Has Failed with " + e;
            }
        }

        public string DeleteCustomer(string ID, string Table)
        {
            //Only runs if there is something in the textbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {
                    case "Customer":
                        myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID = @ID");
                        break;
                }

                //Parameters to prevent SQL injections
                myCommand.Connection = Connection;
                myCommand.Parameters.AddWithValue("ID", ID);

                //Opens a connection to add in SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return "successfully deleted";
            }
            else
            {
                Connection.Close();
                return "Failed to be deleted";
            }
        }


        
        //=======================_Rented_Movies_Related_==========================
        

        public DataTable FillDGVRentedMoviesWithRentedMovies()
        {
            //Create a datatable --> RentedMovies
            DataTable dtRentedMovies = new DataTable();

            using (DataAD = new SqlDataAdapter("SELECT FirstName, LastName, Phone, Title, DateRented, DateReturned, RMID, CustID, MovieID FROM CustomerAndMoviesRentedPhoneNum", Connection))
            {
                //Open a connection to the DB
                Connection.Open();
                //Fill the datatable from the SQL
                DataAD.Fill(dtRentedMovies);
                //Close the connection
                Connection.Close();
            }
            //Passes the datatable to the DataGridView
            return dtRentedMovies;
        }

        public string IssueMovie(string CustID, string MovieID)
        {
            
            //Runs if text is in the textboxes
            if (!object.ReferenceEquals(CustID, string.Empty) && (!object.ReferenceEquals(MovieID, string.Empty)))
            {
                var myCommand = new SqlCommand("INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented)" + "VALUES(@MovieID, @CustID, @Today)", Connection);

                DateTime Today = DateTime.Now;

                //Parameters to prevent SQL injections
                myCommand.Parameters.AddWithValue("MovieID", MovieID);
                myCommand.Parameters.AddWithValue("CustID", CustID);
                myCommand.Parameters.AddWithValue("Today", Today);
                
                //Opens a connection to add in SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return "successfully issued";
            }
            else
            {
                Connection.Close();
                return "Failed to issue";
            }
        }

        public string ReturnMovie(string CustID, string MovieID) //, string Title, string FirstName, string LastName)
        {
            //Runs if text is in the textboxes
            if (!object.ReferenceEquals(CustID, string.Empty) && (!object.ReferenceEquals(MovieID, string.Empty))) // && 
                //(!object.ReferenceEquals(Title, string.Empty) && (!object.ReferenceEquals(FirstName, string.Empty)) && 
                //(!object.ReferenceEquals(LastName, string.Empty))))
            {
                var myCommand = new SqlCommand("INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateReturned)" + "VALUES(@MovieID, @CustID, @Today)", Connection);

                DateTime Today = DateTime.Now;

                //Parameters to prevent SQL injections
                myCommand.Parameters.AddWithValue("MovieID", MovieID);
                myCommand.Parameters.AddWithValue("CustID", CustID);
                myCommand.Parameters.AddWithValue("Today", Today);

                //Opens a connection to add in SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return "successfully issued";
            }
            else
            {
                Connection.Close();
                return "Failed to issue";
            }
        }




    }


}

