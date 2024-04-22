using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_API.Controllers;

[ApiController]
[Route("/example")]
public class ExampleAPI : ControllerBase
{
    [HttpGet]
    public IActionResult GetMain()
    {
        string message = "Main Server EndPoint";
        return Ok(new { Text = message });
    }
    [HttpGet("test")]
    public IActionResult GetTest()
    {
        string message = "Hello From Server";
        return Ok(new { Text = message });
    }
    [HttpPost("add")]
    public IActionResult AddNumbers([FromBody] NumbersModel numbers)
    {
        if (numbers == null)
        {
            return BadRequest("Invalid data provided");
        }

        int sum = numbers.Num1 + numbers.Num2;
        return Ok(new { Sum = sum });
    }
}

public class NumbersModel
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }
}