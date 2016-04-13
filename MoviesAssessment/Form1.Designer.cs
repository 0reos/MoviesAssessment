namespace MoviesAssessment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageRentedMovies = new System.Windows.Forms.TabPage();
            this.DGVRentedMovies = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteRMRecord = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblRentedMovieID = new System.Windows.Forms.Label();
            this.CBOptions = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.DGVResults = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPageMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabPageRentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResults)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageMovies);
            this.TabControl.Controls.Add(this.tabPageCustomers);
            this.TabControl.Controls.Add(this.tabPageRentedMovies);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(737, 328);
            this.TabControl.TabIndex = 0;
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.DGVMovies);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(729, 302);
            this.tabPageMovies.TabIndex = 0;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Location = new System.Drawing.Point(0, 0);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.Size = new System.Drawing.Size(729, 302);
            this.DGVMovies.TabIndex = 0;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.DGVCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(729, 302);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Location = new System.Drawing.Point(0, 0);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.Size = new System.Drawing.Size(729, 302);
            this.DGVCustomers.TabIndex = 0;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // tabPageRentedMovies
            // 
            this.tabPageRentedMovies.Controls.Add(this.DGVRentedMovies);
            this.tabPageRentedMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentedMovies.Name = "tabPageRentedMovies";
            this.tabPageRentedMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRentedMovies.Size = new System.Drawing.Size(729, 302);
            this.tabPageRentedMovies.TabIndex = 2;
            this.tabPageRentedMovies.Text = "Rented Movies";
            this.tabPageRentedMovies.UseVisualStyleBackColor = true;
            // 
            // DGVRentedMovies
            // 
            this.DGVRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentedMovies.Location = new System.Drawing.Point(0, 0);
            this.DGVRentedMovies.Name = "DGVRentedMovies";
            this.DGVRentedMovies.Size = new System.Drawing.Size(729, 302);
            this.DGVRentedMovies.TabIndex = 0;
            this.DGVRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentedMovies_CellContentClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCustomer.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 359);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddCustomer.Size = new System.Drawing.Size(97, 23);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.Tan;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(23, 517);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteMovie.TabIndex = 15;
            this.btnDeleteMovie.Tag = "Movie";
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.Tan;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(23, 492);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(86, 23);
            this.btnUpdateMovie.TabIndex = 14;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(12, 384);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateCustomer.TabIndex = 11;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(12, 409);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteCustomer.TabIndex = 12;
            this.btnDeleteCustomer.Tag = "Customer";
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(167, 361);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(115, 21);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(409, 361);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(115, 21);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(530, 361);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(115, 21);
            this.txtPhoneNum.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(288, 361);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(115, 21);
            this.txtLastName.TabIndex = 2;
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(417, 469);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(60, 21);
            this.txtRating.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(167, 469);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(170, 21);
            this.txtTitle.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(343, 469);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(68, 21);
            this.txtYear.TabIndex = 7;
            // 
            // txtPlot
            // 
            this.txtPlot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlot.Location = new System.Drawing.Point(589, 469);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(162, 21);
            this.txtPlot.TabIndex = 8;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(483, 469);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 21);
            this.txtGenre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "FirstName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(530, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "MovieID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "CustID";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Tan;
            this.btnAddMovie.Location = new System.Drawing.Point(23, 466);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(86, 23);
            this.btnAddMovie.TabIndex = 13;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnIssueMovie.Location = new System.Drawing.Point(780, 34);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(103, 60);
            this.btnIssueMovie.TabIndex = 29;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Green;
            this.btnReturnMovie.Location = new System.Drawing.Point(903, 34);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(103, 60);
            this.btnReturnMovie.TabIndex = 30;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(16, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(777, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "RentedMovieID";
            // 
            // btnDeleteRMRecord
            // 
            this.btnDeleteRMRecord.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteRMRecord.Location = new System.Drawing.Point(780, 146);
            this.btnDeleteRMRecord.Name = "btnDeleteRMRecord";
            this.btnDeleteRMRecord.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteRMRecord.TabIndex = 34;
            this.btnDeleteRMRecord.Text = "Delete Rented Movie Record";
            this.btnDeleteRMRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRMRecord.Click += new System.EventHandler(this.btnDeleteRMRecord_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCustID.Location = new System.Drawing.Point(119, 366);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(0, 13);
            this.lblCustID.TabIndex = 35;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.BackColor = System.Drawing.Color.Tan;
            this.lblMovieID.Location = new System.Drawing.Point(118, 474);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(0, 13);
            this.lblMovieID.TabIndex = 36;
            // 
            // lblRentedMovieID
            // 
            this.lblRentedMovieID.AutoSize = true;
            this.lblRentedMovieID.BackColor = System.Drawing.Color.RosyBrown;
            this.lblRentedMovieID.Location = new System.Drawing.Point(780, 125);
            this.lblRentedMovieID.Name = "lblRentedMovieID";
            this.lblRentedMovieID.Size = new System.Drawing.Size(0, 13);
            this.lblRentedMovieID.TabIndex = 37;
            // 
            // CBOptions
            // 
            this.CBOptions.FormattingEnabled = true;
            this.CBOptions.Location = new System.Drawing.Point(780, 280);
            this.CBOptions.Name = "CBOptions";
            this.CBOptions.Size = new System.Drawing.Size(158, 21);
            this.CBOptions.TabIndex = 38;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(780, 308);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 23);
            this.btnFind.TabIndex = 39;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // DGVResults
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResults.ColumnHeadersVisible = false;
            this.DGVResults.Location = new System.Drawing.Point(780, 337);
            this.DGVResults.Name = "DGVResults";
            this.DGVResults.RowHeadersVisible = false;
            this.DGVResults.Size = new System.Drawing.Size(226, 150);
            this.DGVResults.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Cost =";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(198, 497);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCost.TabIndex = 42;
            this.lblTotalCost.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 571);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DGVResults);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.CBOptions);
            this.Controls.Add(this.lblRentedMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnDeleteRMRecord);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Movies";
            this.TabControl.ResumeLayout(false);
            this.tabPageMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabPageRentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageRentedMovies;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.DataGridView DGVRentedMovies;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteRMRecord;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblRentedMovieID;
        private System.Windows.Forms.ComboBox CBOptions;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView DGVResults;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

