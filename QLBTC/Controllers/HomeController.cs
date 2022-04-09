using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QLBTC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QLBTC.Controllers
{
    public class HomeController : Controller
    {
        FruitsShopManagementContext Context = new FruitsShopManagementContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            List<User> listUser = new List<User>();
            listUser = Context.Users.ToList();
            var account = listUser.Where(u => u.Username == user.Username && u.Password == user.Password).ToList();
            if (account.Count != 0)
            {
                user = account[0];
                Boolean isAdmin = Context.UserPermissions.ToList().Where(p => p.UserId == user.UserId && p.PermissionId == 1).Count() != 0;
                HttpContext.Session.SetString("UserId", user.UserId.ToString());
                if (isAdmin)
                    return RedirectToAction("Index");
                else
                    return RedirectToAction("Privacy");
            }
            return View(user);
        }
    }
}
