using Microsoft.AspNetCore.Mvc;
using mvcEntityFrameworkCRUDProject.Context;
using mvcEntityFrameworkCRUDProject.Models;

namespace mvcEntityFrameworkCRUDProject.Controllers
{
    public class UserController : Controller
    {
        public DatabaseContext _context;
        public UserController(DatabaseContext context) {

            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", user);
        }
    }
}
