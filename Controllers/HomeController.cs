using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeGotchi.Models;

namespace PokeGotchi.Controllers
{
    public class HomeController : Controller
    {
        public static Pikachu Pika = new Pikachu();
        [HttpGet("")]
        public IActionResult Index()
        {   
            return View(Pika);
        }

        [HttpGet("Feed")]
        public IActionResult Feed()
        {
            Pika.Feed();
            return RedirectToAction("Index");
        }

        [HttpGet("Play")]
        public IActionResult Play()
        {
            Pika.Play();
            return RedirectToAction("Index");
        }

        [HttpGet("Work")]
        public IActionResult Work()
        {
            Pika.Work();
            return RedirectToAction("Index");
        }

        [HttpGet("Sleep")]
        public IActionResult Sleep()
        {
            Pika.Sleep();
            return RedirectToAction("Index");
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            Pika = new Pikachu();
            return RedirectToAction("Index");
        }
    }
}
