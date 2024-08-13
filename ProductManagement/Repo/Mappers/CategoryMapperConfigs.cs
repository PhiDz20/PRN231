using AutoMapper;
using Repo.Models;
using Repo.ViewModel.CategoryViewModel;
using Repo.ViewModels.CategoryViewModels;

namespace Repo.Mappers
{
    public partial class MapperConfigs : Profile
    {
        partial void CategoryMapperConfigs()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CategoryUpdateModel>().ReverseMap();
        }
    }
}
