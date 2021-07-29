using System.Data;
using System.Data.SqlClient;

namespace RentalStore_Video_Nw
{
    public class DbClass
    {
            public string connectionString = "Data Source=DESKTOP-LTQK306;Initial Catalog=Db_RentalStore_Video_Nw;Integrated Security=True";

            public SqlConnection sqlConnection;
            public SqlCommand sqlCommand;
            public void DatabaseUpdate(string connectionQuery)
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                sqlCommand = new SqlCommand(connectionQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            public SqlDataReader sqlDataReader;
            public DataTable GetChanges(string dbChangesQuery)
            {
                sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                sqlCommand = new SqlCommand(dbChangesQuery, sqlConnection);

                sqlDataReader = sqlCommand.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);

                sqlConnection.Close();

                return dataTable;
            }
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
            public string Address { get; set; }
            public string Interest { get; set; }
            public string PostalCode { get; set; }


            public int VideoId { get; set; }
            public string Title { get; set; }
            public string Rating { get; set; }
            public string Year { get; set; }
            public string Cost { get; set; }
            public string Copies { get; set; }
            public string Plot { get; set; }
            public string Genre { get; set; }


            public int RentalId { get; set; }
            public string IssueDate { get; set; }
            public string ReturnDate { get; set; }
            public string Status { get; set; }        
        }
    }
