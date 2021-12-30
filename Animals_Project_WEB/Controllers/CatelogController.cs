using Animals_Project_WEB.Data;
using Animals_Project_WEB.Models;
using Animals_Project_WEB.Repositories;
using Animals_Project_WEB.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Controllers
{
    public class CatelogController : Controller
    {
        private IRepository _repository;
        private Category_Select _category_Select;
        private static int _animal_Id;

        public CatelogController(IRepository repository)
        {
            _repository = repository;
            _category_Select = new Category_Select();
        }

        public IActionResult Index()
        {
            ViewBag.category_Id = 1;
            return View();
        }

        public IActionResult Category_Id(Category_Select category_Select)
        {
            ViewBag.category_Id = category_Select.CategorySelect;
            return View("Index");
        }

        public IActionResult Details_Comments(int animal_Id = 1)
        {
            _animal_Id = animal_Id;
            ViewBag.animal_Id = animal_Id;
            return View();
        }


        [MyExceptionFilter]
        public IActionResult Add_Comment(New_Comment new_Comment)
        {
            _repository.Insert_Comment(new Comment() { AnimalId = _animal_Id, Coment = new_Comment.NewComment });
            ViewBag.animal_Id = _animal_Id;
            return RedirectToAction("Details_Comments", new { animal_Id = _animal_Id });
        }
    }
}
