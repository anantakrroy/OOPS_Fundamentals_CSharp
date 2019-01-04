using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Bagens";

            string expected = "Bagens, Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNameEmptyTest()
        {
            Customer customer = new Customer();
            customer.LastName = "Bagens";

            string expected = "Bagens";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
    
        }

        [TestMethod]
        public void LastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Billy";

            //Act
            string expected = "Billy";
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var customer1= new Customer();
            customer1.FirstName = "Sam";
            Customer.InstanceCount += 1;

            var customer2= new Customer();
            customer2.FirstName = "Mike";
            Customer.InstanceCount += 1;

            var customer3= new Customer();
            customer3.FirstName = "Nitin";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Bagens";
            customer.EmailId = "baggy@minito.com";
            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

       [TestMethod]
       public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer();
            customer.EmailId = "bagens@minion.it";
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
