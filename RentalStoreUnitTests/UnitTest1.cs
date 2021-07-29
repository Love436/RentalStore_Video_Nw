using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalStore_Video_Nw;

namespace RentalStoreUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        DbClass dbClass = new DbClass();

        [TestMethod()]
        public void AddCustomer()
        {

            dbClass.DatabaseUpdate("Insert into Customers Values('CustomerName','CustomerMobile','CustomerAddress','Interest','CustomerPostalCode')");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void UpdateCustomer()
        {
            dbClass.DatabaseUpdate("Update Customers set Name='Name',Mobile='Mobile' where CustomerId = 1");
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void DeleteCustomer()
        {
            dbClass.DatabaseUpdate("Delete from Customers where CustomerId = 1");
            Assert.IsTrue(true);
        }
    }
}
