using Microsoft.Extensions.Configuration;
using PersonalFinanceManager.Models;
using System.Collections.Generic;

namespace PersonalFinanceManager.Services
{
    public class GoalService : EntityService<Goal>
    {

        InvestimentService InvestimentService;

        public GoalService(IConfiguration config, InvestimentService investimentService) : base(config, "Goals") 
        {
            InvestimentService = investimentService;
        }

        public List<Investment> GetInvestments(string goalId)
        {
            return InvestimentService.Get().FindAll(i => i.GoalId == goalId);
        }

    }
}
