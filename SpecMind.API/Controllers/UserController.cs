namespace SpecMind.API.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Registration(CreateUserDTO createUserDTO)
        {
            var result = await _userService.CreateUser(createUserDTO);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return BadRequest(new { error = result.ErrorMessage });
            }

            return Ok(result);
        }
    }
}