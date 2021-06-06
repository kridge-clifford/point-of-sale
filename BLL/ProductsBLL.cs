using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class ProductsBLL
    {
        public static bool SaveProduct(ProductsData data)
        {
            ProductsDAL product = new ProductsDAL();
            return product.SaveProduct(data);
        }

        public static bool updateProduct(ProductsData data)
        {
            ProductsDAL product = new ProductsDAL();
            return product.updateProduct(data);
        }

        public static List<ProductsData> getProducts(int TableLimit = 0, int TableOffset = 25, string product_name = "")
        {
            ProductsDAL data = new ProductsDAL();
            return data.getProducts(TableLimit, TableOffset, product_name);
        }

        public static int getProductCount(string product_name)
        {
            ProductsDAL data = new ProductsDAL();
            return data.getProductCount(product_name);
        }

        public static ProductsData getProductById(int product_id)
        {
            ProductsDAL data = new ProductsDAL();
            return data.getProductById(product_id);
        }
    }
}
