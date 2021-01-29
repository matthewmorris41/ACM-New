using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
        private readonly AddressRepository addressRepository;

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
       private AddressRepository AddressRepository { get; set; }
            
        //retrive one customer 
        public Customer Retrieve(int customerId)
        {

            //Create the instance of the customer class
            //pass in the requested id
            Customer customer = new Customer(customerId);

            //code that retrives the defined customer

            //temorary hard coded calues to return
            // a populated customer 

           if(customerId == 1)
            {
                customer.EmailAddress = "mmorris@morrismail.me";
                customer.Firstname = "matthew";
                    customer.Lastname = "morris";
                customer.AddressList = AddressRepository.Retrivebycustomerid(customerId).ToList();
            }
            return customer;
        }
        //save the current customer 
        public bool Save( Customer customer)
        {
            //code that saves the  current customer
            return true;
        }
    }
}
