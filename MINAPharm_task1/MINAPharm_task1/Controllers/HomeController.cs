using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MINAPharm_task1.Models;
using MINAPharm_task1.Models.Data;
using MINAPharm_task1.Models.Reprosatory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MINAPharm_task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Irepoassets<Assets>minapharmasset;

        public HomeController(Irepoassets<Assets> asset)
        {
            this.minapharmasset= asset; 
        }

        public IActionResult Index()
        {
            var model = minapharmasset.getallassets();

            return View(model);
        }
        public IActionResult create()
        {

            ViewBag.assets = minapharmasset.getallassets();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult create(Assets assets)
        {

            if(ModelState.IsValid)
            {
                minapharmasset.creat(assets);

                return RedirectToAction("index");
            }
            ViewBag.assets = minapharmasset.getallassets();
            return View();
        }
        public IActionResult search  (int id)
        {

            var x = minapharmasset.search( id);
           
            return View(x);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Edit (int id )
        {
            ViewBag.assets = minapharmasset.getallassets();
            var x = minapharmasset.search(id);

            return View("create",x);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Assets assettt)
        {

            if(ModelState.IsValid)
            {
                minapharmasset.update(assettt);
                return RedirectToAction("index");
            };


            return View(assettt);
        }

        public IActionResult delete(int id)
        {

            var x = minapharmasset.search(id);
            if(x!=null)
            {
                minapharmasset.delete(id);
            }
            return RedirectToAction("index");
        }

        //[HttpPost,ActionName("delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult deleted(int id)
        //{

        //    minapharmasset.delete(id);
        //    return RedirectToAction("index");

        //}









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
