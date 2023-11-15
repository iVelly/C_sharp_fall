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
                customerSince = value;
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
                totalPurchases = value;
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
                rewardsEarned = value;
            }
        }
    }
}
