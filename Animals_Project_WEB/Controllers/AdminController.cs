using Animals_Project_WEB.Models;
using Animals_Project_WEB.Repositories;
using Animals_Project_WEB.Validators;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Controllers
{
    public class AdminController : Controller
    {
        private IRepository _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private static int _id = 1;
        private static int _category_Id;

        public AdminController(IRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.category_Id = 1;
            return View();
        }
       
        public IActionResult Category_Id(Category_Select category_Select)
        {
            _category_Id = category_Select.CategorySelect;
            ViewBag.category_Id = category_Select.CategorySelect;
            return View("Index");
        }
       
        public IActionResult Add_Animal()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimalId, Name, Age, Description, CategoryId, Img_File")] Animal animal)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(animal.Img_File.FileName);
            string extension = Path.GetExtension(animal.Img_File.FileName);
            animal.Picture_Name = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await animal.Img_File.CopyToAsync(fileStream);
            }
            if (ModelState.IsValid)
            {
                _repository.Insert_Animal(animal);
                return RedirectToAction("Index");
            }
            return View("Add_Animal");
        }

        [MyExceptionFilter]
        public IActionResult Edit(Animal animal)
        {
            if (ModelState.IsValid)
            {
                animal.AnimalId = _id;
                _repository.Update_Animal(animal);
                return View("Index");
            }
            else
            {
                return View("New_Edit");
            }          
        }

        [MyExceptionFilter]
        public IActionResult New_Edit(int id)
        {
            Animal animal = new Animal();
            foreach (var item in _repository.Get_Animals())
            {
                if (item.AnimalId == id) animal = item;
            }
            _id = id;
            ViewBag.id = _id;
            return View(animal);
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete_Animal(id);
            ViewBag.category_Id = _category_Id;
            return RedirectToAction("Index");
        }

      
    }
}