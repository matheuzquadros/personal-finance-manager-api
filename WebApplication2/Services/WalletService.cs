using Microsoft.Extensions.Configuration;
using PersonalFinanceManager.Models;

namespace PersonalFinanceManager.Services
{
    public class WalletService : EntityService<Wallet>
    {

        public WalletService(IConfiguration config) : base(config, "Wallets") 
        {
            
        }

    }
}
