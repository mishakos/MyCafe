using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCafe.BLL.DTO;
using MyCafe.BLL.Services.Interfaces;
using MyCafe.Web.ViewModels;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Web.Controllers
{
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;
        private readonly IMapper _mapper;
        private readonly IDepartmentService _service;

        public DepartmentController(ILogger<DepartmentController> logger, IMapper mapper, IDepartmentService service)
        {
            _logger = logger;
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<DepartmentViewModel>>(await _service.GetAll()));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in get all department:{ex}");
            }
            return BadRequest(new OperationResult("Get departments failed."));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_mapper.Map<DepartmentViewModel>(await _service.GetById(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in get department by id:{ex}");
            }
            return BadRequest(new OperationResult("Get department by id failed."));
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByFirm(int id)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<DepartmentViewModel>>(await _service.GetByFirmId(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in get department by firm id:{ex}");
            }
            return BadRequest(new OperationResult("Get department by firm Id."));
        }

        [HttpPost("")]
        public async Task<IActionResult> Add([FromBody]DepartmentViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                await _service.Add(_mapper.Map<DepartmentDTO>(model));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in add Department:{ex}");
            }
            return BadRequest(new OperationResult("Add Department failed."));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]DepartmentViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var oldItem = await _service.GetById(id);
                if (oldItem == null)
                    return NotFound(new OperationResult($"Department {id} not found."));
                await _service.Update(_mapper.Map<DepartmentDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in Update department: {ex}");
            }
            return BadRequest(new OperationResult("Update department failed."));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown in delete department:{ex}");
            }
            return BadRequest(new ObjectResult("Delete deparment error."));
        }
    }
}
