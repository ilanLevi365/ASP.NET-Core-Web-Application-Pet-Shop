using Animals_Project_WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Repositories
{
    public interface IRepository
    {
        int Category_Select { set; get; }
        IEnumerable<Animal> Get_Animals();
        IEnumerable<Comment> Get_Comments();
        void Insert_Animal(Animal animals);
        void Update_Animal(Animal animals);
        void Delete_Animal(int id);
        void Insert_Comment(Comment comment);
    }
}
