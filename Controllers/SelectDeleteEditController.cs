using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server;

namespace FindTutor.Controllers
{
    public class SomeRequest
    {
        public string name{get;set;}
    }
    public class SelectDeleteEditController : Controller
    {
        public IActionResult Index() {
            return View("~/Views/practicesAJAX.cshtml");
        }
        public  IActionResult HostRowDelete(SomeRequest context)
        {

           
           Console.WriteLine(context.name);



            return Ok(200);
        } 
    }
}