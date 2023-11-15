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
                cellPhone = value;
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
                instagramURL = value;
            }
        }
    }
}
