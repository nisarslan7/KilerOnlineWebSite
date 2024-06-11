using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KilerOnline.WebUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        private IUserService _UserService;
        private IFoodService _FoodService;
        private IProductService _ProductService;
        private IProductRepository _ProductRepository;
        private IFoodRepository _FoodRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserController(IUserService UserService, IFoodService FoodService, IProductService ProductService, IWebHostEnvironment webHostEnvironment, ILogger<AdminController> logger, IProductRepository ProductRepository, IFoodRepository foodRepository)
        {
            _UserService = UserService;
            _FoodService = FoodService;
            _ProductService = ProductService;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
            _ProductRepository = ProductRepository;
            _FoodRepository = foodRepository;
        }

        public IActionResult IcAnadoluUrun()
        {
            int regionId = 5; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);
        }
        public IActionResult IcAnadoluYemek()
        {
            int regionId = 5; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);
        }
        public IActionResult AkdenizUrun()
        {

            int regionId = 1; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);



        }
        public IActionResult AkdenizYemek()
        {
            int regionId = 1; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);

        }
        public IActionResult DoguAnadoluUrun()
        {
            int regionId = 2; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);
        }
        public IActionResult DoguAnadoluYemek()
        {
            int regionId = 2; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);
        }
        public IActionResult GuneyDoguAnadoluUrun()
        {
            int regionId = 4; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);
        }
        public IActionResult GuneyDoguAnadoluYemek()
        {
            int regionId = 4; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);
        }
        public IActionResult KaradenizUrun()
        {
            int regionId = 6; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);
        }
        public IActionResult KaradenizYemek()
        {
            int regionId = 6; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);
        }
        public IActionResult MarmaraUrun()
        {
            int regionId = 7; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);
        }
        public IActionResult MarmaraYemek()
        {
            int regionId = 7; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);
        }
        public IActionResult EgeUrun()
        {
            int regionId = 3; // Akdeniz bölgesi için sabit region id
            var products = _ProductRepository.GetProductsByRegionId(regionId);
            return View(products);
        }
        public IActionResult EgeYemek()
        {
            int regionId = 3; // Akdeniz bölgesi için sabit region id
            var foods = _FoodRepository.GetFoodsByRegionId(regionId);
            return View(foods);
        }
    }
}
