using Microsoft.AspNetCore.Mvc;

namespace vite_api.Controller;

[Route("/api/[controller]")]
public class TestController : Microsoft.AspNetCore.Mvc.Controller
{
    public IActionResult Index()
    {
        return Ok("Test Result");
    }
}