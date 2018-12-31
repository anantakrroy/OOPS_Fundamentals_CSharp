using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount;
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

        public string EmailId { get; set; }

        public int CustomerId { get; private set; }

        public string FullName {
            get
            {
                string fullname = LastName;
                if(!string.IsNullOrEmpty(FirstName))
                {
                   if (!string.IsNullOrEmpty(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailId)) isValid = false;
            return isValid;
        }
    }
}
