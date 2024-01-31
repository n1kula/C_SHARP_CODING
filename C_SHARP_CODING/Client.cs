﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class Client
    {
        public Client() { }

        public Client(int clientId)
        {
            this.ClientId = clientId;
        }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FirstName { get; set; }

        public string Email { get; set; }

        public int ClientId { get; private set; }

        public string FirstLastName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public bool validate()
        {
            var valid = true;

            if (string.IsNullOrEmpty(LastName)) {
                valid = false;
            }
            if (string.IsNullOrEmpty(Email))
            {
                valid = false;
            }
            return valid;
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
            //code to get data of client by id
            return new Client();
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
