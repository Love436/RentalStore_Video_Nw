
namespace RentalStore_Video_Nw
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
            this.VideoControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txtcost = new System.Windows.Forms.TextBox();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.TxtPlot = new System.Windows.Forms.TextBox();
            this.TxtCopies = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtRatting = new System.Windows.Forms.TextBox();
            this.Txttitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.postal_code = new System.Windows.Forms.TextBox();
            this.interested_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.delCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.movie_name_rental_area = new System.Windows.Forms.TextBox();
            this.customer_name_rental_area = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.VideoID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.ReturnVideo = new System.Windows.Forms.DateTimePicker();
            this.IssueVideo = new System.Windows.Forms.DateTimePicker();
            this.rentalVideoDelete = new System.Windows.Forms.Button();
            this.rentalReturnVideo = new System.Windows.Forms.Button();
            this.rentalIssueVideo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.RadioButton();
            this.Video = new System.Windows.Forms.RadioButton();
            this.Customer = new System.Windows.Forms.RadioButton();
            this.Record = new System.Windows.Forms.DataGridView();
            this.bestCustomer = new System.Windows.Forms.Button();
            this.best_Video = new System.Windows.Forms.Button();
            this.VideoControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoControls
            // 
            this.VideoControls.Controls.Add(this.tabPage1);
            this.VideoControls.Controls.Add(this.tabPage2);
            this.VideoControls.Controls.Add(this.tabPage3);
            this.VideoControls.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoControls.Location = new System.Drawing.Point(2, 3);
            this.VideoControls.Name = "VideoControls";
            this.VideoControls.SelectedIndex = 0;
            this.VideoControls.Size = new System.Drawing.Size(634, 289);
            this.VideoControls.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Purple;
            this.tabPage1.Controls.Add(this.Txtcost);
            this.tabPage1.Controls.Add(this.delVideo);
            this.tabPage1.Controls.Add(this.updateVideo);
            this.tabPage1.Controls.Add(this.AddVideo);
            this.tabPage1.Controls.Add(this.TxtGenre);
            this.tabPage1.Controls.Add(this.TxtPlot);
            this.tabPage1.Controls.Add(this.TxtCopies);
            this.tabPage1.Controls.Add(this.TxtYear);
            this.tabPage1.Controls.Add(this.TxtRatting);
            this.tabPage1.Controls.Add(this.Txttitle);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(626, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video ";
            // 
            // Txtcost
            // 
            this.Txtcost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcost.Location = new System.Drawing.Point(125, 149);
            this.Txtcost.Name = "Txtcost";
            this.Txtcost.Size = new System.Drawing.Size(154, 32);
            this.Txtcost.TabIndex = 170;
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(482, 152);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(85, 32);
            this.delVideo.TabIndex = 169;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(391, 152);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(85, 32);
            this.updateVideo.TabIndex = 168;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(300, 152);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(85, 32);
            this.AddVideo.TabIndex = 167;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // TxtGenre
            // 
            this.TxtGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenre.Location = new System.Drawing.Point(412, 107);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(154, 32);
            this.TxtGenre.TabIndex = 166;
            // 
            // TxtPlot
            // 
            this.TxtPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlot.Location = new System.Drawing.Point(412, 71);
            this.TxtPlot.Name = "TxtPlot";
            this.TxtPlot.Size = new System.Drawing.Size(154, 32);
            this.TxtPlot.TabIndex = 165;
            // 
            // TxtCopies
            // 
            this.TxtCopies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCopies.Location = new System.Drawing.Point(413, 32);
            this.TxtCopies.Name = "TxtCopies";
            this.TxtCopies.Size = new System.Drawing.Size(154, 32);
            this.TxtCopies.TabIndex = 164;
            // 
            // TxtYear
            // 
            this.TxtYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.Location = new System.Drawing.Point(125, 112);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(154, 32);
            this.TxtYear.TabIndex = 163;
            this.TxtYear.TextChanged += new System.EventHandler(this.TxtYear_TextChanged);
            // 
            // TxtRatting
            // 
            this.TxtRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRatting.Location = new System.Drawing.Point(125, 74);
            this.TxtRatting.Name = "TxtRatting";
            this.TxtRatting.Size = new System.Drawing.Size(154, 32);
            this.TxtRatting.TabIndex = 162;
            // 
            // Txttitle
            // 
            this.Txttitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttitle.Location = new System.Drawing.Point(125, 36);
            this.Txttitle.Name = "Txttitle";
            this.Txttitle.Size = new System.Drawing.Size(154, 32);
            this.Txttitle.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(312, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 160;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(311, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 159;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 158;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 157;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 156;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 155;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(24, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 154;
            this.label16.Text = "Title";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.postal_code);
            this.tabPage2.Controls.Add(this.interested_in);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.delCustomer);
            this.tabPage2.Controls.Add(this.updateCustomer);
            this.tabPage2.Controls.Add(this.addCustomer);
            this.tabPage2.Controls.Add(this.Address);
            this.tabPage2.Controls.Add(this.MobileNo);
            this.tabPage2.Controls.Add(this.TxtName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(626, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(312, 29);
            this.label12.TabIndex = 130;
            this.label12.Text = "Interested In (Old Movies,New Movies)";
            // 
            // postal_code
            // 
            this.postal_code.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postal_code.Location = new System.Drawing.Point(150, 182);
            this.postal_code.Name = "postal_code";
            this.postal_code.Size = new System.Drawing.Size(154, 32);
            this.postal_code.TabIndex = 129;
            // 
            // interested_in
            // 
            this.interested_in.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interested_in.Location = new System.Drawing.Point(150, 143);
            this.interested_in.Name = "interested_in";
            this.interested_in.Size = new System.Drawing.Size(154, 32);
            this.interested_in.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 127;
            this.label1.Text = "Postal Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 126;
            this.label10.Text = "Intrested IN";
            // 
            // delCustomer
            // 
            this.delCustomer.BackColor = System.Drawing.Color.Black;
            this.delCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.ForeColor = System.Drawing.Color.White;
            this.delCustomer.Location = new System.Drawing.Point(336, 68);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(274, 37);
            this.delCustomer.TabIndex = 125;
            this.delCustomer.Text = "Delete";
            this.delCustomer.UseVisualStyleBackColor = false;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.BackColor = System.Drawing.Color.Black;
            this.updateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.ForeColor = System.Drawing.Color.White;
            this.updateCustomer.Location = new System.Drawing.Point(456, 30);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(154, 32);
            this.updateCustomer.TabIndex = 124;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = false;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.Black;
            this.addCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.ForeColor = System.Drawing.Color.White;
            this.addCustomer.Location = new System.Drawing.Point(334, 30);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(101, 32);
            this.addCustomer.TabIndex = 121;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(150, 96);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(154, 32);
            this.Address.TabIndex = 123;
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(150, 57);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(154, 32);
            this.MobileNo.TabIndex = 122;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(150, 19);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(154, 32);
            this.TxtName.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 119;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 118;
            this.label9.Text = "Phone No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 117;
            this.label11.Text = " Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage3.Controls.Add(this.movie_name_rental_area);
            this.tabPage3.Controls.Add(this.customer_name_rental_area);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.VideoID);
            this.tabPage3.Controls.Add(this.CustomerID);
            this.tabPage3.Controls.Add(this.ReturnVideo);
            this.tabPage3.Controls.Add(this.IssueVideo);
            this.tabPage3.Controls.Add(this.rentalVideoDelete);
            this.tabPage3.Controls.Add(this.rentalReturnVideo);
            this.tabPage3.Controls.Add(this.rentalIssueVideo);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(626, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            // 
            // movie_name_rental_area
            // 
            this.movie_name_rental_area.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_rental_area.Location = new System.Drawing.Point(144, 181);
            this.movie_name_rental_area.Name = "movie_name_rental_area";
            this.movie_name_rental_area.Size = new System.Drawing.Size(154, 32);
            this.movie_name_rental_area.TabIndex = 143;
            // 
            // customer_name_rental_area
            // 
            this.customer_name_rental_area.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_rental_area.Location = new System.Drawing.Point(144, 135);
            this.customer_name_rental_area.Name = "customer_name_rental_area";
            this.customer_name_rental_area.Size = new System.Drawing.Size(154, 32);
            this.customer_name_rental_area.TabIndex = 142;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 18);
            this.label18.TabIndex = 141;
            this.label18.Text = "MovieName";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 18);
            this.label19.TabIndex = 140;
            this.label19.Text = "Customer Name";
            // 
            // VideoID
            // 
            this.VideoID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoID.Location = new System.Drawing.Point(144, 55);
            this.VideoID.Name = "VideoID";
            this.VideoID.Size = new System.Drawing.Size(154, 32);
            this.VideoID.TabIndex = 139;
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(144, 9);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(154, 32);
            this.CustomerID.TabIndex = 138;
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideo.Location = new System.Drawing.Point(466, 48);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(154, 32);
            this.ReturnVideo.TabIndex = 137;
            // 
            // IssueVideo
            // 
            this.IssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueVideo.Location = new System.Drawing.Point(466, 11);
            this.IssueVideo.Name = "IssueVideo";
            this.IssueVideo.Size = new System.Drawing.Size(154, 32);
            this.IssueVideo.TabIndex = 136;
            // 
            // rentalVideoDelete
            // 
            this.rentalVideoDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.rentalVideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalVideoDelete.ForeColor = System.Drawing.Color.AliceBlue;
            this.rentalVideoDelete.Location = new System.Drawing.Point(331, 173);
            this.rentalVideoDelete.Name = "rentalVideoDelete";
            this.rentalVideoDelete.Size = new System.Drawing.Size(274, 37);
            this.rentalVideoDelete.TabIndex = 135;
            this.rentalVideoDelete.Text = "Delete";
            this.rentalVideoDelete.UseVisualStyleBackColor = false;
            this.rentalVideoDelete.Click += new System.EventHandler(this.rentalVideoDelete_Click);
            // 
            // rentalReturnVideo
            // 
            this.rentalReturnVideo.BackColor = System.Drawing.Color.MidnightBlue;
            this.rentalReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturnVideo.ForeColor = System.Drawing.Color.AliceBlue;
            this.rentalReturnVideo.Location = new System.Drawing.Point(451, 135);
            this.rentalReturnVideo.Name = "rentalReturnVideo";
            this.rentalReturnVideo.Size = new System.Drawing.Size(154, 32);
            this.rentalReturnVideo.TabIndex = 134;
            this.rentalReturnVideo.Text = "Return";
            this.rentalReturnVideo.UseVisualStyleBackColor = false;
            this.rentalReturnVideo.Click += new System.EventHandler(this.rentalReturnVideo_Click);
            // 
            // rentalIssueVideo
            // 
            this.rentalIssueVideo.BackColor = System.Drawing.Color.MidnightBlue;
            this.rentalIssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalIssueVideo.ForeColor = System.Drawing.Color.AliceBlue;
            this.rentalIssueVideo.Location = new System.Drawing.Point(329, 135);
            this.rentalIssueVideo.Name = "rentalIssueVideo";
            this.rentalIssueVideo.Size = new System.Drawing.Size(101, 32);
            this.rentalIssueVideo.TabIndex = 133;
            this.rentalIssueVideo.Text = "Issue";
            this.rentalIssueVideo.UseVisualStyleBackColor = false;
            this.rentalIssueVideo.Click += new System.EventHandler(this.rentalIssueVideo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(326, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 18);
            this.label13.TabIndex = 132;
            this.label13.Text = "Date of Return ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(326, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 18);
            this.label14.TabIndex = 131;
            this.label14.Text = "Date of Issue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 18);
            this.label15.TabIndex = 130;
            this.label15.Text = "Movie ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 18);
            this.label17.TabIndex = 129;
            this.label17.Text = "Customer ID";
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.BackColor = System.Drawing.Color.Black;
            this.Rent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.ForeColor = System.Drawing.Color.White;
            this.Rent.Location = new System.Drawing.Point(861, 445);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(82, 27);
            this.Rent.TabIndex = 156;
            this.Rent.TabStop = true;
            this.Rent.Text = "Rental";
            this.Rent.UseVisualStyleBackColor = false;
            this.Rent.CheckedChanged += new System.EventHandler(this.Rent_CheckedChanged);
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.BackColor = System.Drawing.Color.Black;
            this.Video.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video.ForeColor = System.Drawing.Color.White;
            this.Video.Location = new System.Drawing.Point(861, 388);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(78, 27);
            this.Video.TabIndex = 155;
            this.Video.TabStop = true;
            this.Video.Text = "Video";
            this.Video.UseVisualStyleBackColor = false;
            this.Video.CheckedChanged += new System.EventHandler(this.Video_CheckedChanged);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.BackColor = System.Drawing.Color.Black;
            this.Customer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.ForeColor = System.Drawing.Color.White;
            this.Customer.Location = new System.Drawing.Point(861, 332);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(110, 27);
            this.Customer.TabIndex = 154;
            this.Customer.TabStop = true;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.CheckedChanged += new System.EventHandler(this.Customer_CheckedChanged);
            // 
            // Record
            // 
            this.Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record.Location = new System.Drawing.Point(3, 299);
            this.Record.Name = "Record";
            this.Record.RowHeadersWidth = 51;
            this.Record.Size = new System.Drawing.Size(775, 266);
            this.Record.TabIndex = 153;
            this.Record.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Record_CellContentClick);
            // 
            // bestCustomer
            // 
            this.bestCustomer.BackColor = System.Drawing.Color.Black;
            this.bestCustomer.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bestCustomer.Location = new System.Drawing.Point(735, 63);
            this.bestCustomer.Name = "bestCustomer";
            this.bestCustomer.Size = new System.Drawing.Size(251, 55);
            this.bestCustomer.TabIndex = 158;
            this.bestCustomer.Text = "Customer Best";
            this.bestCustomer.UseVisualStyleBackColor = false;
            this.bestCustomer.Click += new System.EventHandler(this.bestCustomer_Click);
            // 
            // best_Video
            // 
            this.best_Video.BackColor = System.Drawing.Color.Black;
            this.best_Video.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_Video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.best_Video.Location = new System.Drawing.Point(747, 133);
            this.best_Video.Name = "best_Video";
            this.best_Video.Size = new System.Drawing.Size(224, 55);
            this.best_Video.TabIndex = 157;
            this.best_Video.Text = "Best Video";
            this.best_Video.UseVisualStyleBackColor = false;
            this.best_Video.Click += new System.EventHandler(this.best_Video_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1026, 566);
            this.Controls.Add(this.bestCustomer);
            this.Controls.Add(this.best_Video);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.VideoControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VideoControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl VideoControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox Txtcost;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.TextBox TxtPlot;
        private System.Windows.Forms.TextBox TxtCopies;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtRatting;
        private System.Windows.Forms.TextBox Txttitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox postal_code;
        private System.Windows.Forms.TextBox interested_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox movie_name_rental_area;
        private System.Windows.Forms.TextBox customer_name_rental_area;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox VideoID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker ReturnVideo;
        private System.Windows.Forms.DateTimePicker IssueVideo;
        private System.Windows.Forms.Button rentalVideoDelete;
        private System.Windows.Forms.Button rentalReturnVideo;
        private System.Windows.Forms.Button rentalIssueVideo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton Rent;
        private System.Windows.Forms.RadioButton Video;
        private System.Windows.Forms.RadioButton Customer;
        private System.Windows.Forms.DataGridView Record;
        private System.Windows.Forms.Button bestCustomer;
        private System.Windows.Forms.Button best_Video;
    }
}

