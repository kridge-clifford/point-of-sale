using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Entities;

namespace DAL
{
    public class ProductsDAL
    {
        public SQLiteConnection con = DBConnection.GetDBConnection();
        public bool SaveProduct(ProductsData data)
        {
            try
            {
                con.Open();

                using (var transaction = con.BeginTransaction())
                {
                    try
                    {
                        SQLiteCommand cmd;

                        string query = "INSERT INTO products (product_name, product_price, product_quantity, product_status, created_at, updated_at) VALUES " +
                            "(@product_name, @product_price, @product_quantity, @product_status, @created_at, @updated_at)";

                        cmd = new SQLiteCommand(query, con);
                        cmd.Parameters.AddWithValue("@product_name", data.ProductName);
                        cmd.Parameters.AddWithValue("@product_price", data.ProductPrice);
                        cmd.Parameters.AddWithValue("@product_quantity", data.ProductQuantity);
                        cmd.Parameters.AddWithValue("@product_status", data.ProductStatus);
                        cmd.Parameters.AddWithValue("@created_at", data.CreatedAt);
                        cmd.Parameters.AddWithValue("@updated_at", data.UpdatedAt);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                        return false;
                    }
                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public List<ProductsData> getProducts(int TableLimit = 0, int TableOffset = 25, string product_name = "")
        {
            List<ProductsData> data = new List<ProductsData>();
            try
            {
                con.Open();
                string query = string.Empty;
                query = "SELECT product_id, product_name, product_price, product_quantity, product_status ";
                query += "FROM products WHERE product_name LIKE @product_name ";
                query += "ORDER BY updated_at DESC LIMIT " + TableLimit.ToString() + "," + TableOffset;

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@product_name", "%" + product_name + "%");
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductsData f = new ProductsData();
                        f.ProductId = reader.GetInt32(0);
                        f.ProductName = reader.GetString(1);
                        f.ProductPrice = reader.GetDecimal(2);
                        f.ProductQuantity = reader.GetInt32(3);
                        f.ProductStatus = reader.GetString(4);
                        data.Add(f);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public int getProductCount(string product_name = "")
        {
            int rows = 0;
            try
            {
                con.Open();
                string query = string.Empty;
                query = "SELECT COUNT(product_id) FROM products WHERE product_name LIKE @product_name ";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@product_name", "%" + product_name + "%");
                rows = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return rows;
        }

        public ProductsData getProductById(int product_id)
        {
            ProductsData data = new ProductsData();
            try
            {
                con.Open();
                string query = string.Empty;
                query = "SELECT  product_id, product_name, product_price, product_quantity ";
                query += "FROM products WHERE product_id = @product_id ; ";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.ProductId = reader.GetInt32(0);
                        data.ProductName = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                        data.ProductPrice = (!reader.IsDBNull(2)) ? reader.GetDecimal(2) : 0;
                        data.ProductQuantity = (!reader.IsDBNull(3)) ? reader.GetInt32(3) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return data;
        }

        public bool updateProduct(ProductsData data)
        {
            try
            {
                con.Open();

                using (var transaction = con.BeginTransaction())
                {
                    try
                    {
                        SQLiteCommand cmd;

                        string query = string.Empty;
                        query = "UPDATE products SET product_name=@product_name, product_price=@product_price, product_quantity=@product_quantity WHERE product_id=@product_id ; ";

                        cmd = new SQLiteCommand(query, con);
                        cmd.Parameters.AddWithValue("@product_id", data.ProductId);
                        cmd.Parameters.AddWithValue("@product_name", data.ProductName);
                        cmd.Parameters.AddWithValue("@product_price", data.ProductPrice);
                        cmd.Parameters.AddWithValue("@product_quantity", data.ProductQuantity);
                        cmd.Parameters.AddWithValue("@updated_at", data.UpdatedAt);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                        return false;
                    }
                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return false;
        }
    }
}
