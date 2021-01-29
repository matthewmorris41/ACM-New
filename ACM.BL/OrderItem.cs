using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderitemid)
        {
           Orderitemid = orderitemid;
        }
        public int Orderitemid { get;  private set;  }
        public decimal? PurchasePrice { get; set; }
        public int productid { get; set; }
        public int Quantity { get; set; }


        public OrderItem Retrieve(int OrderID)
        {
            //code that Retrieves the defiened Order
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            //code that Retrieves the defiened Order
            return new List<OrderItem>();
        }
        //code to save the Order 
        public bool Save()
        {
            //code that saves the defined  Order
            return true;
        }
        //code to validate customer data
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (productid <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
