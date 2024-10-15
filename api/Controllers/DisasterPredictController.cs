using Core.DisasterPredicts.Queries;
using Microsoft.AspNetCore.Mvc;
using DisasterPredict.Domain.Entities;

namespace DisasterPredict.Controllers
{
    public class DisasterPredictController : ApiControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<DisasterPredictInfo>> GetAllDisasterPredicts([FromQuery] GetDisasterPredictsQuery disasterpredictsQuery)
        {
            return await Mediator.Send(disasterpredictsQuery);
        }
        [HttpGet("{disasterpredictId}")]
        public async Task<ActionResult<DisasterPredictInfo>> GetDisasterPredictById(int disasterpredictId)
        {
            var query = new GetDisasterPredictByIdQuery { Id = disasterpredictId };
            var result = await Mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpPut("{disasterpredictId}")]
        public async Task<IActionResult> UpdateDisasterPredict(int disasterpredictId, [FromBody] UpdateDisasterPredictCommand updateDisasterPredictCommand)
        {
            updateDisasterPredictCommand.DisasterPredictId = disasterpredictId;

            var result = await Mediator.Send(updateDisasterPredictCommand);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<DisasterPredictInfo>> CreateDisasterPredict([FromBody] AddDisasterPredictCommand addDisasterPredictCommand)
        {
            var result = await Mediator.Send(addDisasterPredictCommand);

            if (result == null)
            {
                return BadRequest("A DisasterPredict with the same name already exists.");
            }

            return CreatedAtAction(nameof(GetDisasterPredictById), new { disasterpredictId = result.Id }, result);
        }

        [HttpDelete("{disasterpredictId}")]
        public async Task<IActionResult> DeleteDisasterPredict(int disasterpredictId)
        {
            var command = new DeleteDisasterPredictCommand { DisasterPredictId = disasterpredictId };
            var success = await Mediator.Send(command);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
