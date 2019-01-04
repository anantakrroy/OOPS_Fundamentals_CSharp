using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// 
        public Customer() { }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

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
         
        /// <summary>
        ///  Validate
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailId)) isValid = false;
            return isValid;
        }

        /// <summary>
        /// Retrieve 
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        /// Retrieve a list of customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        ///Save
        public bool Save()
        {
            return true;
        }
        
    }
}
