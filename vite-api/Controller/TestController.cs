using Microsoft.AspNetCore.Mvc;

namespace vite_api.Controller;

public class TestController : Microsoft.AspNetCore.Mvc.Controller
{
    public IActionResult Index()
    {
        return Ok("Test Result");
    }
}