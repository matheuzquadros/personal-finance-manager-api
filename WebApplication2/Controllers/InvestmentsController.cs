using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models;
using PersonalFinanceManager.Services;

namespace PersonalFinanceManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class InvestmentsController : BaseController<Investment, InvestimentService>
    {
        GoalService GoalService;
        InvestimentService Service;
        public InvestmentsController(InvestimentService service, GoalService goalService) : base(service)
        {
            GoalService = goalService;
            Service = service;
        }

        [HttpPost]
        public override void Post([FromBody]Investment investment)
        {
            Goal goal = GoalService.Get(investment.GoalId);

            if (goal != null)
            {
                Service.Create(investment);
            }
        }

    }
}