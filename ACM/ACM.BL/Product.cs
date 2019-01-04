using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product() { }  //Default constructor

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // Class properties
        public Decimal? CurrentPrice { get; set; } // Decimal? is for a nullable value
        public int ProductId { get; private set; }
        public String ProductDescription { get; set; }
        public String ProductName { get; set; }

        //Class methods

        /// Retrieve single product
        /// 
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// Save 
        /// 
        public bool Save()
        {
            return true;
        }

        ///Validate
        ///
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }



    }
}
