using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    internal class AddressRepository
    {
        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Get data of specific address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address getData(int addressId)
        {
            Address address = new Address(addressId);
            //code to get data of address by id

            //temp
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Street = "Polna";
                address.City = "Warszawa";
                address.Country = "Polska";
                address.PostalCode = "00-000";
            }
            return address;
        }

        /// <summary>
        /// Get all client addresses
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public IEnumerable<Address> GetByClientId(int clientId)
        {
            //code will get all defined client addreses

            //temp
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                Street = "testowa",
                City = "Warszawa",
                PostalCode = "00-000",
                Country = "Polska"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                Street = "Jakas",
                City = "Krakow",
                PostalCode = "22-222",
                Country = "Polska"
            };
            addressList.Add(address);
            return addressList;
        }
    }
}
