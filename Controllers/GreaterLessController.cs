//Lerissa Lazar
//10-25-22
//Greater Than or Less than
//This is a webapi that gets inputs (number) and returns an answer if its greater than or less than
//peer review: Pedro Castaneda - I really like the clean code! The only thing I would try adding is some validatoin. But other than the your program works great! Nice job.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_GreaterOrLessEndPoint.Controllers
{
    [Route("[controller]")]
    public class GreaterLessController : Controller
    {
        [HttpGet]
        [Route("GreatOrLess/{num1}/{num2}")]
        public string GreatOrLess(int num1, int num2)
        {
            if(num1 < num2) 
            {
            return $"{num1} is less than {num2}";
            }
            if(num1 > num2)
            {
            return $"{num1} is greater than {num2}";
            }
            return $"{num1} is equal to {num2}";
        }
    }
}