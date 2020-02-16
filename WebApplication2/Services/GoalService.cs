using Microsoft.Extensions.Configuration;
using PersonalFinanceManager.Models;

namespace PersonalFinanceManager.Services
{
    public class GoalService : EntityService<Goal>
    {

        public GoalService(IConfiguration config) : base(config, "Goals") 
        {
            
        }

    }
}
