using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HethongPhanPhoiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string MaHTPP, string TenHTPP)
        {
            string strOutput = " Xin chào " + MaHTPP + "-" + TenHTPP;
            ViewBag.HeThongPhanPhoi = strOutput;
            return View();
        }
    }
}