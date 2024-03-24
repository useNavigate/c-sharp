using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using dbPractice_1.FIRSTPROJECTDataSetTableAdapters;
using System.Reflection.Emit;


namespace dbPractice_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        string connectionString;

        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dbPractice_1.Properties.Settings.FIRSTPROJECTConnectionString"].ConnectionString;

            // Initialize connection
            connection = new SqlConnection(connectionString);


            PopulateAllRecipes();
            PopulateAllIngredients();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        { 
            
        }

        private void PopulateAllRecipes()
        {
            string query = "SELECT * FROM Recipe";
            //connect to DB, run query and then close DB connection 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

            using (sqlDataAdapter)
            {
                DataTable recipeTable = new DataTable();
                sqlDataAdapter.Fill(recipeTable);
                RecipeList.DisplayMemberPath = "Name";
                RecipeList.ItemsSource = recipeTable.DefaultView;

            }
        }

        private void PopulateAllIngredients()
        {
            string query = "SELECT * FROM Ingredient";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

            using (sqlDataAdapter)
            { 
                DataTable ingreTable = new DataTable();
                sqlDataAdapter.Fill(ingreTable);
                IngreList.DisplayMemberPath = "Name";
                IngreList.ItemsSource = ingreTable.DefaultView;
            }
        }


        //private void PopulateTheIngredients()
        //{

        //        string query = "SELECT a.Name FROM Ingredient a " +
        //                       "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
        //                       "WHERE b.RecipeId = @RecipeId";
        //        /*to use past variable you have to use something called SQL command 
        //           past variable is the store that was clicked in the list box 
        //         */
        //        SqlCommand sqlCommand = new SqlCommand(query, connection);
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //        DataRowView drv = (DataRowView)RecipeList.SelectedValue;

        //        int recipeId = (int)drv["Id"];
        //        using (sqlDataAdapter)
        //        {

        //            sqlCommand.Parameters.AddWithValue("@RecipeId", recipeId);
        //            DataTable ingredientTable = new DataTable();
        //            sqlDataAdapter.Fill(ingredientTable);
        //            IngreList.DisplayMemberPath = "Name";
        //            IngreList.SelectedValuePath = "Id";
        //            IngreList.ItemsSource = ingredientTable.DefaultView;
        //        }

        //}

        private void PopulateTheIngredients()
        {
            if (RecipeList.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)RecipeList.SelectedItem;
                int recipeId = (int)drv["Id"];

                string query = "SELECT a.Name FROM Ingredient a " +
                               "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                               "WHERE b.RecipeId = @RecipeId";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@RecipeId", recipeId);
                    DataTable ingredientTable = new DataTable();
                    sqlDataAdapter.Fill(ingredientTable);
                    IngreList.DisplayMemberPath = "Name";
                    IngreList.SelectedValuePath = "Id";
                    IngreList.ItemsSource = ingredientTable.DefaultView;
                }
            }
        }


        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlParameter> parameter = new List<SqlParameter>() {
                    new SqlParameter("@Name", SqlDbType.NVarChar) { Value = RecipeName.Text },
                    new SqlParameter("@PrepTime", SqlDbType.NVarChar) { Value = RecipePrepTime.Text }
                    };

                //create query to access 
                string query = "INSERT INTO Recipe VALUES(@Name,@PrepTime)";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                connection.Open();
                sqlCommand.Parameters.AddRange(parameter.ToArray());
                DataTable storeTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand)) adapter.Fill(storeTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                PopulateAllRecipes();
            }

        }

        private void RecipeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PopulateTheIngredients();
        }

        private void IngreList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }


        private void AddIngredientClick(object sender, RoutedEventArgs e)
        {
            SqlParameter parameter = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = AddIngreTextBox.Text };
            string query = "INSERT INTO Ingredient VALUES(@Name)";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@Name", parameter.Value);
            sqlCommand.ExecuteScalar();

            connection.Close();
            PopulateAllIngredients();
    
        }
    }
}
