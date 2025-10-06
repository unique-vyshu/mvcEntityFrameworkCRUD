using Microsoft.AspNetCore.Mvc;
using mvcEntityFrameworkCRUDProject.Context;
using mvcEntityFrameworkCRUDProject.Models;

namespace mvcEntityFrameworkCRUDProject.Controllers
{
    public class EmpController : Controller
    {
        public DatabaseContext _context;

        public EmpController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Emps.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                _context.Emps.Add(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}
