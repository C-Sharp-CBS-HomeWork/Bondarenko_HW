using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            MyModel[] myModels = new MyModel[3] 
            {
                new MyModel(1,"First model"),
                new MyModel(2,"Second model model"),
                new MyModel(3,"Third model model model")
            };

            return View(myModels);
        }
    }
}
