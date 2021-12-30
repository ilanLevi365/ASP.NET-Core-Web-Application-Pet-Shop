using Animals_Project_WEB.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        [AllLetters_Validation_Attribute(ErrorMessage = "Only letters should be entered.")]
        public string Coment { get; set; }
    }
    public class New_Comment { public string NewComment { get; set; } }
}
