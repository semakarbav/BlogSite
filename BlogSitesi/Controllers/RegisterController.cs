using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSitesi.Controllers
{
    public class RegisterController : Controller
    {
        IWriterService _writerService;

        public RegisterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.Status = true;
            writer.About = "Deneme Test";
            _writerService.WriterAdd(writer);
            return RedirectToAction("Index","Blog");
        }
    }
}
