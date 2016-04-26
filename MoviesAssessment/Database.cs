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
    public class Database
    {

        //Create Connection, Command and an Adapter
        SqlConnection Connection = new SqlConnection();
        SqlCommand Command = new SqlCommand();
        SqlDataAdapter DataAD = new SqlDataAdapter();

        public Database()
        {
            ConnectToDB();
        }


        public void ConnectToDB()
        {
            //Connection string to DB
            string connectionstring =
                @"Data Source=DESKTOP-KIO7TVU\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";

            Connection.ConnectionString = connectionstring;
            Command.Connection = Connection;
        }


        public void ClearAllTextBoxes(Control root)
        {
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox) ctrl).Text = string.Empty;
                }
            }
        }


        public void ClearAllLables(Control root)
        {
            List<string> LabelNamesAreCleared = new List<string>();

            LabelNamesAreCleared.Add("lblMovieID");
            LabelNamesAreCleared.Add("lblCustID");
            LabelNamesAreCleared.Add("lblRentedMovieID");
            LabelNamesAreCleared.Add("lblTotalCost");

            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is Label)
                {
                    if (LabelNamesAreCleared.Contains(ctrl.Name.ToString()))
                    {
                        ctrl.Text = string.Empty;
                    }
                }
            }
        }


        public DataTable FillDataGViewMCMovieRented()
        {
            DataTable MCMovieRented = new DataTable();
            using (
                DataAD = new SqlDataAdapter("SELECT [Times Issued], Title, Year FROM MostCommonMovieRented ORDER BY [Times Issued] DESC",
                        Connection))

            {
                //Open a connection to the DB
                Connection.Open();
                //Fill the datatable from the SQL
                DataAD.Fill(MCMovieRented);
                //Close the connection
                Connection.Close();
            }
            //Passes the datatable to the DataGridView
            return MCMovieRented;
        }


        public DataTable FillMCVideosRentedByCustomer()
        {
            DataTable MCVidRentedbyCust = new DataTable();

            using (DataAD = new SqlDataAdapter("SELECT [Hired Movies], FirstName, LastName FROM MostMoviesRentedByCustomer ORDER BY [Hired Movies] DESC",
                        Connection))
            {
                //Open a connection to the DB
                Connection.Open();
                //Fill the datatable from the SQL
                DataAD.Fill(MCVidRentedbyCust);
                //Close the connection
                Connection.Close();
            }
            //Passes the datatable to the DataGridView
            return MCVidRentedbyCust;
        }


        //=======================_Movies_Related_==========================

        public DataTable FillDGVMoviesWithMovies()
        {
            //Create a datatable --> Movies 
            DataTable dtMovies = new DataTable();

            using (
                DataAD = new SqlDataAdapter("SELECT MovieID, Title, Year, Rating, Genre, Plot FROM Movies", Connection))
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

        public string InsertOrUpdateMovie(string Title, string Year, string Rating, string Genre, string Plot, string ID, string AddOrUpdate)
        {
            try
            {
                if (AddOrUpdate == "Add")
                {
                    //Creates a Command object, a Query and opens a connection to SQL Server
                    var myCommand = new SqlCommand("INSERT INTO Movies (Title, Year, Rating, Genre, Plot)" + "VALUES(@Title, @Year, @Rating, @Genre, @Plot)", Connection);

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
                    var myCommand = new SqlCommand("UPDATE Movies set Title = @Title, Year = @Year, Rating = @Rating, Genre = @Genre, Plot = @Plot  WHERE MovieID = @ID ",
                            Connection);

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

        public string InsertOrUpdateCustomer(string Firstname, string Lastname, string Address, string Phone, string ID,
            string AddOrUpdate)
        {
            try
            {
                if (AddOrUpdate == "Add")
                {
                    //Creates a Command object, a Query and opens a connection to SQL Server
                    var myCommand =
                        new SqlCommand(
                            "INSERT INTO Customer (FirstName, LastName, Address, Phone)" +
                            "VALUES(@Firstname, @Lastname, @Address, @Phone)", Connection);

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
                    var myCommand =
                        new SqlCommand(
                            "UPDATE Customer set FirstName = @Firstname, LastName = @Lastname, Address = @address, Phone = @phone WHERE CustID = @ID ",
                            Connection);

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

            using (DataAD = new SqlDataAdapter("SELECT FirstName, LastName, Phone, Title, DateRented, DateReturned, RMID, CustID, MovieID FROM CustomerAndMoviesRentedPhoneNum",
                        Connection))
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


        public string DeleteRMRecord(string ID, string Table)
        {
            //Only runs if there is something in the textbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {
                    case "Rented Movie Record":
                        myCommand = new SqlCommand("DELETE FROM RentedMovies WHERE RMID = @ID");
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


        public string IssueMovie(string CustID, string MovieID)
        {
            //Runs only if text is in the textboxes
            if (!object.ReferenceEquals(CustID, string.Empty) && (!object.ReferenceEquals(MovieID, string.Empty)))
            {
                var myCommand =
                    new SqlCommand(
                        "INSERT INTO RentedMovies (CustIDFK, MovieIDFK, DateRented)" +
                        "VALUES(@CustID, @MovieID, @Today)", Connection);

                DateTime Today = DateTime.Now;

                //Parameters to prevent SQL injections
                myCommand.Parameters.AddWithValue("CustID", CustID);
                myCommand.Parameters.AddWithValue("MovieID", MovieID);
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


        public string ReturnMovie(string CustID, string MovieID, string ID)
        {
            DateTime Today = DateTime.Now;

            //Runs only if text is in the textboxes
            if (!object.ReferenceEquals(CustID, string.Empty) && (!object.ReferenceEquals(MovieID, string.Empty)))
            {
                var myCommand =
                    new SqlCommand("UPDATE RentedMovies set MovieIDFK = @MovieID, CustIDFK = @CustID, DateReturned = @Today WHERE RMID = @ID ",
                        Connection);

                //Parameters to prevent SQL injections
                myCommand.Parameters.AddWithValue("MovieID", MovieID);
                myCommand.Parameters.AddWithValue("CustID", CustID);
                myCommand.Parameters.AddWithValue("Today", Today);
                myCommand.Parameters.AddWithValue("ID", ID);

                //Opens a connection to add in SQL
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return "successfully returned";
            }
            else
            {
                Connection.Close();
                return "Failed to return";
            }
        }

        public string Cost(string MovieYear)
        {
            //Sorting the cost for the movie being issued
            int YearNow = (Convert.ToInt32(DateTime.Now.Year));
            int YearsOld = (YearNow - (Convert.ToInt32(MovieYear)));

            if (YearsOld <= 5)
            {
                return "$5.00";
            }
            else
            {
                return "$2.00";
            }
        }

        //================_Unit_Test_Mothod==================


        public bool ConnectionTestFillDGVMovies()
        {
            //Create a datatable --> Movies 
            DataTable dtMovies = new DataTable();

            try
            {
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
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

