using Microsoft.AspNetCore.Mvc;

namespace Piranha.Murmur.Server;

[ApiController]
[Route("test")]
public class TestController
{
    [HttpGet("aaa")]
    public string GetAaa() => "aaa";
}
