using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers;

[ApiController]
[Route("/")]
public class BasicController : ControllerBase
{
    [HttpGet]
    public string GetHw()
    {
        return "Hello World!";
    }
}