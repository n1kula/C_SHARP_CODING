using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class Client
    {
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
    }
}
