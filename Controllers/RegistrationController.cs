using Microsoft.AspNetCore.Mvc;
using RegistrationAPI.Model;
using RegistrationAPI.Services;

namespace RegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _service;

        public RegistrationController(IRegistrationService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Create(RegistrationEntity registration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _service.RegisterAsync(registration);
            if (result)
            {
                return Ok(new { message = "Registration Successful!" });
            }
            return StatusCode(500, new { message = "Registration Failed!" });
        }
    }
}
