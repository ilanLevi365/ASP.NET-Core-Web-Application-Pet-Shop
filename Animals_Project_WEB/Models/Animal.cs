using Animals_Project_WEB.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Models
{
    public class Animal
    {        
       [HiddenInput(DisplayValue=false)]
        public int AnimalId { get; set; }

        [AllLetters_Validation_Attribute(ErrorMessage = "Only letters should be entered.")]
        [Required]
        [Display(Name = "Animal Name:")]
        public string Name { get; set; }

        [Range(1,500)]
        [Display(Name = "Animal Age:")]
        public int Age { get; set; }
     
        [Display(Name = "String Animal Image:")]
        public  string  Picture_Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Range(1, 3)]
        [Display(Name = "Animal Category Id:")]
        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }


        [NotMapped]
        public  IFormFile  Img_File { get; set; } 
    } 
}
