using Microsoft.Extensions.Configuration;
using PersonalFinanceManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceManager.Services
{
    public class WalletService : EntityService<Wallet>
    {
        GoalService GoalService;

        public WalletService(IConfiguration config, GoalService goalService) : base(config, "Wallets") 
        {
            GoalService = goalService;
        }

        public List<Goal> GetGoals(string walletId)
        {
            return GoalService.Get().FindAll(g => g.WalletId == walletId);
        }



    }
}
