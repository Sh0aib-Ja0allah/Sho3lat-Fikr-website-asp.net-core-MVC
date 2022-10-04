using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sho3lah.Models;
using System.Linq;
using System.Threading.Tasks;


namespace Sho3lah.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDBContext _context;

        public AuthorsController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Authors.ToList();
            return View(data);
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var author = _context.Authors.Find(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Delete(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            if (ModelState.IsValid)
            {
                if (author.AuthorID == 0)
                    _context.Authors.Add(author);
                else
                    _context.Authors.Update(author);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action =
                    (author.AuthorID == 0) ? "Add" : "Edit";
                return View(author);
            }
        }


        [HttpGet]
        public IActionResult AddAuthor()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Author());
        }


    }
}
