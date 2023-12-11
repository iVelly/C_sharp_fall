using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class People
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string expression;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;

        // Inside the structure, create properties to get and set each piece of personal information
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                street1 = value;
            }
        }

        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                street2 = value;
            }
        }

        public string Expression
        {
            get
            {
                return expression;
            }
            set
            {
                expression = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}

