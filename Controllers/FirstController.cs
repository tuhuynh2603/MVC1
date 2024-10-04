using Microsoft.AspNetCore.Mvc;
using MVC1.Services;

namespace MVC1.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;
        public FirstController(ILogger<FirstController> logger, ProductService productService)
        {
            _logger = logger;  
            _productService = productService;
        }
    
        public string Index()
        {
            //this.HttpContext;
            //this.Request;
            //this.Response;
            //this.RouteData;

            //this.User
            //this.ModelState
            //this.ViewData
            //this.Url
            //this.TempData
            _logger.LogWarning("warning");
            _logger.LogInformation("First Controller Index Action");
            return "Hello, First Controller!";
        }

        public object Anything() => new int []{1,2,3};


        public IActionResult Readme()
        {
            var content = @"Xin chao,
                            asp.net.mvc
                            Magnus
                            ";

                            return Content(content, "text/plain");
        }

        public IActionResult Privacy()
        {
            var url = Url.Action("Privacy", "Home");
            return LocalRedirect(url);
        }

        public IActionResult Google()
        {
            var url = "https://google.com";
            return Redirect(url);
        }   

        //ViewResult | View() 
        public IActionResult HelloView(string userName) 
        {
            if(string.IsNullOrEmpty(userName))
                userName = "Guest";
            
            //View() -> Razor Engine, read .cshtml (template)
            return View("/MyView/View1.cshtml", userName);
        }
        
        public IActionResult HelloView2(string userName) 
        {
            if(string.IsNullOrEmpty(userName))
                userName = "Guest";
            
            //View2.cshtml -> /View/First/View2.cshtml
            return View("View2", userName);
        }

        public IActionResult HelloView3(string userName) 
        {
            if(string.IsNullOrEmpty(userName))
                userName = "Guest";
            
            //View2.cshtml -> /View/First/View2.cshtml
            return View((object)userName);
        }
        public IActionResult HiView3(string userName) 
        {
            
            return View("View3");
        }

        public IActionResult ViewProduct(int? id)
        {
            var product = _productService.Where( p => p.ProductId == id ).FirstOrDefault();
            if(product == null)
            {
                TempData["StatusMessage"] = "San pham ban yeu cau ko co";
              return Redirect(Url.Action("Index", "Home"));
            }


            return View(product);
        }

        public IActionResult ViewProduct2(int? id)
        {
            var product = _productService.Where( p => p.ProductId == id ).FirstOrDefault();
            if(product == null)
                return Content($"San Pham khong ton tai");
            this.ViewData["product"] = product;
            return View();
        }
                public IActionResult ViewProduct3(int? id)
        {
            var product = _productService.Where( p => p.ProductId == id ).FirstOrDefault();
            if(product == null)
                return Content($"San Pham khong ton tai");
            this.ViewBag.product = product;
            return View();
        }
    }
}