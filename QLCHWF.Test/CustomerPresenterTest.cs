using System.Windows.Forms;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using QLCHWF.Models;
using QLCHWF.Presenters;
using QLCHWF.Views;
using QLCHWF.Views.Customer;

namespace QLCHWF.Test;


[TestFixture]
public class CustomerPresenterTest
{
    private List<Customer> stub;
    private IQueryable<Customer> data;
    private Mock<IViewCustomer> viewCustomerMock;
    private Mock<IAddCustomer> addCustomerMock;
    private Mock<IUpdateCustomer> updateCustomerMock;
    private Mock<IHistorySales> historySalesMock;
    private Mock<MyAppContext> dbContextMock;
    private CustomerPresenter customerPresenter;
    private BindingSource bindingSource;
    [SetUp]
    public void Init()
    {
       stub = GenerateData(1);
       data = stub.AsQueryable();
       viewCustomerMock = new Mock<IViewCustomer>();
       addCustomerMock = new Mock<IAddCustomer>();
       updateCustomerMock = new Mock<IUpdateCustomer>();
       historySalesMock = new Mock<IHistorySales>();
       dbContextMock = new Mock<MyAppContext>();
       bindingSource = new BindingSource();
        var mockCustomerDbSet = new Mock<DbSet<Customer>>();


       viewCustomerMock.Setup(x => x.CustomerBindingSource).Returns(bindingSource);
       mockCustomerDbSet.As<IQueryable<Customer>>().Setup(x => x.Provider).Returns(data.Provider);
       mockCustomerDbSet.As<IQueryable<Customer>>().Setup(x => x.ElementType).Returns(data.ElementType);
       mockCustomerDbSet.As<IQueryable<Customer>>().Setup(x => x.Expression).Returns(data.Expression);
       mockCustomerDbSet.As<IQueryable<Customer>>().Setup(x => x.GetEnumerator()).Returns(() => data.GetEnumerator());
       dbContextMock.Setup(x => x.Customers).Returns(mockCustomerDbSet.Object);
       dbContextMock.Setup(x => x.Database).Returns(new DatabaseFacade(dbContextMock.Object));
       customerPresenter = new CustomerPresenter(viewCustomerMock.Object, addCustomerMock.Object, updateCustomerMock.Object,
           historySalesMock.Object, dbContextMock.Object);
    }
    [Test]
    public void Add_ValidCustomer_ShouldShowSucessMessage()
    {
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x=>x.ShowMessage("Thêm thành công"),Times.Once);
    }
    [Test]
    public void Add_ExcetionThrown_ShouldShowErrorMessage()
    {
        //Giả lập văng Exception
        dbContextMock.Setup(x => x.SaveChanges()).Throws(new Exception("Unknow"));
        //ValidData
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Lỗi: Unknow"), Times.Once);
    }
    [Test]
    public void Add_InvalidPhone_ShouldShowErrorMessage()
    {
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        addCustomerMock.SetupGet(x => x.Phone).Returns("abc");
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Vui lòng nhập đúng định dạng số điện thoại"), Times.Once);
    }
    [Test]
    public void Add_NameEmpty_ShouldShowErrorMessage()
    {
        addCustomerMock.SetupGet(x => x.CustomerName).Returns("");
        addCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Tên không được để trống"), Times.Once);
    }
    [Test]
    public void Add_NameLongThan30Character_ShouldShowErrorMessage()
    {
        Faker faker = new Faker();
        string random31Character = faker.Random.String2(31);
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(random31Character);
        addCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Tên không dài quá 30 ký tự"), Times.Once);
    }
    [Test]
    public void Add_EmailEmpty_ShouldShowErrorMessage()
    {
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns("");
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Vui lòng nhập đúng định dạng email"), Times.Once);
    }
    [Test]
    public void Add_EmailFormat_ShouldShowErrorMessage()
    {
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns("abcxyz.com");
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Vui lòng nhập đúng định dạng email"), Times.Once);
    }
    [Test]
    public void Add_EmailLongThan50Character()
    {
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns("EEanBxDfFynaTyYpMttXXbgKTpqJLCaeHSSVTRcic@gmail.com");
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Email không được dài hơn 50 ký tự"), Times.Once);
    }
    [Test]
    public void Add_AddressLongThan50Character()
    {
        Faker faker = new Faker();
        string random51Character = faker.Random.String2(51);
        addCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        addCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        addCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        addCustomerMock.SetupGet(x => x.Address).Returns(random51Character);
        customerPresenter.Add();

        addCustomerMock.Verify(x => x.ShowMessage("Địa chỉ không được dài hơn 50 ký tự"), Times.Once);
    }
    [Test]
    public void Update_ValidCustomer_ShouldShowSuccessMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Cập nhật thành công"), Times.Once);
    }
    [Test]
    public void Update_NonExistCustimer_ShouldShowErrorMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(null);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Không tìm thấy khách hàng cần cập nhật"), Times.Once);
    }
    [Test]
    public void Update_ExcetionThrown_ShouldShowErrorMessage()
    {
        //Giả lập văng Exception
        dbContextMock.Setup(x => x.SaveChanges()).Throws(new Exception("Unknow"));
        //ValidData

        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage(It.Is<string>(x=>x.StartsWith("Lỗi:"))));
    }
    [Test]
    public void Update_InvalidPhone_ShouldShowErrorMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns("abc");
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Vui lòng nhập đúng định dạng số điện thoại"), Times.Once);
    }
    [Test]
    public void Update_NameEmpty_ShouldShowErrorMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns("");
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Tên không được để trống"), Times.Once);
    }
    [Test]
    public void Update_NameLongThan30Character_ShouldShowErrorMessage()
    {
        Faker faker = new Faker();
        string random31Character = faker.Random.String2(31);
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(random31Character);
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Tên không dài quá 30 ký tự"), Times.Once);
    }
    [Test]
    public void Update_EmailEmpty_ShouldShowErrorMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns("");
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Vui lòng nhập đúng định dạng email"), Times.Once);
    }
    [Test]
    public void Update_EmailFormat_ShouldShowErrorMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns("abcxyz.com");
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Vui lòng nhập đúng định dạng email"), Times.Once);
    }
    [Test]
    public void Update_EmailLongThan50Character_ShouldShowErrorMessage()
    {
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns("EEanBxDfFynaTyYpMttXXbgKTpqJLCaeHSSVTRcic@gmail.com");
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(stub.FirstOrDefault().Address);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Email không được dài hơn 50 ký tự"), Times.Once);
    }
    [Test]
    public void Update_AddressLongThan50Character_ShouldShowErrorMessage()
    {
        Faker faker = new Faker();
        string random51Character = faker.Random.String2(51);
        updateCustomerMock.SetupGet(x => x.CustomerID).Returns(stub.FirstOrDefault().CustomerID);
        updateCustomerMock.SetupGet(x => x.CustomerName).Returns(stub.FirstOrDefault().CustomerName);
        updateCustomerMock.SetupGet(x => x.Email).Returns(stub.FirstOrDefault().Email);
        updateCustomerMock.SetupGet(x => x.Phone).Returns(stub.FirstOrDefault().Phone);
        updateCustomerMock.SetupGet(x => x.Address).Returns(random51Character);
        customerPresenter.Update();

        updateCustomerMock.Verify(x => x.ShowMessage("Địa chỉ không được dài hơn 50 ký tự"), Times.Once);
    }
    [Test]
    public void Remove_ExistCustomer_ShouldShowSuccessMessage()
    {
        bindingSource.Add(stub.FirstOrDefault());
        customerPresenter.Remove();
        viewCustomerMock.Verify(x=>x.ShowMessage("Xóa thành công"),Times.Once);
    }
    private List<Customer> GenerateData(int count)
    {
        var faker = new Faker<Customer>("vi")
            .RuleFor(c => c.CustomerID, f => f.IndexFaker+1)
            .RuleFor(c => c.CustomerName, f => f.Person.FullName)
            .RuleFor(c => c.Address, f => f.Address.City())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("09########"));
        return faker.Generate(count);
    }
}