using AutoMapper;

using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Add(DepartmentDTO department)
        {
            return await _repository.Add(_mapper.Map<Department>(department));
        }

        public async Task<int> Delete(DepartmentDTO department)
        {
            return await _repository.Delete(_mapper.Map<Department>(department));
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<DepartmentDTO>>(await _repository.GetAll());
        }

        public async Task<IEnumerable<DepartmentDTO>> GetByFirmId(int firmId)
        {
            return _mapper.Map<IEnumerable<DepartmentDTO>>(await _repository.GetByFirmId(firmId));
        }

        public async Task<DepartmentDTO> GetById(int id)
        {
            return _mapper.Map<DepartmentDTO>(await _repository.GetById(id));
        }

        public async Task<int> Update(DepartmentDTO department)
        {
            return await _repository.Update(_mapper.Map<Department>(department));
        }
    }
}
