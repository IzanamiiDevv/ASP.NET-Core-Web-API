# ASP.NET-Core-Web-API

## Description
This project is a template for creating ASP.NET Core Web API applications. It provides a pre-configured setup so that users don't need to manually delete boilerplate code and handle CORS configuration.

## Features
- Pre-configured ASP.NET Core Web API template.
- CORS (Cross-Origin Resource Sharing) configured out of the box.
- Minimal boilerplate code.

## Requirements
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) for development.

## Getting Started
1. Clone or download this repository.
2. Open the project in your preferred IDE (Visual Studio or Visual Studio Code).
3. Build and run the application.

## Usage
1. Use this project as a template for creating new ASP.NET Core Web API projects.
2. Modify and extend the code according to your requirements.
3. Explore the project structure to understand how different components are organized.

## Project Structure
- `Controllers/`: Contains controller classes for handling HTTP requests.
- `Controllers/ExampleAPI.cs`: Example API Script for Referrece.
- `Models/`: Contains model classes representing data entities.
- `Services/`: Contains service classes for business logic.
- `Program.cs`: Configures services and middleware for the application.
- `appsettings.json`: Configuration settings for the application.

### ExampleAPI.cs
```c#
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
```

## Contributions
Contributions are welcome! If you have any ideas for improvements or new features, feel free to open an issue or submit a pull request.

## License
This project is licensed under the [MIT License](LICENSE).
