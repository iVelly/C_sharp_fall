using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class PersonV2 : People
    {
        private string cellPhone;
        private string instagramURL;

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                if (ValidOrBuggin.ExactLength(value, 10) == false)
                {
                    Feedback += "\nERROR: Cellphone must contain 10 numbers";
                }
                else
                {
                    cellPhone = value;
                }
            }
        }

        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "\nYour Instagram URL cannot contain profanity";
                }
                else if (ValidOrBuggin.ValidInstagramURL(value) == false)
                {
                    Feedback += "\nERROR: Invalid URL to instagram";
                }
                else
                {
                    instagramURL = value;
                }

            }
        }
    }
}
