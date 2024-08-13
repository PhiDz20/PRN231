using AutoMapper;
using Repo.Helpers;

namespace Repo.Mappers
{
    public partial class MapperConfigs : Profile
    {
        public MapperConfigs()
        {
            CreateMap(typeof(Pagination<>), typeof(Pagination<>));
            // add category mapper
            CategoryMapperConfigs();
            ProductMapperConfigs();
        }
        partial void CategoryMapperConfigs();
        partial void ProductMapperConfigs();
    }
}
