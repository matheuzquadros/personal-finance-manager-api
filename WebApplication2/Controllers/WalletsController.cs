using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models;
using PersonalFinanceManager.Services;
using System.Collections.Generic;

namespace PersonalFinanceManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class WalletsController : BaseController<Wallet, WalletService>
    {
        WalletService Service;
        public WalletsController(WalletService service) : base(service)
        {
            Service = service;
        }

        [Route("{id}/goals")]
        public virtual List<Goal> GetGoals(string id)
        {
            return Service.GetGoals(id);
        }


    }
}