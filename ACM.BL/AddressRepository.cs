using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrive(int addressId)
        {
           
            Address address = new Address(addressId);

            if (addressId == 1)
            {
               
                address.AddressType = 1;
                address.City = "detroit";
                address.Country = "US";
                address.PostalCode = "90210";
                address.State = "Michigan";
                address.StreetLine1 = "111 My house";
                address.StreetLine2 = "building 2"; 
    }

            return address;
        }
        public IEnumerable<Address> Retrivebycustomerid(int customerid)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
             AddressType = 1,
            City = "detroit",
            Country = "US",
           PostalCode = "90210",
            State = "Michigan",
            StreetLine1 = "111 My house",
            StreetLine2 = "building 2",
        };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 1,
                City = "chigago",
                Country = "US",
                PostalCode = "90210",
                State = "Michigan",
                StreetLine1 = "11341 My house",
                StreetLine2 = "building 2",
            };
            addressList.Add(address);
            return addressList;
        }
        
        public bool Save(Address address)
        {
            //code that saves the product
            return true;
        }
    }
}
