using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess.Concrete;
using KilerOnline.Entities.Abstact;
using KilerOnline.Entities.Concrete;
using KilerOnline.WebUI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KilerOnline.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private IUserService _UserService;
        private IFoodService _FoodService;
        private IProductService _ProductService;
       
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(IUserService UserService, IFoodService FoodService, IProductService ProductService, IWebHostEnvironment webHostEnvironment, ILogger<AdminController> logger)
        {
            _UserService = UserService;
            _FoodService = FoodService;
            _ProductService = ProductService;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _UserService.CreateUser(user);
            return View();
        }
        public IActionResult RemoveUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RemoveUser(int id)
        {
            try
            {
                _UserService.DeleteUser(id);
                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel
                {
                    ErrorMessage = "Kullanıcı silme işlemi sırasında bir hata oluştu: " + ex.Message
                };
                return View("Error", errorModel);
            }
        }
        public IActionResult RemoveProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RemoveProduct(int id)
        {
            try
            {
                _ProductService.DeleteProduct(id);
                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel
                {
                    ErrorMessage = "Kullanıcı silme işlemi sırasında bir hata oluştu: " + ex.Message
                };
                return View("Error", errorModel);
            }
        }
        public IActionResult RemoveFood()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RemoveFood(int id)
        {
            try
            {
                _FoodService.DeleteFood(id);
                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel
                {
                    ErrorMessage = "Kullanıcı silme işlemi sırasında bir hata oluştu: " + ex.Message
                };
                return View("Error", errorModel);
            }
        }
        public IActionResult AddFood()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFood(Food food, IFormFile formFile)
        {

            if (formFile != null)
            {
                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Foods", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                food.ImageUrl = $"{randomName}";
            }
            _FoodService.CreateFood(food);
            return View();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product,IFormFile formFile)
        {
            if (formFile != null)
            {
                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Products", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                product.ImageUrl = $"{randomName}";
            }
            _ProductService.CreateProduct(product);
            return View();
        }
        
        public IActionResult UpdateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            var existinguser = _UserService.GetUserById(user.Id);
            existinguser.UserName = user.UserName;
            existinguser.Name = user.Name;
            existinguser.Password = user.Password;
            existinguser.RoleId = user.RoleId;

            _UserService.UpdateUser(existinguser);
            return View();
        }
        public IActionResult UpdateFood()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFood(Food food, IFormFile formFile)
        {
            var existingfood = _FoodService.GetFoodById(food.Id);
            existingfood.Name = food.Name;
            existingfood.Preparation = food.Preparation;
            existingfood.Time = food.Time;
            existingfood.PersonCount = food.PersonCount;
            existingfood.Story = food.Story;
            existingfood.Ingredients = food.Ingredients;
            if (formFile != null)
            {
                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Foods", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                food.ImageUrl = $"{randomName}";
            }
            existingfood.ImageUrl = food.ImageUrl;
            existingfood.CategoryId = food.CategoryId;
            existingfood.RegionId = food.RegionId;
            
            _FoodService.UpdateFood(existingfood);
            return View();
        }
        public IActionResult UpdateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product, IFormFile formFile)
        {
            var existingproduct = _ProductService.GetProductById(product.Id);
            existingproduct.Name = product.Name;
            existingproduct.ProductExplanation = product.ProductExplanation;
            if (formFile != null)
            {
                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Products", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                product.ImageUrl = $"{randomName}";
            }
            existingproduct.ImageUrl = product.ImageUrl;
            existingproduct.RegionId = product.RegionId;

            _ProductService.UpdateProduct(existingproduct);
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
