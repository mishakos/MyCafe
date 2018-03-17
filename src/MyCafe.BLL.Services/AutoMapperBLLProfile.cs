using AutoMapper;
using MyCafe.BLL.DTO;
using MyCafe.DB.Enities;

namespace MyCafe.BLL.Services
{
    public class AutoMapperBLLProfile : Profile
    {
        public AutoMapperBLLProfile()
        {
            CreateMap<Client, ClientDTO>();
        }
    }
}
