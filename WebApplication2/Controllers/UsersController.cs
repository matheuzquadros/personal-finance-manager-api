using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models;
using PersonalFinanceManager.Services;

namespace PersonalFinanceManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UsersController : BaseController<User, UserService>
    {
        WalletService WalletService;
        UserService Service;
        public UsersController(UserService service, WalletService walletService) : base(service)
        {
            Service = service;
            WalletService = walletService;
        }

        [HttpPost]
        public override void Post([FromBody]User user)
        {

            Wallet wallet = WalletService.Create(new Wallet());

            user.WalletId = wallet.Id;
            Service.Create(user);
        }
    }
}