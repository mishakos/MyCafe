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
    public class ClientsController : Controller
    {
        private readonly ILogger<ClientsController> _logger;
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientsController(ILogger<ClientsController> logger, IClientService clientService, IMapper mapper)
        {
            _logger = logger;
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetClients()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<ClientViewModel>>(await _clientService.GetClients()));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in get clients: {ex}");
            }
            return BadRequest(new OperationResult("Get clients failed."));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            try
            {
                var item = await _clientService.GetClient(id);
                if (item == null)
                    return NotFound(new OperationResult($"Client with id {id} not found"));
                return Ok(item);
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in get client by id {id}: {ex}");
            }
            return BadRequest(new OperationResult($"Get client {id} failed."));
        }

        [HttpPost("")]
        public async Task<IActionResult> AddClient(ClientViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var addTask = await _clientService.AddClient(_mapper.Map<ClientDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in add client:{ex}");
            }
            return BadRequest(new OperationResult("Add client failed."));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClientViewModel model)
        {
            try
            {
                var oldItem = await _clientService.GetClient(id);
                if (oldItem == null)
                    return NotFound(new OperationResult($"Client {id} not found."));
                await _clientService.UpdateClient(_mapper.Map<ClientDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in update client:{ex}");
            }
            return BadRequest(new OperationResult("Update client failed."));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, ClientViewModel model)
        {
            try
            {
                var oldItem = await _clientService.GetClient(id);
                if (oldItem == null)
                    return NotFound(new OperationResult($"Client {id} not found."));
                await _clientService.DeleteClient(_mapper.Map<ClientDTO>(model));
                return Ok(new OperationResult(true));
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception thrown in delete client:{ex}");
            }
            return BadRequest(new OperationResult("Delete client failed."));
        }

    }
}
