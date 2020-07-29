using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Model.Operations.Setup
{
    public class Product
    {
        public long  ProductId { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public long CategoryId { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

    }
}
