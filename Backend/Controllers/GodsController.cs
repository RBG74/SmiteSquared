using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using SmiteApiLib.ApiConsumers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GodsController : ControllerBase
    {
        private readonly ILogger<GodsController> _logger;
        private readonly IGodsAndItemsService _godsAndItemsService;

        public GodsController(
            ILogger<GodsController> logger,
            IGodsAndItemsService godsAndItemsService)
        {
            _logger = logger;
            _godsAndItemsService = godsAndItemsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GodDTO>>> Get()
        {
            try
            {
                var gods = await _godsAndItemsService.GetGods();
                var dtos = gods.Select(g => new GodDTO(g));
                return Ok(dtos);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GodDTO>> Get(int id)
        {
            try
            {
                var gods = await _godsAndItemsService.GetGods();
                var god = gods.SingleOrDefault(g => g.Id == id);
                if (god != null)
                    return Ok(new GodDTO(god));
                else
                    return NotFound($"There are no god with id={id}.");
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }
    }
}