using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Web.ViewModels;

using System;
using System.Threading.Tasks;

namespace MyCafe.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IMapper mapper, IProductService productService) 
        {
            this._logger = logger;
            this._mapper = mapper;
            this._productService = productService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _productService.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in get all products:{ex}");
            }
            return BadRequest(new OperationResult("Get all products failed."));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<ProductViewModel>(await _productService.GetById(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in get product by id:{ex}");
            }
            return BadRequest(new OperationResult("Get product failed."));
        }

        [HttpPost("")]
        public async Task<IActionResult> Add([FromBody]ProductViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                await _productService.Add(_mapper.Map<ProductDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in Add product:{ex}");
            }
            return BadRequest(new OperationResult("Insert product failed."));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]ProductViewModel model)
        {
            try
            {
                var oldItem = await _productService.GetById(id);
                if (oldItem == null)
                    return NotFound(new OperationResult($"Product {id} not found."));
                await _productService.Update(_mapper.Map<ProductDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in update product:{ex}");
            }
            return BadRequest(new OperationResult("Update product failed."));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var oldItem = await _productService.GetById(id);
                if (oldItem == null)
                    return NotFound(new OperationResult($"Product {id} not found."));
                await _productService.Delete(oldItem);
                return Ok(new OperationResult(true));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in delete product:{ex}");
            }
            return BadRequest(new OperationResult("Delete product failed."));
        }
    }
}
