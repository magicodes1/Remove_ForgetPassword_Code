using Microsoft.AspNetCore.Mvc;
using test_event.Data;

namespace test_event.Controller;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly ApplicationDbContext context;

    public HomeController(ApplicationDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult get()
    {
        context.forgetPasswordCodes.Add(new Models.ForgetPasswordCode() { Code = "123", ExpiredTime = 3 });
        context.SaveChanges();
        return Ok();
    }
}