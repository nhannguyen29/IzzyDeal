using System.Net;
using IzzyDeal.Models;
using Microsoft.AspNet.Mvc;

namespace IzzyDeal.Controllers
{
    [RouteAttribute("/")]
    public class HomeController : Controller
    {
        private IIzzyDealRepository _repository;
        
        public HomeController(IIzzyDealRepository repository)
        {
            _repository = repository; 
        }

        public IActionResult Index()
        {
            var deals = _repository.GetAllDeal();
            return View(deals);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpGetAttribute("")]
        public JsonResult Get()
        {
            var result = _repository.GetAllDeal();
            return Json(result);
        }

        [HttpPostAttribute("")]
        public JsonResult Post([FromBodyAttribute]Deal newDeal)
        {
            if (ModelState.IsValid)
            {
                Response.StatusCode = (int) HttpStatusCode.Created;
                return Json(true);
            }
            else
            {
                Response.StatusCode = (int) HttpStatusCode.BadRequest;
                return Json(false);
            }
        }
    }
}
