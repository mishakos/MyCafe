using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Web.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Web.Controllers
{
    [Route("api/[controller]")]
    public class FirmController : Controller
    {
        private readonly ILogger<FirmController> _logger;
        private readonly IFirmService _service;
        private readonly IMapper _mapper;

        public FirmController(ILogger<FirmController> logger, IFirmService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<FirmViewModel>>(await _service.GetAll()));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in Get All firms:{ex}");
            }
            return BadRequest(new OperationResult("Get Firms Failed."));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var oldItem = await _service.GetById(id);
                if (oldItem == null)
                    return NotFound(new OperationResult($"Firm {id} no found."));
                await _service.Delete(oldItem);
                return Ok(new OperationResult(true));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in delete firm:{ex}");
            }
            return BadRequest(new OperationResult("Delete firm failed"));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<FirmViewModel>(await _service.GetById(id)));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in get by id: {ex}");
            }
            return BadRequest(new OperationResult("Get firm failed."));
        }

        [HttpPost("")]
        public async Task<IActionResult> Add([FromBody]FirmViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                await _service.Add(_mapper.Map<FirmDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in Add firm:{ex}");
            }
            return BadRequest(new OperationResult("Add firm error"));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]FirmViewModel model)
        {
            try
            {
                var oldItem = await _service.GetById(id);
                if (oldItem == null)
                    return NotFound($"Firm {id} not found.");
                await _service.Update(_mapper.Map<FirmDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in update firm:{ex}");
            }
            return BadRequest(new OperationResult("Update firm failed."));
        }
    }
}
