using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]  // Corrected route
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
        if (model.Username == "admin" && model.Password == "password")
        {
            var token = _jwtService.GenerateToken(model.Username);
            return Ok(new { Token = token });
        }

        return Unauthorized();
    }
}

// Model class for login
public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}
