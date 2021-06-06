using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace PointOfSale
{
    public class Globals
    {
        public static int productShowId = 0;
        public static bool isExit = false;
        public static int orderProductId = 0;

        public static List<OrderDetailData> orderDetailList = new List<OrderDetailData>();
    }
}
