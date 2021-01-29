using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public Order Retrive(int orderid)
        {

            Order order = new Order(orderid);

                  if (orderid == 10)
            {

                //hardcoded year just go get data. 
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                                   new TimeSpan(7, 0, 0));
            }
            
                //code that Retrieves the defiened Order
           return order;
            
        }
    }
}
