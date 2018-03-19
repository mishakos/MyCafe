using AutoMapper;

using MyCafe.BLL.DTO;
using MyCafe.Web.ViewModels;

namespace MyCafe.Web.Infrastructure
{
    public class AutomapperServiceProfile : Profile
    {
        public AutomapperServiceProfile()
        {
            CreateMap<ClientViewModel, ClientDTO>().ReverseMap();
            CreateMap<DepartmentViewModel, DepartmentDTO>().ReverseMap();
            CreateMap<FirmViewModel, FirmDTO>().ReverseMap();
            CreateMap<ProductViewModel, ProductDTO>().ReverseMap();
        }
    }
}
