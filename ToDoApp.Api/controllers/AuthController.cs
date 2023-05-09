using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDoApp.BusinessLayer.models;
using ToDoApp.DataAccessLayer.Auth;

namespace ToDoApp.Api.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        public async Task<ActionResult<int>> Register(UserRegisterDTO request)
        {

        }
    }
}
