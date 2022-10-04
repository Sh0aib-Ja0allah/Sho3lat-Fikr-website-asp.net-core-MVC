using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sho3lah.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Sho3lah.Controllers
{
    public class MemberController : Controller
    {
        private readonly AppDBContext _context;

        public MemberController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Members.ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Edit(int id)

        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                if (member.MemberID == 0)
                    _context.Members.Add(member);
                else
                    _context.Members.Update(member);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action =
                    (member.MemberID == 0) ? "Add" : "Edit";
                return View(member);
            }
        }


        [HttpGet]
        public IActionResult AddMember()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Member());
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var member = _context.Members.Find(id);
            return View(member);
        }

        [HttpPost]
        public IActionResult Delete(Member member)
        {
            _context.Members.Remove(member);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
