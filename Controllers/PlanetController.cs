using Microsoft.AspNetCore.Mvc;
using MVC1.Services;

namespace MVC1.Controllers
{
    [Route("he-mat-troi")]
    public class PlanetController : Controller
    {

        private readonly PlanetService _planetService;
        private readonly ILogger<PlanetController> _logger;

        public PlanetController( ILogger<PlanetController> logger, PlanetService planetService)
        {
            _planetService = planetService;
            _logger = logger;
        }
        // GET: Planet
        //        [Route("/danh-sach")] => ko ket hop => Action Route = danh-sach
        [Route("danh-sach")]
        public ActionResult Index() // => Controller Route / Action Route = he-mat-troi/danh-sach
        {
            return View();
        }

        [BindProperty(SupportsGet =true, Name = "action")]
        public string Name {get;set;}

        [Route("sao/[action]", Order = 2, Name ="route1")] // sao/Mercury
        [Route("sao/[controller]/[action]", Order = 1, Name ="route2")] // sao/
        [Route("sao/[controller]-[action]", Order = 3, Name ="route3")] // sao/
        public ActionResult Mercury()
        {
            var planet = _planetService.Where( p=>p.Name == Name).FirstOrDefault();
            return View("Details", planet);
        }


        [Route("hanhtinh/{id:int?}")] // planet/hanhtinh
        public IActionResult PlanetInfor(int? id)
        {
            if(id == null)
                return View("Index");
            var planet = _planetService.Where(p => p.Id == id).FirstOrDefault();
            return View("Details", planet);
        }
    }
}
