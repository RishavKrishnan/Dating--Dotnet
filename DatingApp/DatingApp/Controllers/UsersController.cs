using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.User.ToListAsync(); // Fetch users from the database

            return users; //OK (200) response
        }


        [HttpGet("{id:int}")] // api/users/id
        public async Task<ActionResult<AppUser>>GetUsers(int id)
        {
            var user = await _context.User.FindAsync(id); // Fetch users from the database

            if (user == null) return NotFound();

            return user; //OK (200) response
        }
    }
}
