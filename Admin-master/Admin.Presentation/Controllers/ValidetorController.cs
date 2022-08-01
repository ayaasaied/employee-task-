using Microsoft.AspNetCore.Mvc;
using System;

namespace Admin.Presentation.Controllers
{
    public class ValidetorController : Controller
    {
       

       [HttpGet]
        public IActionResult validatDate( string _date)
        {
            DateTime date = DateTime.Parse(_date);
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - date.Year;
            if (date.Year < today.Year)
            {
                {
                    if (age > 18)

                        return Json(true );

                }
            }
            return Json(false);
        }





    }
}
