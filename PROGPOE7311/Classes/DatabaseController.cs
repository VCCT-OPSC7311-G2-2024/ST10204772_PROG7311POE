using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using PROGPOE7311;

namespace PROGPOE7311.Classes
{
    public class DatabaseController
    {
        public SqlConnection constring = new SqlConnection(PROGPOE7311.Properties.Resources.ConnectionString);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        string query = "";
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Checks if User exists in system
        /// </summary>
        public bool IsValidUser(string email, string password)
        {
            using (constring)
            {
                string query = "SELECT UserID, FullName, UserType FROM [User] WHERE Email = @Email AND Password = @Password";

                CurrentUser cal = new CurrentUser();
                using (SqlCommand command = new SqlCommand(query, constring))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        constring.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int uID = int.Parse(reader["UserID"].ToString());
                                string uName = reader["FullName"].ToString();
                                string uType = reader["UserType"].ToString();

                                cal = new CurrentUser(uID, uName, email, password, uType);
                                return true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception

                    }
                    finally
                    {
                        constring.Close();
                    }
                }
            }
            return false;
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Add a new Product to the Database
        /// </summary>
        public bool AddProduct(string productName, string productCategory, string ProdDate, int uID)
        {
            using (constring)
            {
                string query = "INSERT INTO Product (ProdName, ProdCategory, ProdDate, UserID) " +
                               "VALUES (@ProductName, @ProductCategory, @ProdDate, @UserID)";

                using (SqlCommand command = new SqlCommand(query, constring))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductCategory", productCategory);
                    command.Parameters.AddWithValue("@ProdDate", DateTime.Parse(ProdDate));
                    command.Parameters.AddWithValue("@UserID", uID);

                    try
                    {
                        constring.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception

                        return false;
                    }
                    finally
                    {
                        constring.Close();
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Creates A Farmer Account into the Database
        /// </summary>
        /// 
        public bool AddFarmer(string userName, string userEmail, string userCell, string uPassword)
        {
            using (constring)
            {
                string query = "INSERT INTO [User] (FullName, Email, Cell, Password, UserType) " +
                      "VALUES (@UserName, @UserEmail, @UserCell, @UPassword, @UserType)";
                using (SqlCommand cmd = new SqlCommand(query, constring))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@UserEmail", userEmail);
                    cmd.Parameters.AddWithValue("@UserCell", userCell);
                    cmd.Parameters.AddWithValue("@UPassword", uPassword);
                    cmd.Parameters.AddWithValue("@UserType", "Farmer");

                    constring.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            using (constring)
            {
                constring.Open();

                string query = "SELECT DISTINCT ProdCategory FROM Product";
                using (SqlCommand command = new SqlCommand(query, constring))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader["ProdCategory"].ToString());
                        }
                    }
                }
            }

            return categories;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// For Security purposes, checks if Logged in User's password is "P@ssword1" as that is base generated password,
        /// User will be prompted to change it immediately
        /// </summary>

        public bool IsGeneratedPassword()
        {
            using (constring)
            {
                CurrentUser cUser = new CurrentUser();
                int cID = cUser.GetUserID();
                
                string query = "SELECT UserID FROM [User] WHERE UserID = @UserID AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, constring))
                {
                    cmd.Parameters.AddWithValue("@UserID", cID);
                    cmd.Parameters.AddWithValue("@Password", "P@ssword1");

                    try
                    {
                        constring.Open();
                        object uId = cmd.ExecuteScalar();

                        if (uId != null)
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    return false;
                }
            }

        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public List<Products> GetProducts(string category)
        {
            List<Products> products = new List<Products>();
            using (constring)
            {
                Validation val = new Validation();
                
                string query = "SELECT ProdName, ProdCategory, ProdDate, [User].FullName FROM Product JOIN [User] ON [User].UserID = Product.UserID WHERE ProdCategory = @ProdCategory";

                using (SqlCommand command = new SqlCommand(query, constring))
                {
                    if (!string.IsNullOrEmpty(category))
                    {
                        command.Parameters.AddWithValue("@ProdCategory", category);
                    }

                    constring.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Products(reader["ProdName"].ToString(), reader["ProdCategory"].ToString(), DateTime.Parse(reader["ProdDate"].ToString()), reader["FullName"].ToString()));
                        }
                    }
                }
                constring.Close();
            }
            
            return products;
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public DataTable ResetTable()
        {
            DataTable RegTable = new DataTable();
            using (constring)
            {
                Validation val = new Validation();
                string query = "SELECT ProdName AS [Product Name], ProdCategory AS [Product Category], ProdDate AS [Production Date], [User].FullName AS [Farmer] FROM Product JOIN [User] ON [User].UserID = Product.UserID";

                using (SqlCommand command = new SqlCommand(query, constring))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {  
                        adapter.Fill(RegTable);
                    }
                }
            }
            return RegTable;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public DataTable GetProductsByDateRange(DateTime? startDate, DateTime? endDate)
        {
            Validation validation = new Validation();
            using (constring)
            {
                string query = "SELECT ProdName AS [Product Name], ProdCategory AS [Product Category], ProdDate AS [Production Date], [User].UserID FROM Product JOIN [User] ON [User].UserID = Product.UserID";

                if (startDate != null)
                {
                    query += " WHERE ProdDate >= @StartDate";
                }
                if (endDate != null)
                {
                    query += " AND ProdDate <= @EndDate";
                }

                using (SqlCommand command = new SqlCommand(query, constring))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = command;
                        DataTable DateRangeTable = new DataTable();
                        adapter.Fill(DateRangeTable);
                        return DateRangeTable;
                    }
                }
            }
        }
    }
}

//-------------------------------.o0o.END OF FILE.o0o.-------------------------------------