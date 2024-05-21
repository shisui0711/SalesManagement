using AutoMapper;
using QLCHWF.Models;
using QLCHWF.Views.Customer;
using QLCHWF.Views.Employee;
using QLCHWF.Views.Options;
using QLCHWF.Views.Product;
using QLCHWF.Views.Provider;

namespace QLCHWF.Mapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<IAddCustomer, Customer>();
        CreateMap<IUpdateCustomer, Customer>().ReverseMap();
        CreateMap<IAddEmployee, Employee>();
        CreateMap<IUpdateEmployee, Employee>().ReverseMap();
        CreateMap<IAddProvider, Provider>();
        CreateMap<IUpdateProvider, Provider>().ReverseMap();
        CreateMap<IAddProduct, Product>();
        CreateMap<IUpdateProduct, Product>().ReverseMap();
        CreateMap<IAppInfo, AppInfo>();
    }
}