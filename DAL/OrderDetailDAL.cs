using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Entities;

namespace DAL
{
    public class OrderDetailDAL
    {
        public SQLiteConnection con = DBConnection.GetDBConnection();
        public bool addOrder(OrdersData order_data, List<OrderDetailData> order_detail_list)
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
                        query = "INSERT INTO orders(paid_amount, created_at, updated_at) ";
                        query += "VALUES (@paid_amount, @created_at, @updated_at); ";
                        query += "SELECT last_insert_rowid(); ";
                        cmd = new SQLiteCommand(query, con);
                        cmd.Parameters.AddWithValue("@paid_amount", order_data.PaidAmount);
                        cmd.Parameters.AddWithValue("@created_at", order_data.CreatedAt);
                        cmd.Parameters.AddWithValue("@updated_at", order_data.UpdatedAt);
                        int last_order_id = Convert.ToInt32(cmd.ExecuteScalar());


                        foreach (OrderDetailData r in order_detail_list)
                        {
                            query = "INSERT INTO order_detail (order_id, product_id, quantity, price, created_at, updated_at) ";
                            query += "VALUES (@order_id, @product_id, @quantity, @price, @created_at, @updated_at) ";
                            cmd = new SQLiteCommand(query, con);
                            cmd.Parameters.AddWithValue("@order_id", last_order_id);
                            cmd.Parameters.AddWithValue("@product_id", r.ProductId);
                            cmd.Parameters.AddWithValue("@quantity", r.Quantity);
                            cmd.Parameters.AddWithValue("@price", r.Price);
                            cmd.Parameters.AddWithValue("@created_at", r.CreatedAt);
                            cmd.Parameters.AddWithValue("@updated_at", r.UpdatedAt);
                            cmd.ExecuteNonQuery();
                        }

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

        public List<SalesData> getSalesProductByDate(int TableLimit = 0, int TableOffset = 25, string from_date_time = "", string to_date_time = "")
        {
            Console.WriteLine("from_date_time " + from_date_time);
            Console.WriteLine("to_date_time " + to_date_time);
            List<SalesData> data = new List<SalesData>();
            try
            {
                con.Open();
                string query = string.Empty;
                query = "SELECT products.product_name,  CASE WHEN SUM(order_detail.quantity) IS NULL THEN 0 ELSE SUM(order_detail.quantity) END AS quantity,  CASE WHEN SUM(order_detail.price) IS NULL THEN '0' ELSE SUM(order_detail.price) END AS price FROM products LEFT JOIN order_detail ON products.product_id = order_detail.product_id LEFT JOIN orders ON orders.order_id = order_detail.order_id ";
                query += "WHERE DATE(orders.created_at) BETWEEN @from_date_time AND @to_date_time OR orders.created_at IS NULL OR products.product_id > 0 ";           
                query += "GROUP BY products.product_id ORDER BY products.product_name ASC LIMIT " + TableLimit.ToString() + "," + TableOffset;

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@from_date_time", from_date_time);
                cmd.Parameters.AddWithValue("@to_date_time", to_date_time);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SalesData f = new SalesData();
                        f.ProductName = reader.GetString(0);
                        f.TotalQuantity = reader.GetInt32(1);
                        f.TotalPrice = reader.GetDecimal(2);
                        data.Add(f);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return data;
        }
    }
}
