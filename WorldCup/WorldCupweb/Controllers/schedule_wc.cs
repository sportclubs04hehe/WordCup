using Microsoft.AspNetCore.Mvc;

namespace WorldCupweb.Controllers
{
    public class schedule_wc : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(int doi1, int doi2, int matran)
        {
            ViewData["doi1"] = "result  :" + doi1;
            ViewData["doi2"] =  doi2;
            ViewData["matran"] = matran;
            return View();
        }
        
    }
}
