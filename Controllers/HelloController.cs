using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("index")]
        // public async Task<string> Index()
        // {
        //     await Task.Delay(1000);
        //     return "Hello";
        // } OR 
        public IActionResult Index(){
            return View("index");
        }


        [HttpPost]
        [Route("/result")]
        public IActionResult result(string name,string loc, string fav, string comment)
        {
            Dictionary<string, string> infoList = new Dictionary<string, string>();
            infoList.Add("Name",name);
            infoList.Add("Location", loc);
            infoList.Add("Favorite Lang",fav);
            infoList.Add("Comment",comment);

            ViewBag.infoList = infoList;      
            return View("result");
        }

        
        
        

    }

}