using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess;
using KilerOnline.DataAccess.Concrete;
using KilerOnline.Entities.Abstact;
using KilerOnline.Entities.Concrete;
using KilerOnline.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using System.Diagnostics;

namespace KilerOnline.WebUI.Controllers
{
	public class HomeController : Controller
	{
        private IUserService _UserService;
        private IFoodService _FoodService;
        private IProductService _ProductService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IUserService UserService, IFoodService FoodService, IProductService ProductService, ILogger<HomeController> logger)
        {
            _UserService = UserService;
            _FoodService = FoodService;
            _ProductService = ProductService;
            _logger = logger;
        }
        public IActionResult Index()
		{
			return View();
		}
        public IActionResult Login()
        {
            return View();
        }
		[HttpPost]
        public IActionResult Login(LoginVM login)
        {
			var user = _UserService.FindUser(login);
			if (user != null)
			{
				if (user.RoleId == 1)
				{
					return RedirectToAction("Index", "Admin");
				}
				if (user.RoleId == 2)
				{
					return RedirectToAction("Index", "User");
				}
			}
			return View();
        }
        
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            _UserService.CreateUser(user);
            return View();
        }
        public IActionResult About()
		{
			return View();
		}
        
        
	}
}
