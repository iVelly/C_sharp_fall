using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class ValidOrBuggin
    {
        public static bool GotProfanity(string temp)
        {
            bool result = temp.ToLower().Contains("caca");
            return result;
        }
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = temp.Length >= minlen;
            return result;
        }
        public static bool TooManyLetters(string temp, int maxlen)
        {
            bool result = temp.Length <= maxlen;
            return result;
        }
        public static bool ExactLength(string temp, int value)
        {
            bool result = temp.Length == value;
            return result;
        }
        public static bool IsValidDouble(string temp)
        {
            double dblResult;
            bool blnResult = double.TryParse(temp, out dblResult);
            return blnResult;
        }


        public static bool ValidInstagramURL(string temp)
        {
            return temp.ToLower().StartsWith("https://www.instagram.com");
        }

        public static bool IsNotAFutureDate(DateTime temp)
        {
            bool blnResult = temp < DateTime.Now;

            return blnResult;
        }

        public static bool IsAnInteger(string temp)
        {
            Int16 intResult;
            bool blnResult = Int16.TryParse(temp, out intResult);
            return blnResult;
        }

        public static bool ContainsOnlyLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidEmail(string temp)
        {
            bool blnResult = true;

            int atLocation = temp.IndexOf("@");
            int periodLocation = temp.LastIndexOf(".");

            // Check minimum length.
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            // Check if "@" is present and has at least 2 characters in front.
            else if (atLocation < 2)
            {
                blnResult = false;
            }
            // Check if there is no period in the email.
            else if (periodLocation == -1)
            {
                blnResult = false;
            }
            // Check if the period comes before the "@".
            else if (periodLocation < atLocation)
            {
                blnResult = false;
            }
            // Check if there are characters after the period.
            else if (periodLocation + 2 >= temp.Length)
            {
                blnResult = false;
            }

            return blnResult;
        }

    }
}
