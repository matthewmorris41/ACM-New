using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    }
    class Productcs
    {
    public Productcs()
    {

    }
    public Productcs(int productid)
    {
        ProductId = productid;
    }
          public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Desctiption { get; set; }
        public decimal? CurrentPrice { get; set; }


    //code to validate the product
    public bool Validate()
        {
        //we want to make sure there is a vaild name with no empty or white spaces and no null prices
        var isValid = true;
        if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
        if (CurrentPrice == null) isValid = false;

        return isValid;
    }
    }

