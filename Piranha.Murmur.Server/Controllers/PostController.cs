using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Piranha.Murmur.Server.Controllers
{
    [ApiController]
    [Route("v1/post")]
    public class PostController : ControllerBase
    {
        [HttpGet("{postId}")]
        public async Task<IActionResult> GetPostAsync(Guid postId, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            return Ok(
                new
                {
                    PostUuid = postId,
                    UserUuid = Guid.NewGuid(),
                    Content = "yo"
                });
        }
    }
}