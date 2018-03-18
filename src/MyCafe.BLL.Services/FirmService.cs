using AutoMapper;

using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services
{
    public class FirmService : IFirmService
    {
        private readonly IFirmRepository _repository;
        private readonly IMapper _mapper;

        public FirmService(IFirmRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Add(FirmDTO firm)
        {
            return await _repository.Add(_mapper.Map<Firm>(firm));
        }

        public async Task<int> Delete(FirmDTO firm)
        {
            return await _repository.Delete(_mapper.Map<Firm>(firm));
        }

        public async Task<IEnumerable<FirmDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<FirmDTO>>(await _repository.GetAll());
        }

        public async Task<FirmDTO> GetById(int id)
        {
            return _mapper.Map<FirmDTO>(await _repository.GetById(id));
        }

        public async Task<int> Update(FirmDTO firm)
        {
            return await _repository.Update(_mapper.Map<Firm>(firm));
        }
    }
}
