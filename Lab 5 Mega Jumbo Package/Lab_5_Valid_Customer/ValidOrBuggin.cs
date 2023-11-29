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
            bool result = temp.ToLower().Contains("dunce");
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
            //I know what you're thinking right now..."did he really just use my email validation...well yes. lol. I wasn't sure if you gave us permission to utilize it but I just want to hit all the right marks without wasting too much and this was to quickest way possible.
            
            //assume true, but look for bad stuff to make it false
            bool blnResult = true;

            //Look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            //temp = scott@neit.ca
            // length = 13
            // position of last period = 10

            //Look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");

            //check for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2)    //if it is -1, not found and needs at least 2 chars in front
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))    //If there are less than 2 chars and the last period
            {
                blnResult = false;
            }

            return blnResult;
        }
    }
}
