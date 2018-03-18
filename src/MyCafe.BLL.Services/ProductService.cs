using AutoMapper;
using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Add(ProductDTO product)
        {
            return await _repository.Add(_mapper.Map<Product>(product));
        }

        public async Task<int> Delete(ProductDTO product)
        {
            return await _repository.Delete(_mapper.Map<Product>(product));
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductDTO>>(await _repository.GetAll());
        }

        public async Task<ProductDTO> GetById(int id)
        {
            return _mapper.Map<ProductDTO>(await _repository.GetById(id));
        }

        public async Task<int> Update(ProductDTO product)
        {
            return await _repository.Update(_mapper.Map<Product>(product));
        }
    }
}
