using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Model.Operations
{
  public  class Orders
    {
        public long OrderId { get; set; }
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContactNo { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
