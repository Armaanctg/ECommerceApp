using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Model.Operations
{
  public  class OrderDetails
    {
        public long OrderId { get; set; }     
        public Decimal Price { get; set; }
        public Decimal Discount { get; set; }
        public int Quantity { get; set; }
        public Orders Order { get; set; }
    }

  
}
