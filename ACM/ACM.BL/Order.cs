using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order() { }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        //Properties
        public int OrderId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        //Methods
        ///Retrieve
        ///
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        ///Save
        ///
        public bool Save() {
            return true;
        }

        ///Validate
        ///
        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
