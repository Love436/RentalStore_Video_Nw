using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalStore_Video_Nw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbClass dbClass = new DbClass();

        // add new customer to database

        private void addCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(MobileNo.Text)  
                    && !string.IsNullOrEmpty(Address.Text) && !string.IsNullOrEmpty(interested_in.Text) 
                    && !string.IsNullOrEmpty(postal_code.Text))
                {
                    dbClass.Name = TxtName.Text;
                    dbClass.Mobile = MobileNo.Text;
                    dbClass.Address = Address.Text;
                    dbClass.Interest = interested_in.Text;
                    dbClass.PostalCode = postal_code.Text;

                    string insertQuery = "Insert into Customers values('" + dbClass.Name + "','" + dbClass.Mobile + "','" + dbClass.Address + "','" + dbClass.Interest + "','" + dbClass.PostalCode + "')";
                    
                    dbClass.DatabaseUpdate(insertQuery);
                    Address.Text = "";
                    MobileNo.Text = "";
                    TxtName.Text = "";
                    interested_in.Text = "";
                    postal_code.Text = "";

                    MessageBox.Show("Customer is added successfully, thank you");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please be sure before submit, all the inputs are required");
            }
        }
        
        // update customer record

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CustomerID.Text) && !string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(MobileNo.Text)
                        && !string.IsNullOrEmpty(Address.Text) && !string.IsNullOrEmpty(interested_in.Text)
                        && !string.IsNullOrEmpty(postal_code.Text))
                    {
                    dbClass.CustomerId = Convert.ToInt32(CustomerID.Text);
                    dbClass.Name = TxtName.Text;
                    dbClass.Mobile = MobileNo.Text;
                    dbClass.Address = Address.Text;
                    dbClass.Interest = interested_in.Text;
                    dbClass.PostalCode = postal_code.Text;

                    string updateQuery = "update Customers set Name='" + dbClass.Name + "',Mobile='" + dbClass.Mobile + "',Address='" + dbClass.Address + "',Interest='" + dbClass.Interest + "',PostalCode='" + dbClass.PostalCode + "' where CustomerId=" + dbClass.CustomerId + "";
                    
                    dbClass.DatabaseUpdate(updateQuery);
                    CustomerID.Text = "";
                    Address.Text = "";
                    MobileNo.Text = "";
                    TxtName.Text = "";
                    interested_in.Text = "";
                    postal_code.Text = "";
                    MessageBox.Show("Customer is updated successfully, thank you");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please be sure before submit, all the inputs are required");
            }
        }
        
        // del customer data


            private void delCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerID.Text != "")
                {
                    dbClass.CustomerId = Convert.ToInt32(CustomerID.Text);
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure to delete Customer", "Confirm Customer ", messageBoxButtons);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "delete from Customers where CustomerId=" + dbClass.CustomerId + "";
                        dbClass.DatabaseUpdate(deleteQuery);

                        CustomerID.Text = "";
                        Address.Text = "";
                        MobileNo.Text = "";
                        TxtName.Text = "";
                        interested_in.Text = "";
                        postal_code.Text = "";
                        interested_in.Text = "";
                        MessageBox.Show("Customer is deleted successfully");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check,Customer is not valid");
            }
        }

        // add new video to database

        private void AddVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txttitle.Text) && !string.IsNullOrEmpty(TxtRatting.Text) 
                    && !string.IsNullOrEmpty(TxtYear.Text)
                        && !string.IsNullOrEmpty(Txtcost.Text) && !string.IsNullOrEmpty(TxtCopies.Text)
                        && !string.IsNullOrEmpty(TxtPlot.Text) && !string.IsNullOrEmpty(TxtGenre.Text))
                {
                    dbClass.Title = Txttitle.Text;
                    dbClass.Rating = TxtRatting.Text;
                    dbClass.Year = TxtYear.Text;
                    dbClass.Cost = Txtcost.Text;
                    dbClass.Copies = TxtCopies.Text;
                    dbClass.Plot = TxtPlot.Text;
                    dbClass.Genre = TxtGenre.Text;

                    string insertQuery = "Insert into Videos values('" + dbClass.Title + "','" + dbClass.Rating + "','" + dbClass.Year + "','" + dbClass.Cost + "','" + dbClass.Copies + "','" + dbClass.Plot + "','" + dbClass.Genre + "')";

                    dbClass.DatabaseUpdate(insertQuery);
                    VideoID.Text = "";
                    Txttitle.Text = "";
                    TxtRatting.Text = "";
                    TxtYear.Text = "0";
                    Txtcost.Text = "";
                    TxtCopies.Text = "";
                    TxtPlot.Text = "";
                    TxtGenre.Text = "";
                    MessageBox.Show("Video is Updated successfully, thank you");
                }
                else
                {
                    MessageBox.Show("Please be sure before submit, all the inputs are required");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please be sure before submit, all the inputs are required");
            }
        }
        
        // delete video record 

        private void delVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (VideoID.Text != "")
                {

                    dbClass.VideoId = Convert.ToInt32(VideoID.Text);
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure to delete Movie", "Delete Confirmation", messageBoxButtons);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "Delete from Videos where VideoId=" + dbClass.VideoId + "";
                        dbClass.DatabaseUpdate(deleteQuery);
                        VideoID.Text = "";
                        Txttitle.Text = "";
                        TxtRatting.Text = "";
                        TxtYear.Text = "0";
                        Txtcost.Text = "";
                        TxtCopies.Text = "";
                        TxtPlot.Text = "";
                        TxtGenre.Text = "";
                        MessageBox.Show("Video is Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Please check,Video is not Invalid");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check,Video is not Invalid");
            }

        }
        
        // update video record

        private void updateVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(VideoID.Text) && !string.IsNullOrEmpty(Txttitle.Text) && !string.IsNullOrEmpty(TxtRatting.Text)
                    && !string.IsNullOrEmpty(TxtYear.Text)
                        && !string.IsNullOrEmpty(Txtcost.Text) && !string.IsNullOrEmpty(TxtCopies.Text)
                        && !string.IsNullOrEmpty(TxtPlot.Text) && !string.IsNullOrEmpty(TxtGenre.Text))
                {
                    dbClass.VideoId = Convert.ToInt32(VideoID.Text);
                    dbClass.Title = Txttitle.Text;
                    dbClass.Rating = TxtRatting.Text;
                    dbClass.Year = TxtYear.Text;
                    dbClass.Cost = Txtcost.Text;
                    dbClass.Copies = TxtCopies.Text;
                    dbClass.Plot = TxtPlot.Text;
                    dbClass.Genre = TxtGenre.Text;


                    string updateQuery = "Update Videos set Title='" + dbClass.Title + "',Rating='" + dbClass.Rating + "',Year=" + dbClass.Year + ",Cost=" + dbClass.Cost + ",Copies=" + dbClass.Copies + ",Plot='" + dbClass.Plot + "',Genre='" + dbClass.Genre + "' where VideoId=" + dbClass.VideoId + "";
                    dbClass.DatabaseUpdate(updateQuery);
                    VideoID.Text = "";
                    Txttitle.Text = "";
                    TxtRatting.Text = "";
                    TxtYear.Text = "0";
                    Txtcost.Text = "";
                    TxtCopies.Text = "";
                    TxtPlot.Text = "";
                    TxtGenre.Text = "";
                    MessageBox.Show("Video is updated, thank you");
                }
                else
                {
                    MessageBox.Show("Please be sure before submit, all the inputs are required");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please be sure before submit, all the inputs are required");
            }
        }
        
        // issue rental video 

        private void rentalIssueVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerID.Text != "" && VideoID.Text != "")
                {
                    dbClass.CustomerId = Convert.ToInt32(CustomerID.Text);
                    dbClass.VideoId = Convert.ToInt32(VideoID.Text);
                    dbClass.IssueDate = IssueVideo.Text;
                    dbClass.Status = "Issued";

                    string insertQuery = "Insert into Rentals values(" + dbClass.CustomerId + "," + dbClass.VideoId + ",'" + dbClass.IssueDate + "','" + dbClass.ReturnDate + "','" + dbClass.Status + "')";
                    dbClass.DatabaseUpdate(insertQuery);

                    VideoID.Text = "";
                    CustomerID.Text = "";
                    MessageBox.Show("Video is issued successfully, thank you");
                }
                else
                {
                    MessageBox.Show("Please be sure before submit, all the inputs are required");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please be sure before submit, all the inputs are required");
            }
        }

        // delete rental video

        private void rentalVideoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbClass.RentalId > 0)
                {

                    dbClass.CustomerId = Convert.ToInt32(CustomerID.Text);
                    dbClass.VideoId = Convert.ToInt32(VideoID.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure to delete the booked video ", "Confirm Video ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "Delete from Rentals where RentalId=" + dbClass.RentalId + "";
                        dbClass.DatabaseUpdate(deleteQuery);

                        VideoID.Text = "";
                        CustomerID.Text = "";
                        MessageBox.Show("Video is deleted successfully, thank you");
                    }
                }
                else
                {
                    MessageBox.Show("Please check, Invalid Video");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check, Invalid Video");
            }


        }

        // return video 

        private void rentalReturnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if ( CustomerID.Text != "" && VideoID.Text != "")
                {
                    dbClass.CustomerId = Convert.ToInt32(CustomerID.Text);
                    dbClass.VideoId = Convert.ToInt32(VideoID.Text);
                    dbClass.IssueDate = IssueVideo.Text;
                    dbClass.ReturnDate = ReturnVideo.Text;
                    dbClass.Status = "Returned";
                    DateTime date = Convert.ToDateTime(IssueVideo.Text);
                    string days = (DateTime.Now - date).TotalDays.ToString();

                    string updateQuery = "update  Rentals set IssueDate='" + dbClass.IssueDate + "',ReturnDate='" + dbClass.Status + "',Status='" + dbClass.Status + "' where RentalId=" + dbClass.RentalId + "";
                    dbClass.DatabaseUpdate(updateQuery);

                    DataTable dataTable = dbClass.GetChanges("Select * from Videos where VideoId=" + Convert.ToInt32(VideoID.Text) + "");
                    int cost = Convert.ToInt32(dataTable.Rows[0]["Cost"].ToString());

                    VideoID.Text = "";
                    CustomerID.Text = "";
                    MessageBox.Show("issue video is returned, your bill is generated successfully, bill is $" + (Convert.ToDouble(days) * cost));
                }
                else
                {
                    MessageBox.Show("Please be sure before submit, all the inputs are required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please be sure before submit, all the inputs are required");
            }
        }

        // according to the car value it fetech record form database and show it in the grid panel

        int selectedForm = 0;
        private void Record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (selectedForm)
            {
                case 1:

                    CustomerID.Text = Record.CurrentRow.Cells[0].Value.ToString();
                    customer_name_rental_area.Text = Record.CurrentRow.Cells[1].Value.ToString();
                    TxtName.Text = Record.CurrentRow.Cells[1].Value.ToString();
                    MobileNo.Text = Record.CurrentRow.Cells[2].Value.ToString();
                    Address.Text = Record.CurrentRow.Cells[3].Value.ToString();
                    interested_in.Text = Record.CurrentRow.Cells[4].Value.ToString();
                    postal_code.Text = Record.CurrentRow.Cells[5].Value.ToString();
                    break;

                case 2:
                    dbClass.RentalId = Convert.ToInt32(Record.CurrentRow.Cells[0].Value.ToString());
                    CustomerID.Text = Record.CurrentRow.Cells[1].Value.ToString();
                    VideoID.Text = Record.CurrentRow.Cells[2].Value.ToString();
                    IssueVideo.Text = Record.CurrentRow.Cells[3].Value.ToString();
                    ReturnVideo.Text = Record.CurrentRow.Cells[4].Value.ToString();
                    break;

                case 3:
                    VideoID.Text = Record.CurrentRow.Cells[0].Value.ToString();
                    movie_name_rental_area.Text = Record.CurrentRow.Cells[1].Value.ToString();
                    Txttitle.Text = Record.CurrentRow.Cells[1].Value.ToString();
                    TxtRatting.Text = Record.CurrentRow.Cells[2].Value.ToString();
                    TxtYear.Text = Record.CurrentRow.Cells[3].Value.ToString();
                    Txtcost.Text = Record.CurrentRow.Cells[4].Value.ToString();
                    TxtCopies.Text = Record.CurrentRow.Cells[5].Value.ToString();
                    TxtPlot.Text = Record.CurrentRow.Cells[6].Value.ToString();
                    TxtGenre.Text = Record.CurrentRow.Cells[7].Value.ToString();
                    break;
            }
            selectedForm = 0;
        }

        // this concept is showing best video

        private void best_Video_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dbClass.GetChanges("select * from Videos");
            int index = 0;
            string videoName = "";
            while (index < dataTable.Rows.Count)
            {
                DataTable Rental = dbClass.GetChanges("select * from Rentals where VideoId=" + Convert.ToInt32(dataTable.Rows[index]["VideoId"]) + "");

                int length = 0;
                if (Rental.Rows.Count > length)
                {
                    videoName = dataTable.Rows[index]["Title"].ToString();
                    length = Rental.Rows.Count;
                }
                index++;
            }
            MessageBox.Show(videoName + " is the best Video, Congratulations,take a look");
        }

        // showing best customer

        private void bestCustomer_Click(object sender, EventArgs e)
        {
        DataTable customers = dbClass.GetChanges("select * from Customers");

            int index = 0;
            string CustomerName = "";

            while (index < customers.Rows.Count)
            {
                DataTable dataTablelRental = dbClass.GetChanges("select * from Rentals where CustomerId=" + Convert.ToInt32(customers.Rows[index]["CustomerId"]) + "");

                int length = 0;
                if (dataTablelRental.Rows.Count > length)
                {
                    CustomerName = customers.Rows[index]["Name"].ToString();
                    length = dataTablelRental.Rows.Count;
                }
                index++;
            }
            MessageBox.Show(CustomerName + " is the best Customer, Congratulations, Have a great day ahead");
        }

        // changing year 

        private void TxtYear_TextChanged(object sender, EventArgs e)
        {
                int year = Convert.ToInt32(TxtYear.Text.ToString());
                int currentYear = DateTime.Now.Year;

                if ((currentYear - year) > 5)
                {
                    Txtcost.Text = "2";
                }
                else
                {
                    Txtcost.Text = "5";
                }
        }

        // showing values to grid through a var passed to select function that fetch data according to the table name

        private void Customer_CheckedChanged(object sender, EventArgs e)
        {
            selectedForm = 1;
            DataTable customers = dbClass.GetChanges("select * from Customers");
            Record.DataSource = customers;
        }

        // showing values to grid through a var passed to select function that fetch data according to the table name

        private void Rent_CheckedChanged(object sender, EventArgs e)
        {
            selectedForm = 2;
            DataTable rentals = dbClass.GetChanges("select * from Rentals");
            Record.DataSource = rentals;
        }

        // showing values to grid through a var passed to select function that fetch data according to the table name

        private void Video_CheckedChanged(object sender, EventArgs e)
        {
            selectedForm = 3;
            DataTable videos = dbClass.GetChanges("select * from Videos");
            Record.DataSource = videos;
        }

    }
}
