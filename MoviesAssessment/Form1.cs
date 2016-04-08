using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MoviesAssessment
{
    public partial class Form1 : Form
    {
        Database myDatabase = new Database();
       // SqlConnection Connection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            DisplayDataGridViewMovies();
            DisplayDataGridViewCustomers();
            DisplayDataGridViewRentedMovies();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhoneNum.Text = "";
            txtMovieID.Text = "";
            txtRating.Text = "";
            txtTitle.Text = "";
            txtYear.Text = "";
            txtPlot.Text = "";
            txtGenre.Text = "";
        }
        
        //====================_Movie_Related_========================
        
        
        private void DisplayDataGridViewMovies()
        {
            //Clears out old data
            DGVMovies.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();

                DGVMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int MovieID;

            //Cell clicks for the value that you click on
            try
            {
                MovieID = (int) DGVMovies.Rows[e.RowIndex].Cells[0].Value;
               txtRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                 txtYear.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                 txtPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (e.RowIndex >= 0)
                {
                    DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtMovieID.Text = MovieID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnAddMovie_Click(System.Object sender, System.EventArgs e)
        {
            //Holds the success or failure result
            string result = null;

            //Only runs if there is something in the textboxes
            if ((txtRating.Text != string.Empty) && (txtTitle.Text != string.Empty) && (txtYear.Text != string.Empty) && (txtPlot.Text != string.Empty) && 
                (txtGenre.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtRating.Text, txtTitle.Text, txtYear.Text, txtPlot.Text, txtGenre.Text, txtMovieID.Text, "Add");
                    MessageBox.Show(txtTitle.Text + " " + txtYear.Text + " added " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewMovies();
                txtRating.Text = "";
                txtTitle.Text = "";
                txtYear.Text = "";
                txtPlot.Text = "";
                txtGenre.Text = "";
            }
            else 
            {
                MessageBox.Show("Data required in all fields");
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            //Updates a Movie
            if ((!object.ReferenceEquals(txtMovieID.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtRating.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtTitle.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtYear.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtPlot.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtGenre.Text, string.Empty)))
            {
                string result = null;
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtRating.Text, txtTitle.Text,
                        txtYear.Text, txtPlot.Text, txtGenre.Text, txtMovieID.Text, "Update");
                    MessageBox.Show(txtTitle.Text + " " + txtYear.Text + " updated" + result);


                    //Update the DataGridView to see new entries 
                    DisplayDataGridViewMovies();
                    DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Movie was not Updated. " + ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewMovies();
                txtRating.Text = "";
                txtTitle.Text = "";
                txtYear.Text = "";
                txtPlot.Text = "";
                txtGenre.Text = "";
            }
        }


        //Deletes movie
        private void btnDeleteMovie_Click(System.Object sender, System.EventArgs e)
        {
            //Hold the ID of the Movie
            string InputID = string.Empty;
            string result = null;
            string TableName = string.Empty;

            Button fakebutton = (Button)sender;

            try
            {
                switch (fakebutton.Name)
                {
                    case "btnDeleteMovie":
                        InputID = txtMovieID.Text;
                        TableName = "Movie";
                        break;
                }

                //Delete the movie here and return back the result
                result = myDatabase.DeleteMovie(InputID, TableName);
                MessageBox.Show(TableName + " deleted " + result);

                //Refreshes everything
                DisplayDataGridViewMovies();


                //Clears all textboxes after
                myDatabase.ClearAllTextBoxes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a movie to be removed. " + ex.Message);
            }
        }

       
        //====================_Customer_Related_======================== 
       

        private void DisplayDataGridViewCustomers()
        {
            //Clears out old data
            DGVCustomers.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                DGVCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomers();

                DGVCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustID = 0;
            //Cell clicks for the values that you click on
            try
            {
                     CustID = (int) DGVCustomers.Rows[e.RowIndex].Cells[0].Value;
                txtFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                 txtLastName.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                  txtAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                 txtPhoneNum.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                if (e.RowIndex >= 0)
                {
                    DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtCustID.Text = CustID.ToString();
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Add a New Customer
        private void btnAddCustomer_Click(System.Object sender, System.EventArgs e)
        {
            //Holds the success or failure result
            string result = null;
            
            //Only runs if there is something in the textboxes
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty) && (txtAddress.Text != string.Empty) && (txtPhoneNum.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNum.Text, txtCustID.Text, "Add");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " added" + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewCustomers();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhoneNum.Text = "";
            }
            else
            {
                MessageBox.Show("Data required in all fields");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //Updates a customer
            if ((!object.ReferenceEquals(txtCustID.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtFirstName.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtLastName.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtAddress.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtPhoneNum.Text, string.Empty)))
            {
                string result = null;
                try
                {
                    result = myDatabase.InsertOrUpdateCustomer(txtFirstName.Text, txtLastName.Text,
                        txtAddress.Text, txtPhoneNum.Text, txtCustID.Text, "Update");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " updated " + result);


                    //Update the DataGridView to see new entries
                    DisplayDataGridViewCustomers();
                    DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Customer not Updated. " + ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewCustomers();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhoneNum.Text = "";
            }
        }
        private void btnDeleteCustomer_Click(System.Object sender, System.EventArgs e)
        {
            //Hold the ID of the Customer
            string InputID = string.Empty;
            string result = null;
            string TableName = string.Empty;

            Button fakebutton =(Button) sender;

            try
            {
                switch (fakebutton.Name)
                {
                    case "btnDeleteCustomer":
                        InputID = txtCustID.Text;
                        TableName = "Customer";
                        break;
                }

                //Delete the customer here and return back the result
                result = myDatabase.DeleteCustomer(InputID, TableName);
                MessageBox.Show(TableName + " " + result);

                //Refreshes everything
                DisplayDataGridViewCustomers();
                
                
                //Clears all textboxes after
                myDatabase.ClearAllTextBoxes(this);
            }
              catch (Exception ex)
              {
                  MessageBox.Show("Please select a customer to be removed, " + ex.Message);
              }
        }


        //=====================_Rented Movies_Related==================
        

        private void DGVRentedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                //These are the cells clicks for the values that you click on
              txtFirstName.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[0].Value.ToString();  
               txtLastName.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
               txtPhoneNum.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                  txtTitle.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                 txtCustID.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMovieID.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[8].Value.ToString();
           
              if (e.RowIndex >= 0)
                {
                    DGVRentedMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private
            void DisplayDataGridViewRentedMovies()
        {
            //Clears out old data
            DGVRentedMovies.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                DGVRentedMovies.DataSource = myDatabase.FillDGVRentedMoviesWithRentedMovies();

                DGVRentedMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            

            if ((txtCustID.Text != string.Empty) && (txtMovieID.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.IssueMovie(txtMovieID.Text, txtCustID.Text);
                    MessageBox.Show("Movie successfully issued to customer");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates DataGrideView to see new entries
                DisplayDataGridViewRentedMovies();
                txtCustID.Text = "";
                txtMovieID.Text = "";
            }
            else
            {
                MessageBox.Show("Data required in 'CustID' and 'MovieID' textboxes");
            }


        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
           string result = null;


            if ((txtCustID.Text != string.Empty) && (txtMovieID.Text != string.Empty) && (txtTitle.Text != string.Empty) &&
                (txtFirstName.Text != string.Empty) && (txtLastName.Text !=string.Empty))
            {
                try
                {
                    result = myDatabase.ReturnMovie(txtMovieID.Text, txtCustID.Text);
                    MessageBox.Show("Movie successfully returned");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates DataGrideView to see new entries
                DisplayDataGridViewRentedMovies();
                txtCustID.Text = "";
                txtMovieID.Text = "";
                txtTitle.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
            }
            else
            {
                MessageBox.Show("Details of customer and rented movie required");
            }
        }

       
    }
}
