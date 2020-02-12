using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Services;
using System;
using System.Collections.Generic;
using WebApplication2.Models;

namespace PersonalFinanceManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {

        private readonly UserService userService;

        public UsersController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userService.Get();
        }

        [HttpGet("{id}")]
        public User Get(string id)
        {
            return userService.Get(id);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
           userService.Remove(id);
        }


        [HttpPost]
        public void Post([FromBody]User user)
        {
            userService.Create(user);
        }




    }
}