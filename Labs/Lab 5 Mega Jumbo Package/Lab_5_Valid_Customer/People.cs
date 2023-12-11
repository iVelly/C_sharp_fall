using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

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
        private string feedback;

        public People()
        {
            feedback = "";
        }

        // Inside the structure, create properties to get and set each piece of personal information
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "ERROR: Your name input contains profanity";
                }
                else if (ValidOrBuggin.TooManyLetters(value, 15) == false)
                {
                    Feedback += "\nERROR: Your First Name input is too long";
                }
                else if (ValidOrBuggin.IsItFilledIn(value, 1) == false)
                {
                    Feedback += "\nERROR: Your First Name input is not filled in";
                }
                else
                {
                    firstName = value;
                }
                
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
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "ERROR: Your name input contains profanity";
                }
                else if (ValidOrBuggin.TooManyLetters(value, 2) == false)
                {
                    Feedback += "\nERROR: Your middle Name input is too long";
                }
                else
                {
                    middleName = value;
                }
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
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "ERROR: Your Last name input contains profanity";
                }
                else if (ValidOrBuggin.TooManyLetters(value, 15) == false)
                {
                    Feedback += "\nERROR: Your Last Name input is too long";
                }
                else if (ValidOrBuggin.IsItFilledIn(value, 1) == false)
                {
                    Feedback += "\nERROR: Your Last Name input is not filled in";
                }
                else
                {
                    lastName = value;
                }
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
                 if (ValidOrBuggin.IsItFilledIn(value, 1) == false)
                {
                    Feedback += "\nERROR: Your Street1 input is not filled in";
                }
                else if (ValidOrBuggin.TooManyLetters(value, 45) == false)
                {
                    Feedback += "\nERROR: Your Street1 input is too long";
                }
                else if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "\nERROR: Your Street1 input contains profanity";
                }
                else
                {
                    street1 = value;
                }
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
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "\nERROR: Your Street1 input contains profanity";
                }
                else if (ValidOrBuggin.TooManyLetters(value, 45) == false)
                {
                    Feedback += "\nERROR: Your Street1 input is too long";
                }
             
                else
                {
                    street2 = value;
                }
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
                if (ValidOrBuggin.ExactLength(value, 2) == false)
                {
                    Feedback += "\nERROR: State must contain only two letters";
                }
                else if (ValidOrBuggin.ContainsOnlyLetters(value) == false)
                {
                    Feedback += "\nERROR: State must contain only letters";
                }
                else
                {
                    state = value;
                }
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
                if (ValidOrBuggin.ExactLength(value, 5) == false)
                {
                    Feedback += "\nERROR: Zipcode must contain only five digits";
                }
                else if (ValidOrBuggin.IsValidDouble(value) == false)
                {
                    Feedback += "\nERROR: Zipcode must only contain numbers";
                }
                else
                {
                    zip = value;
                }
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
                if (ValidOrBuggin.ExactLength(value, 10) == false)
                {
                    Feedback += "\nERROR: Phone number must only contain 10 digits";
                }
                else if (ValidOrBuggin.IsValidDouble(value) == false)
                {
                    Feedback += "\nERROR: Phone number must only contain numbers";
                }
                else
                {
                    phone = value;
                }
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
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "\nERROR: Your Email contains profanity";
                }
                else if (!ValidOrBuggin.IsValidEmail(value))  
                {
                    Feedback += "\nERROR: Your email is not in a valid format";
                }
                else if (ValidOrBuggin.TooManyLetters(value, 45) == false)
                {
                    Feedback += "\nERROR: Your Email is too long";
                }
                else
                {
                    email = value;
                }
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }


    }
}

