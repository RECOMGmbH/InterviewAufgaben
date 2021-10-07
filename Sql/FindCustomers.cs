using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sql
{
    /*
    Given a Table "Customers" in an SQL-Server database with these columns
    - int Id
    - nvarchar(256) FirstName
    - nvarchar(256) LastName
    - nvarchar(256) AccountName
    - nvarchar(256) PasswordMd5Hash
    - nvarchar(256) InitialPassword
    - bit ResetPassword
    
    a dialog, where the user can search for customers by their First-/lastname
    
    a service class performing the actual database query.
    
    
    What's wrong with this code? 
     */
    public class FindCustomersDialog : Form
    {
        private TextBox _firstNameTextBox = new TextBox();
        private TextBox _lastNameTextBox = new TextBox();
        private Button _searchButton = new Button();

        private DataGrid _resultGrid = new DataGrid();

        public FindCustomersDialog()
        {
            // Setup Form layout
            _searchButton.Click += SearchButtonOnClick;
        }

        private void SearchButtonOnClick(object sender, EventArgs e)
        {
            var service = new CustomersSearchService();
            var foundCustomers = service.Find(_firstNameTextBox.Text, _lastNameTextBox.Text);

            _resultGrid.DataSource = foundCustomers;
        }
    }

    public class CustomersSearchService
    {
        public DataTable Find(string firstName, string lastName)
        {
            var cnx = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            cnx.Open();
            var query = new SqlCommand(
                $"SELECT Id, FirstName, LastName FROM Customers WHERE FirstName ='{firstName}' AND LastName ='{lastName}'");

            query.Connection = cnx;

            var adapter = new SqlDataAdapter(query);

            var dt = new DataTable("Customers");
            adapter.Fill(dt);
            
            return dt;
        }
    }
}