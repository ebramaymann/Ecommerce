using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Home()
        {
            //Data to be passed to the view
            string Name = "Ebram";
            int Age = 27;
            double Salary = 5000;
            
            var person = new { Name, Age, Salary };

            return View(model: person );
            
        }
    }
}
