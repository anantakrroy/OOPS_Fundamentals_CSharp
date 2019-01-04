using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        //Properties

        public int OrderItemId { get; private set; }

        public int OrderQty { get; set; }

        public int ProductId { get; set; }

        public Decimal? PurchasePrice { get; set; }

        //Methods
        ///Retrieve an order item
        ///
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// Save 
        /// 
        public bool Save()
        {
            return true;
        }

        /// Validate
        /// 
        public bool Validate()
        {
            bool isValid = true;
            if (OrderQty <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }

}
