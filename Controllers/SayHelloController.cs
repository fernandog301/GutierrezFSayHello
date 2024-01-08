using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{  
    [HttpGet]
    [Route("GreetUser")]
    public string GreetUser(string name)
    {
        string greeting = $"Hello, {name}!";
        return greeting;
    }
}
