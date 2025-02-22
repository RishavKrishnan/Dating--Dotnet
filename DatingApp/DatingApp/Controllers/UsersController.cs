using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // /api/users


    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context= context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.Users.ToList(); // Fetch users from the database

            return(users); //OK (200) response
        }


        [HttpGet("{id:int}")] // api/users/id
        public ActionResult<AppUser>GetUsers(int id)
        {
            var user = _context.Users.Find(id); // Fetch users from the database

            if (user == null) return NotFound();

            return user; //OK (200) response
        }


    }
}
