using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class ClientRepository
    {
        private AddressRepository addressRepository { get; set; }

        public ClientRepository()
        {
            addressRepository = new AddressRepository();
        }
        /// <summary>
        /// Save current client
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //save client
            return true;
        }

        /// <summary>
        /// Get data of specific client
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public Client getData(int clientId)
        {
            Client client = new Client(clientId);
            client.AddressList = addressRepository.GetByClientId(clientId).ToList();
            //temp data
            if (clientId == 1)
            {
                client.Email = "email@email.com";
                client.FirstName = "tom";
                client.LastName = "kowalski";

            }
            return client;
        }

        /// <summary>
        /// Get all clients data
        /// </summary>
        /// <returns></returns>
        public List<Client> getData()
        {
            //get all clients
            return new List<Client>();
        }
    }
}
