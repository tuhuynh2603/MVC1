using Microsoft.AspNetCore.Mvc;
using MVC1.Services;

namespace MVC1.Controllers
{

    [Area("ProductManage")]
    public class ProductController : Controller
    {
        // GET: Product
        //[Route("[Controller]")]

        private readonly ProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController( ILogger<ProductController> logger, ProductService productService)
        {
            _productService = productService;
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View(_productService);
        }

    }
}
