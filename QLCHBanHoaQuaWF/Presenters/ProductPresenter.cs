using Microsoft.EntityFrameworkCore;
using QLCHWF.Models;
using QLCHWF.Views.Product;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF.Presenters;

public class ProductPresenter : PresenterCRUD
{
    private IViewProduct _viewProduct;
    private IAddProduct _addProduct;
    private IUpdateProduct _updateProduct;
    private MyAppContext _context;
    public ProductPresenter(IViewProduct viewProduct, IAddProduct addProduct, IUpdateProduct updateProduct, MyAppContext context)
    {
        _viewProduct = viewProduct;
        _addProduct = addProduct;
        _updateProduct = updateProduct;
        _context = context;

        _context.Products.Load();
        _viewProduct.ShowAddProduct += delegate { ShowAddForm(); };
        _viewProduct.ShowUpdateProduct += delegate { ShowUpdateForm(); };
        _viewProduct.LoadProduct += delegate { Load(); };
        _viewProduct.RemoveProduct += delegate { Remove(); };
        _viewProduct.SearchProduct += delegate { Search(); };

        _addProduct.AddProduct += delegate { Add(); };
        _updateProduct.UpdateProduct += delegate { Update(); };
    }

    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateProduct == false)
        {
            _viewProduct.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        if (_addProduct.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _addProduct as Form;
            form.ShowDialog();
        }
    }

    public void ShowUpdateForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanUpdateProduct == false)
        {
            _viewProduct.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var updated = _viewProduct.ProductBindingSource.Current as Product;
        if (updated == null)
        {
            _viewProduct.ShowMessage(@"Không tìm thấy bản ghi đã chọn");
            return;
        }

        _updateProduct.ProductID = updated.ProductID;
        _updateProduct.ProductName = updated.ProductName;
        _updateProduct.CalculationUnit = updated.CalculationUnit;
        _updateProduct.ImportUnitPrice = updated.ImportUnitPrice;
        _updateProduct.UnitPrice = updated.UnitPrice;
        _updateProduct.ImageData = updated.ImageData;
        _updateProduct.Description = updated.Description;

        if (_updateProduct.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _updateProduct as Form;
            form.ShowDialog();
        }
    }
    public override void Add()
    {
        var product = new Product();
        product.ProductName = _addProduct.ProductName;
        product.CalculationUnit = _addProduct.CalculationUnit;
        product.ImageData = _addProduct.ImageData;
        product.ImportUnitPrice = _addProduct.ImportUnitPrice;
        product.UnitPrice = _addProduct.UnitPrice;
        product.Description = _addProduct.Description;
        if (!IsValid(product, _addProduct))
        {
            return;
        }

        _context.Products.Add(product);
        _context.SaveChanges();
        _viewProduct.ProductBindingSource.EndEdit();
        _addProduct.ShowMessage(@"Thêm thành công");
    }

    public override void Update()
    {
        Product product = new Product();
        product.ProductID = _updateProduct.ProductID;
        product.ProductName = _updateProduct.ProductName;
        product.CalculationUnit = _updateProduct.CalculationUnit;
        product.ImageData = _updateProduct.ImageData;
        product.ImportUnitPrice = _updateProduct.ImportUnitPrice;
        product.UnitPrice = _updateProduct.UnitPrice;
        product.Description = _updateProduct.Description;
        if (!IsValid(product, _updateProduct))
        {
            return;
        }

        Product productExist = _context.Products.Find(product.ProductID);
        _context.Entry(productExist).CurrentValues.SetValues(product);
        _context.SaveChanges();
        _viewProduct.ProductBindingSource.EndEdit();
        _updateProduct.ShowMessage(@"Cập nhật thành cộng");
    }

    public override void Remove()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteProduct == false)
        {
            _viewProduct.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var deleted = _viewProduct.ProductBindingSource.Current as Product;
        if (deleted == null)
        {
            _viewProduct.ShowMessage(@"Không tìm thấy bản ghi đã chọn");
            return;
        }
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Products.Remove(deleted);
                _context.SaveChanges();
                transaction.Commit();
                _viewProduct.ProductBindingSource.Remove(deleted);
                _viewProduct.ShowMessage(@"Xóa thành công");
            }
            catch (Exception e)
            {
                transaction.Rollback();
                _viewProduct.ShowMessage($@"Xóa thất bại: {e.Message}");
            }
        }
    }

    public override void Search()
    {
        List<Product> products = null;
        products = _context.Products.Where(p => p.ProductName.Contains(_viewProduct.SearchText)).ToList();
        if (products != null)
        {
            _viewProduct.ProductBindingSource.DataSource = products;
        }
    }

    public override void Load()
    {
        _viewProduct.ProductBindingSource.ResetBindings(true);
        _viewProduct.ProductBindingSource.DataSource = _context.Products.Local.ToBindingList();

    }
}