using AutoMapper;

using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
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

        public async Task<int> AddClient(ClientDTO client)
        {
           return  await _clientRepository.AddClient(_mapper.Map<Client>(client));
        }

        public async Task<int> DeleteClient(ClientDTO client)
        {
            return await _clientRepository.DeleteClient(_mapper.Map<Client>(client));
        }

        public async Task<ClientDTO> GetClient(int id)
        {
            return _mapper.Map<ClientDTO>(await _clientRepository.GetClientById(id));
        }

        public async Task<IEnumerable<ClientDTO>> GetClients()
        {
            return _mapper.Map<IEnumerable<ClientDTO>>(await _clientRepository.GetClients());
        }

        public async Task<int> UpdateClient(ClientDTO client)
        {
            return await _clientRepository.UpdateClient(_mapper.Map<Client>(client));
        }
    }
}
