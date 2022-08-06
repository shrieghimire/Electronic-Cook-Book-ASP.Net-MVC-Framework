using Microsoft.AspNetCore.Mvc;
using ECB.Models;
namespace ECB.Controllers
{
    public class FoodsController : Controller
    {
        public DatabaseContext _context;

        public FoodsController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var food = _context.Foods.ToList();//select * from <table_name>
            return View(food);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Food fs)
        {
            if (ModelState.IsValid)
            {
                var e = new Food()
                {
                    Name = fs.Name,
                    Description = fs.Description
                };
                _context.Foods.Add(e);
                _context.SaveChanges();
                TempData["msg"] = "Saved Succesfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Some error ocured";
                return View();
            }
        }
        public IActionResult Remove(int id)
        {
            var em = _context.Foods.SingleOrDefault(f => f.Id == id);//select * from foods where id=f 
            _context.Foods.Remove(em);
            _context.SaveChanges();
            TempData["msg"] = "Succesfully Deleted";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {  
            var em = _context.Foods.SingleOrDefault(f => f.Id == id);
            return View(em);
        }
        [HttpPost]
        public IActionResult Edit(Food f)
        {
            if (ModelState.IsValid)
            {
                _context.Foods.Update(f);
                _context.SaveChanges();
                TempData["msg"] = "Updated Succesfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = "Error Occured";
                return View();
            }
        }
    }
}