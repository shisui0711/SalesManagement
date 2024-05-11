using QLCHWF.Models;
using QLCHWF.Presenters;
using QLCHWF.Views.Customer;
using QLCHWF.Views;

namespace QLCHWF.XUnitTest
{
    public class CustomerPresenterTests
    {
        [Fact]
        public void TestAddCustomer()
        {
            // Arrange
            IViewCustomer viewCustomer = new frmViewCustomer();
            IAddCustomer addCustomer = new frmAddCustomer();
            IUpdateCustomer updateCustomer = new frmUpdateCustomer();
            IHistorySales historySales = new frmHistorySalesOrder();
            MyAppContext context = new MyAppContext();
            var presenter = new CustomerPresenter(viewCustomer, addCustomer, updateCustomer, historySales, context);

            // Act
            addCustomer.CustomerName = "Test Customer";
            addCustomer.Email = "test@example.com";
            addCustomer.Phone = "1234567890";
            addCustomer.Address = "Test Address";
            presenter.Add();

            // Assert
            Assert.AreEqual(1, context.Customers.Count());
            var customer = context.Customers.First();
            Assert.AreEqual("Test Customer", customer.CustomerName);
            Assert.AreEqual("test@example.com", customer.Email);
            Assert.AreEqual("1234567890", customer.Phone);
            Assert.AreEqual("Test Address", customer.Address);
        }

        [Test]
        public void TestUpdateCustomer()
        {
            // Arrange
            var viewCustomer = new ViewCustomer();
            var addCustomer = new AddCustomer();
            var updateCustomer = new UpdateCustomer();
            var historySales = new HistorySales();
            var context = new MyAppContext();
            var presenter = new CustomerPresenter(viewCustomer, addCustomer, updateCustomer, historySales, context);

            // Act
            addCustomer.CustomerName = "Test Customer";
            addCustomer.Email = "test@example.com";
            addCustomer.Phone = "1234567890";
            addCustomer.Address = "Test Address";
            presenter.Add();

            updateCustomer.CustomerID = 1;
            updateCustomer.CustomerName = "Updated Customer";
            updateCustomer.Email = "updated@example.com";
            updateCustomer.Phone = "0987654321";
            updateCustomer.Address = "Updated Address";
            presenter.Update();

            // Assert
            Assert.AreEqual(1, context.Customers.Count());
            var customer = context.Customers.First();
            Assert.AreEqual("Updated Customer", customer.CustomerName);
            Assert.AreEqual("updated@example.com", customer.Email);
            Assert.AreEqual("0987654321", customer.Phone);
            Assert.AreEqual("Updated Address", customer.Address);
        }

        [Test]
        public void TestRemoveCustomer()
        {
            // Arrange
            IViewCustomer viewCustomer = new frmViewCustomer();
            IAddCustomer addCustomer = new frmAddCustomer();
            IUpdateCustomer updateCustomer = new frmUpdateCustomer();
            IHistorySales historySales = new frmHistorySalesOrder();
            MyAppContext context = new MyAppContext();
            var presenter = new CustomerPresenter(viewCustomer, addCustomer, updateCustomer, historySales, context);

            // Act
            addCustomer.CustomerName = "Test Customer";
            addCustomer.Email = "test@example.com";
            addCustomer.Phone = "1234567890";
            addCustomer.Address = "Test Address";
            presenter.Add();

            presenter.Remove();

            // Assert
            Assert.AreEqual(0, context.Customers.Count());
        }
    }
}