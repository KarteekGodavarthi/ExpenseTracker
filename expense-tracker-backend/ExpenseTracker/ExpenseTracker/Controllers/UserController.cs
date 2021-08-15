using ExpenseTracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/expense")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUserDetails()
        {
            var userDetails = new UserDetails();
            userDetails.firstName = "Karteek";
            userDetails.secondName = "Godavarthi";
            userDetails.userName = "godkarte";

            return Ok(userDetails);
        }

    }
}
