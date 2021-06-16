using ConectionMySQL.Data;
using ConectionMySQL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConectionMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private MyDBContext myDbContext;

        public UserController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<User> Get()
        {
            return (this.myDbContext.Users.ToList());
        }
    }
}
