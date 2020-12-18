using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Warhammer_40k_Administratum.Models;
using Firebase.Database;
using Firebase.Database.Query;

namespace Warhammer_40k_Administratum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopPageItem()
        {
            return View();
        }

        public IActionResult EventCalendar()
        {
            return View();
        }

        public IActionResult ArmyBuilder()
        {
            return View();
        }

        public IActionResult AddShopItem()
        {
            return View();
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<ActionResult> CreateAccount(User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                Random num = new Random();
                user.Id = num.Next();
                var firebaseClient = new FirebaseClient("https://warhammerproject-61601-default-rtdb.firebaseio.com/");
                var result = await firebaseClient
                  .Child("Users/" + user.Username)
                  .PostAsync(user);

                return View("Index");
            }
            
        }
    }
}
