using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int OrderID)
        {
            orderID = OrderID;
        }
        public int orderID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        //code to validate customer data
        public bool Validate()
        {
            var isvalid = true;
            if (OrderDate == null) isvalid = false;
            return isvalid;
        }
    }
}
