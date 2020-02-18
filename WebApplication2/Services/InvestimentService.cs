using Microsoft.Extensions.Configuration;
using PersonalFinanceManager.Models;

namespace PersonalFinanceManager.Services
{
    public class InvestimentService : EntityService<Investment>
    {

        public InvestimentService(IConfiguration config) : base(config, "Investiments") 
        {
            
        }

    }
}
