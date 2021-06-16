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
    public class UserGroupController : ControllerBase
    {
        private MyDBContext myDbContext;

        public UserGroupController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<UserGroup> Get()
        {
            return (this.myDbContext.UserGroups.ToList());
        }
    }
}
