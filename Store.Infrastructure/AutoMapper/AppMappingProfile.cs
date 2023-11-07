using AutoMapper;
using Store.BLL.Entity.Implementations;
using Store.DAL.Entity;

namespace Store.Infrastructure.AutoMapper
{
    internal sealed class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
        }
    }
}