using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;
using System.Data.Entity;
using ToDoList.ViewModels;

namespace ToDoList.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        private ApplicationDbContext _context;

        public ItemController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var item = _context.toDoItems.Include(s => s.Status).ToList();
            return View(item);
        }

        public ActionResult Edit(int id)
        {
            var item = _context.toDoItems.SingleOrDefault(i => i.Id == id);

            var viewModel = new ItemViewModel
            {
                ToDoItem = item,
                Statuses = _context.Statuses.ToList()
            };

            return View("Edit", viewModel);
        }
    }
}