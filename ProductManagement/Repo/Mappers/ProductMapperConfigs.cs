using AutoMapper;
using Repo.Models;
using Repo.ViewModels.ProductViewModel;

namespace Repo.Mappers
{
    public partial class MapperConfigs : Profile
    {
        partial void ProductMapperConfigs()
        {
            CreateMap<Product, ProductViewModel>().
                ForMember(des => des.CategoryName, otp => otp.MapFrom(x => x.Category.CategoryName))
                .ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();

        }
    }
}
