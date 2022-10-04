using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sho3lah.Models;
using System.Linq;

namespace Sho3lah.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDBContext cont;

        public BookController(AppDBContext context)
        {
            cont = context;
        }
        public IActionResult Index()
        {
            var data = cont.Books.ToList();

            return View(data);
        }
        public IActionResult Search(string SearchKey)
        {
            var wanted = cont.Books.Where(b => b.Name.Contains(SearchKey)).OrderBy(b => b.Name).ToList();
            return View(wanted);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            ViewBag.Action = "Add";
            return View("AddBook", new Book());
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                if (book.BookID == 0)
                    cont.Books.Add(book);
                else
                    cont.Books.Update(book);
                cont.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action =
                    (book.BookID == 0) ? "Add" : "Edit";
                return View(book);
            }
        }
    }
}
