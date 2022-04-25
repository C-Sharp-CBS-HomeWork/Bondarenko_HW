using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int op1, int op2)
        {
            return View("MathRez", op1 + op2);
        }
        public IActionResult Div(int op1, int op2)
        {
            return View("MathRez", op1 / op2);
        }
        public IActionResult Mul(int op1, int op2)
        {
            return View("MathRez", op1 * op2);
        }
        public IActionResult Sub(int op1, int op2)
        {
            return View("MathRez", op1 - op2);
        }
    }
}
