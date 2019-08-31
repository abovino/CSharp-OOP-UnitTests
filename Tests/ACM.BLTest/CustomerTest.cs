using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Angelo",
                LastName = "Bovino"
            };

            string expected = "Bovino, Angelo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Bovino"
            };

            string expected = "Bovino";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Angelo"
            };

            string expected = "Angelo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Angelo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Alisa";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Constantina";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
