using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }
        public List<Comment> Comments { get; set; }
    }
    public class Category_Select { public int CategorySelect { get; set; } }
}
