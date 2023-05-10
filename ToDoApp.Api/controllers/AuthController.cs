using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDoApp.BusinessLayer.models;
using ToDoApp.DataAccessLayer.Auth;
using ToDoApp.DataAccessLayer.Entities;

namespace ToDoApp.Api.Controllers
{
    [ApiController]
    [Route("Auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<int>> Register(UserRegisterDTO request)
        {
            var response = await _authRepo.Register(
                new Users { Username = request.Username },request.Password);
            if(response==0)
                return BadRequest("Username già in uso.");
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(UserLoginDTO request)
        {
            string response = await _authRepo.Login(request.Username, request.Password);
            if(response.Length < 20) return BadRequest(response);
            return Ok(response);
        }
    }
}
