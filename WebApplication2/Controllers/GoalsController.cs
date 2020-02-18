using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models;
using PersonalFinanceManager.Services;
using System.Collections.Generic;

namespace PersonalFinanceManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class GoalsController : BaseController<Goal, GoalService>
    {
        GoalService Service;
        WalletService WalletService;

        public GoalsController(GoalService service, WalletService walletService) : base(service) {
            Service = service;
            WalletService = walletService;
        }

        [HttpPost]
        public override void Post([FromBody]Goal goal)
        {
            Wallet wallet = WalletService.Get(goal.WalletId);

            if(wallet != null)
            {
                Service.Create(goal);
            }
        }

        [Route("{id}/investments")]
        public virtual List<Investment> GetInvestments(string id)
        {
            return Service.GetInvestments(id);
        }

    }
}