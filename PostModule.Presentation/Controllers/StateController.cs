using Microsoft.AspNetCore.Mvc;
using PostModule.Application.Queries.State;

namespace PostModule.Presentation.Controllers
{
    [Route("api/v{version:apiVersion}/State")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateQueryService _stateQueryService;
        public StateController(IStateQueryService stateQueryService)
        {
            _stateQueryService = stateQueryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStates()
        {
            try
            {
                var data = await _stateQueryService.GetStatesWithCities();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
