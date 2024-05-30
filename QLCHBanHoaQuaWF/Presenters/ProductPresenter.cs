using AutoMapper;
using QLCHWF.CustomMessageBox;
using QLCHWF.Helpers;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.Product;

namespace QLCHWF.Presenters;

public class ProductPresenter : PaginationPresenter<Product>
{
    private readonly IViewProduct _viewProduct;
    private readonly IAddProduct _addProduct;
    private readonly IUpdateProduct _updateProduct;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public ProductPresenter(IViewProduct viewProduct, IAddProduct addProduct, IUpdateProduct updateProduct, IMapper mapper,IUnitOfWork unitOfWork):base(viewProduct,unitOfWork.Products,6)
    {
        _viewProduct = viewProduct;
        _addProduct = addProduct;
        _updateProduct = updateProduct;
        _mapper = mapper;
        _unitOfWork = unitOfWork;

        _viewProduct.ShowAddProduct += delegate { ShowAddForm(); };
        _viewProduct.ShowUpdateProduct += delegate { ShowUpdateForm(); };
        _viewProduct.LoadProduct += delegate
        {
            RenewItems();
        };
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
        _addProduct.Reset();
        if (_addProduct.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _addProduct as Form;
            form?.ShowDialog();
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
        _updateProduct.CalculationUnit = updated.CalculationUnit ?? "";
        _updateProduct.ImportUnitPrice = updated.ImportUnitPrice;
        _updateProduct.UnitPrice = updated.UnitPrice;
        _updateProduct.ImageData = updated.ImageData ?? Array.Empty<byte>();
        _updateProduct.Description = updated.Description ?? "";

        if (_updateProduct.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _updateProduct as Form;
            form?.ShowDialog();
        }
    }
    public void Add()
    {
        try
        {
            Product product = _mapper.Map<Product>(_addProduct);
            if (product.ImageData == null || product.ImageData.Length == 0)
            {
                product.ImageData = ConverterHelper.BitmapToBytes(Properties.Resources.upload);
            }
            if (!ValidationHelper.IsValid(product, _addProduct))
            {
                return;
            }

            if (_addProduct.ImportUnitPrice > _addProduct.UnitPrice && MyMessageBox.Show(
                    "Giá nhập đang lớn hơn giá bán. Có muốn tiếp tục ?","Cảnh báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            _unitOfWork.Products.Add(product);
            RenewItems();
            _addProduct.ShowMessage(@"Thêm thành công");
        }
        catch (Exception e)
        {
            _viewProduct.ShowMessage($"Thêm thất bại: {e.Message}");
        }
    }

    public void Update()
    {
        try
        {
            Product? productExist = _unitOfWork.Products.GetById(_updateProduct.ProductID);
            if (productExist == null)
            {
                _viewProduct.ShowMessage("Không tìm thấy mặt hàng cần cập nhật");
                return;
            }

            Product product = _mapper.Map<Product>(_updateProduct);
            if (product.ImageData == null || product.ImageData.Length == 0)
            {
                product.ImageData = ConverterHelper.BitmapToBytes(Properties.Resources.upload);
            }
            if (!ValidationHelper.IsValid(product, _updateProduct))
            {
                return;
            }
            if (_updateProduct.ImportUnitPrice > _updateProduct.UnitPrice && MyMessageBox.Show(
                    "Giá nhập đang lớn hơn giá bán. Có muốn tiếp tục ?","Cảnh báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            product.Inventory = productExist.Inventory;
            _unitOfWork.Products.Update(product, product.ProductID);
            RenewItems();
            _updateProduct.ShowMessage(@"Cập nhật thành cộng");
        }
        catch (Exception e)
        {
            _updateProduct.ShowMessage($"Cập nhật thất bại: {e.Message}");
        }
    }

    public void Remove()
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

        if (_unitOfWork.Products.Remove(deleted))
        {
            _viewProduct.ProductBindingSource.Remove(deleted);
            _viewProduct.ShowMessage(@"Xóa thành công");
        }
        else
        {
            _viewProduct.ShowMessage("Xóa thất bại");
        }
    }

    public void Search()
    {
        SearchItems(p => p.ProductName.Contains(_viewProduct.SearchText));
    }


    protected override void Load(List<Product> products)
    {
        _viewProduct.ProductBindingSource.ResetBindings(true);
        _viewProduct.ProductBindingSource.DataSource = products;
    }
}