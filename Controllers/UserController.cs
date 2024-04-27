using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly List<User> _users = new()
        {
            new User { Id = 1, Name = "Jhon Doe" },
            new User { Id = 2, Name = "Jane Doe" },
            new User { Id = 3, Name = "Mike Tyson" },
            new User { Id = 4, Name = "Celine Dion" }
        };

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            var theusers = _users.ToList();
            return theusers;

        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            var myuser = _users.FirstOrDefault(p => p.Id == id);
            return myuser;
        }
    }
}
