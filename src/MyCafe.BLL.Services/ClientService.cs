using AutoMapper;
using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Db.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ClientDTO> GetClient(int id)
        {
            return _mapper.Map<ClientDTO>(await _clientRepository.GetClientById(id));
        }
    }
}
