using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class OrderDetailBLL
    {
        public static bool saveOrders(OrdersData order_data, List<OrderDetailData> order_detail_list)
        {
            OrderDetailDAL order = new OrderDetailDAL();
            return order.addOrder(order_data, order_detail_list);
        }

        public static List<SalesData> getSalesProductByDate(int TableLimit = 0, int TableOffset = 25, string from_date_time = "", string to_date_time = "")
        {
            OrderDetailDAL data = new OrderDetailDAL();
            return data.getSalesProductByDate(TableLimit, TableOffset,from_date_time, to_date_time);
        }
    }
}
