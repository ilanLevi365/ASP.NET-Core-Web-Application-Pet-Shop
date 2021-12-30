using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB.Validators
{
    public class AllLetters_Validation_Attribute : ValidationAttribute
    {
        [MyExceptionFilter]
        public override bool IsValid(Object value)
        {         
                return ((string)value).All(Char.IsLetter);          
        }
    }
}
