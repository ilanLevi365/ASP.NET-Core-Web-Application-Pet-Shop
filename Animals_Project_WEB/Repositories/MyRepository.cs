using Animals_Project_WEB.Data;
using Animals_Project_WEB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Repositories
{
    public class MyRepository : IRepository
    {
        private HrContext _context;
        public int Category_Select { get; set; }

        public MyRepository(HrContext context)
        {
            _context = context;
        }

        public IEnumerable<Animal> Get_Animals()
        {
            var animals = _context.Animals
                 .Include(animal => animal.Category)
                 .Include(animal => animal.Comments)
                 .ToList();
            return animals;
        }

        public IEnumerable<Comment> Get_Comments()
        {
            var comment = _context.Comments
                .ToList();
            return comment;
        }

        public void Insert_Animal(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
        }

        public void Update_Animal(Animal animals)
        {
            var animal_In_Db = _context.Animals.SingleOrDefault(m => m.AnimalId == animals.AnimalId);
            animal_In_Db.Name = animals.Name;
            animal_In_Db.Age = animals.Age;
            animal_In_Db.Picture_Name = animals.Picture_Name;
            animal_In_Db.Description = animals.Description;
            animal_In_Db.CategoryId = animals.CategoryId;
            _context.SaveChanges();
        }

        public void Delete_Animal(int id)
        {
            var animal = _context.Animals.SingleOrDefault(m => m.AnimalId == id);
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }

        public void Insert_Comment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

    }
}