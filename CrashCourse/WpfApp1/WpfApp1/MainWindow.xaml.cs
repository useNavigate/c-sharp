using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        // Holds connection to DB
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.TESTINGConnectionString"].ConnectionString;

            // Initialize connection
            sqlConnection = new SqlConnection(connectionString);


            DisplayStores();
            DisplayAllProducts();
        }

        private void DisplayStores()
        {
            // Surround DB interacting code with try catch
            try
            {
                string query = "SELECT * FROM store";
                // Connect to DB, run query and then close DB connection
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                // Use our query and connection to populate the list
                // with store names
                using (sqlDataAdapter)
                {
                    // Acts as an interface between DB and this code
                    DataTable storeTable = new DataTable();

                    sqlDataAdapter.Fill(storeTable);

                    // Define the column we are displaying in listbox
                    storeList.DisplayMemberPath = "Name";

                    // Define what is unique about each item in the list
                    storeList.SelectedValuePath = "Id";

                    // The content we will use to populate the list
                    storeList.ItemsSource = storeTable.DefaultView;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void DisplayStoreInventory()
        {
            try
            {
                string query = "SELECT * FROM product p inner join StoreInventory si ON p.Id = si.ProductId WHERE si.StoreId = @StoreId"; //@StoreId = > past storeid
                /*to use past variable you have to use something called SQL command 
                   past variable is the store that was clicked in the list box 
                 */
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("StoreId", storeList.SelectedValue);
                    DataTable inventoryTable = new DataTable();
                    sqlDataAdapter.Fill(inventoryTable);
                    storeInventory.DisplayMemberPath = "Brand";
                    storeInventory.SelectedValuePath = "Id";
                    storeInventory.ItemsSource = inventoryTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //whenever one of this item is selected display the store inventory 
        // Double click the list box to generate this
        private void storeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayStoreInventory();
        }

        private void DisplayAllProducts()
        {
            try
            {
                string query = "SELECT * FROM product";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    DataTable productTable = new DataTable();
                    sqlDataAdapter.Fill(productTable);
                    productList.DisplayMemberPath = "Brand";
                    productList.SelectedValuePath = "Id";
                    productList.ItemsSource = productTable.DefaultView;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void AddStoreClick(object sender, RoutedEventArgs e)
        {
            try
            {      // MessageBox.Show("AddStoreClicked");
                List<SqlParameter> parameters = new List<SqlParameter>()
           {
                new SqlParameter("@Name",SqlDbType.NVarChar){ Value = storeName.Text},
                new SqlParameter("@Street",SqlDbType.NVarChar){ Value = storeStreet.Text},
                new SqlParameter("@City",SqlDbType.NVarChar){ Value = storeCity.Text},
                new SqlParameter("@State",SqlDbType.NChar){ Value = storeState.Text},
                new SqlParameter("@Zip",SqlDbType.Int){ Value = storeZip.Text}
           };
                //create query to access 
                string query = "INSERT INTO Store VALUES (@Name,@Street,@City,@State,@Zip)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddRange(parameters.ToArray());
                DataTable storeTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand)) adapter.Fill(storeTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                sqlConnection.Close();
                DisplayStores();
            }
      
        }

        private void AddInventoryClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "INSERT INTO StoreInventory VALUES (@StoreId,@ProductId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@StoreId", storeList.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ProductId", productList.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayStores();
            }
        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@Manufacturer",SqlDbType.Int){ Value =prodManu.Text},
                    new SqlParameter("@Brand",SqlDbType.Int){ Value =prodBrand.Text}
                };
                string query = "INSERT INTO Product VALUES(@Manufacturer,@Brand)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddRange(parameters.ToArray());

                DataTable productTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand)) adapter.Fill(productTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayAllProducts(); //so it updates the data; 
            }
        }

        private void DeleteStoreClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Store WHERE Id =@StoreId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("@StoreId", storeList.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayStores();
            }
        }

        private void DeleteInventoryClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
