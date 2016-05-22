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
            myDatabase.ClearAllTextBoxes(this);
            myDatabase.ClearAllLables(this);
        }
        

        /// <summary>
        ///=== Movie_Related ===
        /// </summary>
        
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
                txtTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                 txtYear.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
               txtRating.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                 txtPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (e.RowIndex >= 0)
                {
                    DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    lblMovieID.Text = MovieID.ToString();
                  lblTotalCost.Text = myDatabase.Cost(txtYear.Text);
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
            if ((txtTitle.Text != string.Empty) && (txtYear.Text != string.Empty) && (txtRating.Text != string.Empty) && (txtGenre.Text != string.Empty) && 
                (txtPlot.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtTitle.Text, txtYear.Text, txtRating.Text, txtGenre.Text, txtPlot.Text, lblMovieID.Text, "Add");
                    MessageBox.Show(txtTitle.Text + " " + txtYear.Text + " added " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewMovies();
                txtTitle.Text = "";
                txtYear.Text = "";
                txtRating.Text = "";
                txtGenre.Text = "";
                txtPlot.Text = "";
                lblMovieID.Text = "";
            }
            else 
            {
                MessageBox.Show("Data required in all fields");
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            
            if ((!object.ReferenceEquals(lblMovieID.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtTitle.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtYear.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtRating.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtGenre.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtPlot.Text, string.Empty)))
            {
                string result = null;
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtTitle.Text, txtYear.Text,
                        txtRating.Text, txtGenre.Text, txtPlot.Text, lblMovieID.Text, "Update");
                    MessageBox.Show(txtTitle.Text + " " + txtYear.Text + " updated" + result);


                    //Updates the DataGridView to see new entries 
                    DisplayDataGridViewMovies();
                    DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Movie was not Updated. " + ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewMovies();
                
                myDatabase.ClearAllTextBoxes(this);
                lblMovieID.Text = "";
            }
        }

        
        private void btnDeleteMovie_Click(System.Object sender, System.EventArgs e)
        {
            //Holds the ID of the Movie
            string InputID = string.Empty;
            string result = null;
            string TableName = string.Empty;

            Button fakebutton = (Button) sender;


            DialogResult dialog = MessageBox.Show("Are you sure you want to DELETE this Movie?", "Confirm Deletion",
                MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                try
                {
                    switch (fakebutton.Name)
                    {
                        case "btnDeleteMovie":
                            InputID = lblMovieID.Text;
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
                    lblMovieID.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select a movie to be removed. " + ex.Message);
                }
            }
        }
        
        /// <summary>
        /// === Customer_Related ===
        /// </summary>

        private void DisplayDataGridViewCustomers()
        {
            //Clears out old data
            DGVCustomers.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                DGVCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomers();

                DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                    lblCustID.Text = CustID.ToString();
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnAddCustomer_Click(System.Object sender, System.EventArgs e)
        {
            //Holds the success or failure result
            string result = null;
            
            //Only runs if there is something in the textboxes
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty) && (txtAddress.Text != string.Empty) && (txtPhoneNum.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNum.Text, lblCustID.Text, "Add");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " added" + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates the DataGridView to see new entries
                DisplayDataGridViewCustomers();
                
                myDatabase.ClearAllTextBoxes(this);
            }
            else
            {
                MessageBox.Show("Data required in all fields");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            
            if ((!object.ReferenceEquals(lblCustID.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtFirstName.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtLastName.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtAddress.Text, string.Empty)) &&
                (!object.ReferenceEquals(txtPhoneNum.Text, string.Empty)))
            {
                string result = null;
                try
                {
                    result = myDatabase.InsertOrUpdateCustomer(txtFirstName.Text, txtLastName.Text,
                        txtAddress.Text, txtPhoneNum.Text, lblCustID.Text, "Update");
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
                lblCustID.Text = "";
            }
        }
        private void btnDeleteCustomer_Click(System.Object sender, System.EventArgs e)
        {
            //Hold the ID of the Customer
            string InputID = string.Empty;
            string result = null;
            string TableName = string.Empty;

            Button fakebutton =(Button) sender;
            

            DialogResult dialog = MessageBox.Show("Are you sure you want to DELETE this customer?", "Confirm Deletion",
                MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    switch (fakebutton.Name)
                    {
                        case "btnDeleteCustomer":
                            InputID = lblCustID.Text;
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
                    lblCustID.Text = "";
                }
                catch (Exception ex)

                {
                  MessageBox.Show("Please select a customer to be removed, " + ex.Message);
                }
            }
        } 

        /// <summary>
        /// === Rented_Movies_Related ===
        /// </summary>
        
        private void DGVRentedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            try
            {
                  //These are the cells clicks for the values that you click on
                  txtFirstName.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[0].Value.ToString();  
                   txtLastName.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                   txtPhoneNum.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                      txtTitle.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                     lblCustID.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                    lblMovieID.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[8].Value.ToString();
              lblRentedMovieID.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
           
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


        private void DisplayDataGridViewRentedMovies()
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
            

            if ((lblCustID.Text != string.Empty) && (lblMovieID.Text != string.Empty))
            {
                try
                {
                    //Supposed to change the colour of Issued movies but isn't working
                    DGVRentedMovies.Rows[DGVRentedMovies.Rows.Count-1].DefaultCellStyle.BackColor = Color.Red;

                    result = myDatabase.IssueMovie(lblCustID.Text, lblMovieID.Text);
                    MessageBox.Show("Movie successfully issued to customer");
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Updates DataGrideView to see new entries
                DisplayDataGridViewRentedMovies();
            }
            else
            {
                MessageBox.Show("Please select a movie and a customer then try again");
            }
            myDatabase.ClearAllTextBoxes(this);
            myDatabase.ClearAllLables(this);
        }


        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
           string result = null;


            if ((lblCustID.Text != string.Empty) && (lblMovieID.Text != string.Empty) && (txtTitle.Text != string.Empty) &&
                (txtFirstName.Text != string.Empty) && (txtLastName.Text !=string.Empty))
            {
                try
                {
                    //Supposed to change the colour of Issued movies but isn't working
                    DGVRentedMovies.Rows[DGVRentedMovies.Rows.Count-1].DefaultCellStyle.BackColor = Color.Green;

                    result = myDatabase.ReturnMovie(lblMovieID.Text, lblCustID.Text, lblRentedMovieID.Text);
                    MessageBox.Show("Movie successfully returned");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to return movie, " + ex.Message);
                }

                //Updates DataGrideView to see new entries
                DisplayDataGridViewRentedMovies();
                
                myDatabase.ClearAllTextBoxes(this);
                myDatabase.ClearAllLables(this);
            }
            else
            {
                MessageBox.Show("ID's of customer and movie are required");
            }
        }


        private void btnDeleteRMRecord_Click(object sender, EventArgs e)
        {
            //Holds the ID of the Rented Movie
            string InputID = string.Empty;
            string result = null;
            string TableName = string.Empty;

            Button fakebutton = (Button) sender;
            DialogResult dialog = MessageBox.Show("Are you sure you want to DELETE this rented movie record?", "Confirm Deletion",
                MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    switch (fakebutton.Name)
                    {
                        case "btnDeleteRMRecord":
                            InputID = lblRentedMovieID.Text;
                            TableName = "Rented Movie Record";
                            break;
                    }

                    //Delete the reord here and returns back the result
                    result = myDatabase.DeleteRMRecord(InputID, TableName);
                    MessageBox.Show(TableName + " " + result);

                    //Refreshes everything
                    DisplayDataGridViewRentedMovies();
                    
                    //Clears all textboxes after
                    myDatabase.ClearAllTextBoxes(this);
                    myDatabase.ClearAllLables(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select record to be removed, " + ex.Message);
                }
            }
        }

        
        //================================================================================


            private
            void btnFind_Click(object sender, EventArgs e)
        {
            if (CBOptions.SelectedIndex == 0)
            {
               DisplayDataGViewMCMovieRented();
            }

           else if (CBOptions.SelectedIndex == 1)
            {
                DisplayMCVideosRentedByCustomer();
            }
        }


        private void DisplayDataGViewMCMovieRented()
        {
            //Clears out old data
            DGVResults.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                DGVResults.DataSource = myDatabase.FillDataGViewMCMovieRented();

                DGVResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DisplayMCVideosRentedByCustomer()
        {
            //Clears out old data
            DGVResults.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                DGVResults.DataSource = myDatabase.FillMCVideosRentedByCustomer();

                DGVResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcDisplayIssuedMovies()
        {
            



            //Clears out old data
            DGVResults.DataSource = null;
            try
            {
                //Passes the datatable to the DataGridView
                int ID = Convert.ToInt32(txtCustIDMovieSearch.Text);
                DGVResults.DataSource = myDatabase.ProcSearch(ID);

                DGVResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            //Working Search but not right for assessement specs

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KIO7TVU\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True");

            //if (cbSearch.Text == "Customers")
            //{
            //    TabControl.SelectedTab = tabPageCustomers;

            //    SqlDataAdapter da = new SqlDataAdapter("SELECT CustID, FirstName, LastName, Address, Phone FROM Customer WHERE FirstName like '" + txtbSearch.Text + "%'" , con);

            //    DataTable dt = new DataTable();

            //    da.Fill(dt);
            //    DGVCustomers.DataSource = dt;
            //}
            //else if (cbSearch.Text == "Movies")
            //{
            //    TabControl.SelectedTab = tabPageMovies;

            //    SqlDataAdapter da = new SqlDataAdapter("SELECT MovieID, Title, Year, Rating, Genre, Plot FROM Movies WHERE Title like '" + txtbSearch.Text + "%'", con);

            //    DataTable dt = new DataTable();

            //    da.Fill(dt);
            //    DGVMovies.DataSource = dt;
            //}
            //else if (cbSearch.Text == "Rented Movies")
            //{
            //    TabControl.SelectedTab = tabPageRentedMovies;

            //    SqlDataAdapter da = new SqlDataAdapter("SELECT FirstName, LastName, Phone, Title, DateRented, DateReturned, RMID, CustID, MovieID FROM CustomerAndMoviesRentedPhoneNum WHERE FirstName like '" + txtbSearch.Text + "%'", con);

            //    DataTable dt = new DataTable();

            //    da.Fill(dt);
            //    DGVRentedMovies.DataSource = dt;
            //}

            //+++++++++++++++++++++++++++++++++++++++


            //Searching the Databases if text is entered in the search box
            if (txtbSearch.TextLength > 0)
            {
                string text = cbSearch.SelectedItem.ToString();
                string searchtext = txtbSearch.Text;

                 if (text == "Customers")
                {   
                    TabControl.SelectedTab = tabPageCustomers;
                    DGVCustomers = myDatabase.Search(text,searchtext);
                }

             else if (text == "Movies")
                {
                    TabControl.SelectedTab = tabPageMovies;
                    DGVMovies = myDatabase.Search(text,searchtext);
                }
             else if (text == "RentedMovies")
                {
                    TabControl.SelectedTab = tabPageRentedMovies;
                    DGVRentedMovies = myDatabase.Search(text,searchtext);
                }
            }
        }

        private void btnIssuedMovies_Click(object sender, EventArgs e)
        {
            ProcDisplayIssuedMovies();
        }

        
    }

}
