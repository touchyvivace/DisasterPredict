using Core.Region.Command;
using Microsoft.AspNetCore.Mvc;

namespace DisasterPredict.Controllers
{
    public class RegionController : ApiControllerBase
    {



        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> CreateRegion([FromBody] AddRegionCommand addRegionCommand)
        {
            var result = await Mediator.Send(addRegionCommand);

            // if (result == null)
            // {
            //     return BadRequest("A Region with the same name already exists.");
            // }

            return 1;
        }



    }
}
