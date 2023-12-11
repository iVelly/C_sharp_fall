using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Customer : PersonV2
    {
        private DateTime customerSince;
        private double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;

        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                if (ValidOrBuggin.IsNotAFutureDate(value) == false)
                {
                    Feedback += "\nERROR: Cannot enter date before today";
                }
                else
                {
                    customerSince = value;
                }
            }
        }

        public double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }
            set
            {
                if (ValidOrBuggin.IsADouble(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Total Purchases must be a number";
                }
                else if (ValidOrBuggin.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Total Purchases must contain atleast one digit";
                }
                else
                {
                    totalPurchases = value;
                }
            }
        }

        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                discountMember = value;
            }
        }

        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                if (ValidOrBuggin.IsAnInteger(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Rewards Earned must be an integer";
                }

                else if (ValidOrBuggin.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Rewards Earned must contain atleast one digit";
                }
                else
                {
                    rewardsEarned = value;
                }
            }
        }
    }
}
