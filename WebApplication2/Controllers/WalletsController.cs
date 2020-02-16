using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models;
using PersonalFinanceManager.Services;

namespace PersonalFinanceManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class WalletsController : BaseController<Wallet, WalletService>
    {
        public WalletsController(WalletService service) : base(service)
        {

        }

    }
}