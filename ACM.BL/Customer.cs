using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer

    {
        public Customer(): this(0)
        {

        }

        public Customer(int customeriD)
        {
            CustomeriD = customeriD;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomeriD { get; private set; }
        public String EmailAddress { get; set; }
        //public String Lastname { get; set; }
        public String Firstname { get; set; }
        public String FullName 
        {
            get
              {
                string fullName = Lastname;
                if(!string.IsNullOrWhiteSpace(Firstname))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += Firstname;
                }
                return FullName;
            }
           
        }

        public static int InastanceCount { get; set; }
        private string _lastname;
        public string Lastname
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
            }
        }
        //Retrieve one customer 
        public Customer Retrieve(int custimerId)
        {
            //code that Retrieves the defiened customer
            return new Customer();
        }

        //THis already exist in its own class. we want to decouple the code and break out some things into its own class. 

        //public List<Customer> Retrieve()
        //{
        //    //code that Retrieves the defiened customer
        //    return new List<Customer>();
        //}
        ////code to save the customer 
        //public bool Save()
        //{
        //    //code that saves the defined customer 
        //    return true;
        //}
        //code to validate customer data
        public bool Validate()
        {
            //we want to make sure there is a vaild name with no empty or white spaces 
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
