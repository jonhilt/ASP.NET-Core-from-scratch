using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [Route("home/")]
    public IActionResult Index(){
        return Ok("Hello World from a controller");
    }

}