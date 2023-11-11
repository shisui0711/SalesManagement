using Microsoft.EntityFrameworkCore;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Employee;
using QLCHBanHoaQuaWF.Views.Product;
using System.ComponentModel.DataAnnotations;
using AppContext = QLCHBanHoaQuaWF.Models.AppContext;

namespace QLCHBanHoaQuaWF.Presenters;

public class ProductPresenter:PresenterCRUD
{
    private IViewProduct _viewProduct;
    private IAddProduct _addProduct;
    private IUpdateProduct _updateProduct;
    private AppContext _context;
    public ProductPresenter(IViewProduct viewProduct,IAddProduct addProduct,IUpdateProduct updateProduct,AppContext context)
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
        if (_addProduct.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _addProduct as Form;
            form.ShowDialog();
        }
    }

    public void ShowUpdateForm()
    {
        if (_updateProduct.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _addProduct as Form;
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
        if (!IsValid(product,_addProduct))
        {
            return;
        }

        _context.Products.Add(product);
        _viewProduct.ProductBindingSource.EndEdit();
        _context.SaveChanges();
    }

    public override void Update()
    {
        var product = new Product();
        product.ProductID = _updateProduct.ProductID;
        product.ProductName = _updateProduct.ProductName;
        product.CalculationUnit = _addProduct.CalculationUnit;
        product.ImageData = _addProduct.ImageData;
        product.ImportUnitPrice = _addProduct.ImportUnitPrice;
        product.UnitPrice = _addProduct.UnitPrice;
        product.Description = _addProduct.Description;
        if (!IsValid(product,_updateProduct))
        {
            return;
        }

        var productExist = _context.Products.Find(product.ProductID);
        _context.Entry(productExist).CurrentValues.SetValues(product);
        _context.SaveChanges();
        _viewProduct.ProductBindingSource.EndEdit();
        
    }

    public override void Remove()
    {
        var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Cancel)
        {
            return;
        }

        var deleted = _viewProduct.ProductBindingSource.Current as Product;
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Products.Remove(deleted);
                _context.SaveChanges();
                transaction.Commit();
                _viewProduct.ProductBindingSource.Remove(deleted);
            }
            catch (Exception e)
            {
                transaction.Rollback();
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