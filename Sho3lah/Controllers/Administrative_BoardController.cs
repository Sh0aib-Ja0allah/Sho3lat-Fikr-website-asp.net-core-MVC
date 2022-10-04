using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sho3lah.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Sho3lah.Controllers
{
    public class Administrative_BoardController : Controller
    {
        private readonly AppDBContext _context;

        public Administrative_BoardController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = _context.Authors.ToList();
            return View(data);
        }
    }
}
