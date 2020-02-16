using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models;
using PersonalFinanceManager.Services;
using System.Collections.Generic;

namespace PersonalFinanceManager.Controllers
{

    public abstract class BaseController<T, J>: Controller 
        where T : Entity
        where J : EntityService<T>
    {

        private readonly J userService;

        public BaseController(J userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get()
        {
            return userService.Get();
        }

        [HttpGet("{id}")]
        public virtual T Get(string id)
        {
            return userService.Get(id);
        }

        [HttpDelete("{id}")]
        public virtual void Delete(string id)
        {
           userService.Remove(id);
        }


        [HttpPost]
        public virtual void Post([FromBody]T user)
        {
            userService.Create(user);
        }

    }
}