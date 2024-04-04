using Application.Photos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PhotosController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] IFormFile file)
        {
            return HandleResult(await Mediator.Send(new Add.Command { File = file }));
        }

        // [HttpPost]
        // public async Task<IActionResult> Add([FromForm] Add.Command command)
        // {
        //     return HandleResult(await Mediator.Send(command));
        // }
    }
}