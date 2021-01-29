using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        public Productcs Retrieve(int productId)
        {
            //code that Retrieves the product
            Productcs productcs = new Productcs(productId);

            if (productId == 2)
            {
                productcs.ProductName = "Sunflowers";
                productcs.Desctiption = "an Assorted size set of 4 bright yellow mini sunflowers";
                productcs.CurrentPrice = 15.99M;
            }
            return productcs;
        }



        public bool Save()
        {
            //code that saves the product
            return true;
        }
    }
}
