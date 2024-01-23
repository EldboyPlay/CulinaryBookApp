using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulinaryBookApp
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public DataTable GetAllDishes()
        {
            DataTable dtDishes = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT DishCode, DishType, DishWeight, CookingOrder, Calories, Carbohydrates FROM Dish";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dtDishes);
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show(ex.Message);
                }
            }

            return dtDishes;
        }

        public void AddDish(string dishType, int dishWeight, string cookingOrder, int calories, int carbohydrates)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Dish (DishType, DishWeight, CookingOrder, Calories, Carbohydrates) VALUES (@DishType, @DishWeight, @CookingOrder, @Calories, @Carbohydrates)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DishType", dishType);
                        cmd.Parameters.AddWithValue("@DishWeight", dishWeight);
                        cmd.Parameters.AddWithValue("@CookingOrder", cookingOrder);
                        cmd.Parameters.AddWithValue("@Calories", calories);
                        cmd.Parameters.AddWithValue("@Carbohydrates", carbohydrates);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении блюда: " + ex.Message);
                }
            }
        }

        public void DeleteDish(int dishCode)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Dish WHERE DishCode = @DishCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DishCode", dishCode);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении блюда: " + ex.Message);
                }
            }
        }

        public void UpdateDishInDatabase(int dishCode, string dishType, int dishWeight, string cookingOrder, int calories, int carbohydrates)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Dish SET DishType = @DishType, DishWeight = @DishWeight, CookingOrder = @CookingOrder, Calories = @Calories, Carbohydrates = @Carbohydrates WHERE DishCode = @DishCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DishCode", dishCode);
                        cmd.Parameters.AddWithValue("@DishType", dishType);
                        cmd.Parameters.AddWithValue("@DishWeight", dishWeight);
                        cmd.Parameters.AddWithValue("@CookingOrder", cookingOrder);
                        cmd.Parameters.AddWithValue("@Calories", calories);
                        cmd.Parameters.AddWithValue("@Carbohydrates", carbohydrates);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                }
            }

        }

        public DataTable GetAllProducts()
        {
            DataTable dtProducts = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ProductCode, ProductName, ProductVolume, UnitOfMeasure FROM Product";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dtProducts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dtProducts;
        }



        public void AddProduct(string productName, int productVolume, string unitOfMeasure)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Product (ProductName, ProductVolume, UnitOfMeasure) VALUES (@ProductName, @ProductVolume, @UnitOfMeasure)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductVolume", productVolume);
                        cmd.Parameters.AddWithValue("@UnitOfMeasure", unitOfMeasure);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении продукта: " + ex.Message);
                }
            }
        }




        public void DeleteProduct(int productCode)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Product WHERE ProductCode = @ProductCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", productCode);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении продукта: " + ex.Message);
                }
            }
        }


        public void UpdateProductInDatabase(int productCode, string productName, int productVolume, string unitOfMeasure)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Product SET ProductName = @ProductName, ProductVolume = @ProductVolume, UnitOfMeasure = @UnitOfMeasure WHERE ProductCode = @ProductCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", productCode);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductVolume", productVolume);
                        cmd.Parameters.AddWithValue("@UnitOfMeasure", unitOfMeasure);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении продукта: " + ex.Message);
                }
            }
        }



    }

}
