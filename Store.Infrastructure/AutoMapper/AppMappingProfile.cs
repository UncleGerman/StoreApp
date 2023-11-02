using AutoMapper;
using Store.BLL.Entity;
using Store.DAL.Models;

namespace Store.Infrastructure.AutoMapper
{
    public sealed class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}