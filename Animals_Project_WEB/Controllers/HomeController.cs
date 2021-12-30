using Animals_Project_WEB.Models;
using Animals_Project_WEB.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var new_Two_Popular = (from two_Popular in _repository.Get_Comments()
                                   group two_Popular by new { two_Popular.AnimalId } into gr
                                   select new
                                   {
                                       Key = gr.Key.AnimalId,
                                       Count = gr.Count()
                                   }).OrderByDescending(k => k.Count).Take(2).ToList();
            ViewBag.Popular1 = new int[2];
            ViewBag.Popular1[0] = new_Two_Popular[0].Key;
            ViewBag.Popular1[1] = new_Two_Popular[0].Count;
            ViewBag.Popular2 = new int[2];
            ViewBag.Popular2[0] = new_Two_Popular[1].Key;
            ViewBag.Popular2[1] = new_Two_Popular[1].Count;
            return View();
        }
    }
}